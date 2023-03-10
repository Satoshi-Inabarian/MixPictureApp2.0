using Microsoft.SmallBasic.Library;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Media.Animation;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Shapes;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
//自作ライブラリ
using SatoLib;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.InteropServices;

namespace MixPictureApp
{
    public partial class RdmPicGame : Form
    {
        //コンソール立ち上げたい時使う
        [System.Runtime.InteropServices.DllImport("kernel32.dll")] // この行を追加
        private static extern bool AllocConsole();                 // この行を追加  

        private CancellationTokenSource cts = null; // キャンセルトークン

        /// <summary>
        /// /メンバ変数（インスタンス変数）※静的関数は使えないので注意！(static)
        //初期ディレクトリ
        private string curdir = Environment.CurrentDirectory;
        //定数(初期値)
        //サウンドディレクトリ設定
        private string SOUNDPATH = Environment.CurrentDirectory + "\\sound\\";
        private string SOUND_FINPATH = Environment.CurrentDirectory + "\\sound\\final\\";
        private double HARD_SPANTIME = 0.7;//難易度が高い時のカウントスパン（短くするほどカウントがはやくなる)
        private int TIMER_CNT = 5;//タイマー初期値 定数
        private int MXIMG_CNT = 6;
        //変数
        private int time_remain;//残り秒数表示の変数
        private int Pt;//取得ポイント変数
        private int Mxp;//最大得点
        private List<Image> ImgList;//画像リスト
        private List<Image> CharaImgList;//キャラクターリスト
        private bool StartFlag = false;
        /// </summary>


        //コンストラクタ
        public RdmPicGame()
        {
            InitializeComponent();
            //コンソール起動
            AllocConsole();
        }


        private  void BtnStart_Click(object sender, EventArgs e)
        {
            StartFlag = true; //スタートボタンフラグON

            //スタートボタンを押した後の処理
            if (StartFlag == true)
            {
                try
                {
                    //フォルダダイアログより、画像取得
                    string folderpath = textBox1.Text;
                    ImgList = library.getImageList(folderpath);//画像リスト
                    ImgList = library.shuffleImgList(ImgList);//それをシャッフル
                                                              //画像がなかった場合

                    if (ImgList.Count == 0)//例外処理
                    {
                        MessageBox.Show("画像を読み込むことができません。フォルダにjpg,png画像ファイルがあるか確認してください。");
                        StartFlag = false;
                        return;
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine($"error occurred:{ex}");
                    StartFlag = false;
                    return;
                }

                //カウンター、ポインターセット
                int lv = setCnt_Pt_Lv();
                //最大得点計算
                Mxp = setMaxPt();
                //Console.WriteLine("【L106】TIMER_CNT:{0},POINT:{1}", TIMER_CNT, Pt);
                //キャラクター画像セット
                setChar(lv);
                bool flag = is_CharImg(MXIMG_CNT);
                if (!flag)
                {
                    MessageBox.Show($"画像は最大{MXIMG_CNT}つ以上用意してください", "エラー");
                    return;
                }
                //ボタン・ラベル設定（表示/非表示）
                setViewing(lv);
                //最初の画像を表示させる。
                try
                {
                    viewAndDel_Picidx(ImgList);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"error occurred:{ex}");
                    StartFlag = false;
                    return;
                }

                //タイマー起動
                    //キャンセルトークンの取得(ctsがインスタンス)
                    this.cts = new CancellationTokenSource();
                    CancellationToken token = cts.Token;
                try
                {
                    Task.Run(() => countTimer(TIMER_CNT,lv, token));//マルチ処理
                    //戻り値ほしい場合 Task t1 = Task.Factory.StartNew(() => countTimer(TIMER_CNT, token));
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"error occurred:{ex}");
                    Reset(5, 0);
                    return;
                }
                return;
            }
        }


        public void BtnOpenFile_Click(object sender, EventArgs e)
        {
            using (var cofd = new CommonOpenFileDialog()
            {
                Title = "フォルダを選択してください",
                // フォルダ選択モードにする
                RestoreDirectory = true,
                IsFolderPicker = true,
            })

            {
                if (cofd.ShowDialog() != CommonFileDialogResult.Ok)
                {
                    return;
                }
                // FileNameで選択されたフォルダを取得する
                textBox1.Text = cofd.FileName;
            }

        }

        private async void BtnNextPicture_Click(object sender, EventArgs e)
        {
            //例外処理
            if (this.cts == null)
            {
                return;
            }

            //本ソース

            //1.タイマー停止
            try {
            cts.Cancel();
            //2.正解時効果音の再生
            PlayShuffleSound(SOUNDPATH);
            //3.得点計算処理
            string pt_str = LabelPoint.Text;
            string tim_str = LabelTimer.Text;
            int pt_int = Convert.ToInt32(pt_str);
            int tim_int = Convert.ToInt32(tim_str);
            Pt = pt_int + tim_int;
            LabelPoint.Text = Convert.ToString(Pt);
            //4.キャラクター画像更新
            updateChar();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"error occured{ex}");
                Reset(5, 0);
            }

            //5.絵の表示分岐へ
            //残りの絵がない場合
            try
            {
                if (ImgList.Count < 1)
                {
                    PlayShuffleSound(SOUND_FINPATH);
                    await Task.Run(() => End(1));
                    Thread.Sleep(3000);
                    return;
                }
                else
                {
                    //5タイマーキャンセルトークンの再発行
                    this.cts = new CancellationTokenSource();
                    CancellationToken token = this.cts.Token;
                    //6.最終フラグ確認
                    int idx_remain = ImgList.Count;
                    bool flag = isLastPic(idx_remain);
                    if (flag)
                    {
                        BtnNextPicture.Text = "さいごだ！";
                    }
                    //7.絵の表示
                    viewAndDel_Picidx(ImgList);
                    //8.タイマー再起動
                    LabelTimer.Text = TIMER_CNT.ToString();
                    int lv = getLevel();
                    await Task.Delay(500);//タイマー起動を遅らせる
                    await Task.Run(() => countTimer(TIMER_CNT, lv, token));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"error occurred{ex}");
            }
        }



        private async void BtnSkip_Click(object sender, EventArgs e)
        {
            try
            {
                //タイマーキャンセル
                cts.Cancel();
                //最後の画像であるかチェック
                if (ImgList.Count == 0) 
                {
                    PlayShuffleSound(SOUND_FINPATH);
                    await Task.Run(() => End(1));
                    Thread.Sleep(3000);
                    return;
                }
                //画像表示
                viewAndDel_Picidx(ImgList);
                //キャンセルトークンの再発行
                this.cts = new CancellationTokenSource();
                CancellationToken token = this.cts.Token;
                //タイマー起動
                int lv= getLevel();
                Task.Run(() => countTimer(TIMER_CNT, lv, token));
            }
            catch (Exception ex)
            {
                Console.Write($"error occurred:{ex}");
            }
            

        }

        private void BtnTimer_Load(object sender, EventArgs e)
        {
            textBox1.Text = $"{curdir}\\images\\";
        }


        private void BtnReset_Click_1(object sender, EventArgs e)
        {
            //例外処理
            if (this.cts == null)
            {
                return;
            }
            cts.Cancel();
            bool eflag = End(0);
            Console.WriteLine("flag:{0}",eflag);
        }

        /////////////////メソッド////////////////////
        private void countTimer(int COUNT,int level, CancellationToken token)
        {
            Thread.Sleep(500);
            
            int CountSpanTime = 1000;//いじらない
            if  (level == 2)//むずかしい
            {
                //スピード変更
                double tmp = CountSpanTime * HARD_SPANTIME;
                CountSpanTime = Convert.ToInt32(tmp);
            }

            for (int n = 0; n <= COUNT; n++)
            {
                //1.残り秒数表示
                time_remain = COUNT - n;
                LabelTimer.Text = time_remain.ToString();
                //2.カウント
                Thread.Sleep(CountSpanTime);
                if (token.IsCancellationRequested)
                {
                    LabelTimer.Text = TIMER_CNT.ToString();
                    return;
                }
            }
        }

        //画像表示
        public int viewAndDel_Picidx(List<Image> list)
            {
            PictureBox1.Image = null;//リセット
            try
            {
                PictureBox1.Image = list[0];//絵を表示

                list.RemoveAt(0);        //表示した絵を削除
            }
            catch (Exception e)
            {
                Console.WriteLine($"error occured:{e}");
            }
            return ImgList.Count;
        }

        private int setCharStage(int pt,int mxp)
        {
            try
            {
                int CharStg;
                if (pt >= mxp * 0.8)
                    CharStg = 5;
                else if (pt >= mxp * 0.6)
                    CharStg = 4;
                else if (pt >= mxp * 0.4)
                    CharStg = 3;
                else if (pt >= mxp * 0.2)
                    CharStg = 2;
                else if (pt >= mxp * 0.1)
                    CharStg = 1;
                else
                    CharStg = 0;
                return CharStg;
            }
            catch(Exception e)
            {
                Console.WriteLine($"error occurred:{e}");
                return 0;
            }
        }

        //キャラクター画像選択
        private void selCharImg(int level)
        {
            try
            {


                switch (level)
                {
                    case 0:
                        CharaImgList = library.getImageList(curdir + "/Images/Characters/Easy/");
                        break;
                    case 1:
                        CharaImgList = library.getImageList(curdir + "/Images/Characters/Normal/");
                        break;
                    case 2:
                        CharaImgList = library.getImageList(curdir + "/Images/Characters/Hard/");
                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("キャラクター画像が読み込めませんでした。Image/Character/内の画像を確認してください。");
                
            }

        }

        //キャラクター画像設定等の関数

        //画像更新
       private void updateChar()
        {
            //2.キャラクターステージの取得
            int char_stg = setCharStage(Pt, Mxp);
            //3.画像・ラベルセット
            try
            {
                switch (char_stg)
                {
                    case 0:
                        PictureBox2.Image = CharaImgList[0];
                        LabelCharName.Text = "みならい";
                        break;
                    case 1:
                        PictureBox2.Image = CharaImgList[1];
                        LabelCharName.Text = "せんし";
                        break;
                    case 2:
                        PictureBox2.Image = CharaImgList[2];
                        LabelCharName.Text = "ベテラン";
                        break;
                    case 3:
                        PictureBox2.Image = CharaImgList[3];
                        LabelCharName.Text = "たつ人";
                        break;
                    case 4:
                        PictureBox2.Image = CharaImgList[4];
                        LabelCharName.Text = "マスター";
                        break;
                    case 5:
                        PictureBox2.Image = CharaImgList[5];
                        LabelCharName.Text = "かみさま";
                        break;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine($"error occurred:{e}");
                return;
            }
        
    }
        //画像初期設定用
        private void setChar(int level)
        {
            //1.画像ファイル選択
            selCharImg(level);
            //2.キャラクターステージの取得
            int char_stg = setCharStage(Pt,Mxp);
            //3.画像・ラベルセット
            try
            {
                switch (char_stg)
                {
                    case 0:
                        PictureBox2.Image = CharaImgList[0];
                        LabelCharName.Text = "みならい";
                        break;
                    case 1:
                        PictureBox2.Image = CharaImgList[1];
                        LabelCharName.Text = "せんし";
                        break;
                    case 2:
                        PictureBox2.Image = CharaImgList[2];
                        LabelCharName.Text = "ベテラン";
                        break;
                    case 3:
                        PictureBox2.Image= CharaImgList[3];
                        LabelCharName.Text = "たつ人";
                        break;
                    case 4:
                        PictureBox2.Image = CharaImgList[4];
                        LabelCharName.Text = "マスター";
                        break;
                    case 5:
                        PictureBox2.Image = CharaImgList[5];
                        LabelCharName.Text = "かみさま";
                        break;
                }        
            
            }
            catch (Exception e)
            {
                Console.WriteLine($"error occurred:{e}");
                return;
            }
        }
        private int setMaxPt()
        {
            int c = ImgList.Count;
            int cnt = TIMER_CNT;
            int mp = c * cnt;
            return mp;
        }
        private int setCnt_Pt_Lv()
        {
            //ポイント、カウントを初期化
            initCNT_PT();
            //難易度レベルを取得
            int lv = getLevel();
            //レベルによるカウント数の分岐
            if (lv == 0) //かんたん　カウント２倍へ
                TIMER_CNT = TIMER_CNT*2;
            else
            LabelTimer.Text = TIMER_CNT.ToString();
            return lv;
        }


        private int getLevel()
        {
            int lv;
                if (radioBtn_Easy.Checked)
                {
                lv = 0;
                }
                else if (radioBtn_Normal.Checked)
                {
                lv = 1;
                }
                else
                {
                lv = 2;
                }

            return lv;
        }

        private bool is_CharImg(int mxcnt)
        {
            if (CharaImgList.Count < mxcnt)
            {
                return false;
            }
            else
                return true;
        }


        private void setViewing(int lv)
        {
            //難易度によるポイント・タイムの表示・非表示
            if (lv == 0)//かんたん
            {
                LabelTimer.Visible = false;
            }
            //キャラクター表示
             if (!LabelCharName.Visible)
            {
                LabelCharName.Visible = true;
            }
            //ボタン・その他表示切り替え
            textBox1.Visible = false;
            BtnStart.Visible = false;
            BtnNextPicture.Visible = true;
            BtnOpenFile.Visible = false;
            BtnReset.Visible = true;
            BtnSkip.Visible = true;
            BtnNextPicture.Text = "せいかい";


            flowLayoutPanel1.Visible = false;//ラジオボタン非表示
            //PictureBox2.Image = null;
        }
        private async void Reset(int spoint,int stimer)
        {
            try
            {
                //全てをリセット
                await Task.Run(() => cts.Cancel());
                await Task.Delay(1000);
                //メモリ解放
                if (PictureBox1.Image != null)
                {
                    PictureBox1.Image.Dispose();
                }
                if (PictureBox2.Image != null)
                {
                    PictureBox2.Image.Dispose();
                }

                initCNT_PT();//タイマー初期化
                StartFlag = false; //スタートボタンフラグをオフにする
                BtnStart.Visible = true;//スタートボタン再表示
                BtnOpenFile.Visible = true;//フォルダ選択再表示
                BtnNextPicture.Visible = false;//画像ボタン非表示
                BtnReset.Visible = false;//リセットボタン非表示
                BtnSkip.Visible = false;//スキップボタン非表示
                flowLayoutPanel1.Visible = true;//ラジオボタン再表示
                LabelTimer.Visible = true;
                textBox1.Visible = true;
                LabelCharName.Visible = false;
                PictureBox2.Image= null;
                LabelTimer.Text = "タイマー";
                LabelPoint.Text = "ポイント";
                BtnStart.Text = "スタート";
                BtnNextPicture.Text = "せいかい";
                return;
            }
            catch(Exception ex)
            {
                Console.WriteLine($"error occurred:{ex}");
            }
        } 
        
        private void Finish()
        {
            try
            {
                //initCNT_PT();//カウンター、ポインター初期化
                cts.Cancel();//キャンセルトークン
                StartFlag = false; //スタートボタンフラグをオフにする
                BtnStart.Visible = true;//スタートボタン再表示
                LabelTimer.Visible = true;//ラベルタイマー再表示
                flowLayoutPanel1.Visible = true;//ラジオボタン再表示
                BtnOpenFile.Visible = true;//フォルダ選択再表示
                BtnNextPicture.Visible = false;//画像ボタン非表示
                BtnReset.Visible = false;//リセットボタン非表示
                BtnSkip.Visible = false;//スキップボタン非表示
                textBox1.Visible = true;//フォルダディレクトリ

                //メモリ解放
                if (PictureBox1.Image != null)
                {
                    PictureBox1.Image.Dispose();
                }
                if (PictureBox2.Image != null)
                {
                    PictureBox2.Image.Dispose();
                }
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"error occured:{ex.Message}");
            }
        }

        
        private bool End(int mode,int CNT = 5,int POINT = 5)// 0=reset,1=finishで切り替え。cnt,pointは初期値設定済み
        {
            try
            {
                switch (mode)
                {
                    case 0://reset
                        Reset(5, 0);
                        Console.WriteLine("reset has been done");
                        return true;
                    case 1://finish
                        Finish();
                        return true;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("error occurred:{0}", ex);
                return false;
            }
            return false;
        }

        //サウンド再生系
        private void PlayShuffleSound(string path)
        {
            string[] mp3 = Directory.GetFiles(path, "*.mp3");
            Random rdm = new Random();
            int rdm_idx = rdm.Next(0, mp3.Length - 1);
            Stopsound(mp3[rdm_idx]);
            Playsound(mp3[rdm_idx]);
        }

        private void initCNT_PT()
        {
            TIMER_CNT = 5;
            Pt = 0;
            LabelPoint.Text = Convert.ToString(Pt);

        }

        private void Stopsound(string path)
        {
            Microsoft.SmallBasic.Library.Sound.Stop(path);
        }

        private void Playsound(string path)
        {
            Microsoft.SmallBasic.Library.Sound.Play(path);
        }

        private bool isLastPic(int idx)
        {
            if (idx > 1)
                return false;
            else
                return true;
        }

    }
}

