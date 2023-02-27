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

namespace MixPictureApp
{
    public partial class RdmPicGame : Form
    {
        //コンソール立ち上げたい時使う
        [System.Runtime.InteropServices.DllImport("kernel32.dll")] // この行を追加
        private static extern bool AllocConsole();                 // この行を追加  

        private CancellationTokenSource cts = null; // キャンセルトークン
        new System.Media.SoundPlayer play;
        /// <summary>
        /// /メンバ変数（インスタンス変数）※静的関数は使えないので注意！(staticなど・・・)
        //初期ディレクトリ
        private string curdir = Environment.CurrentDirectory;
        //定数(初期値)
        private int TIMER_MAX = 5;//タイマー最大秒数
        private int time_remain;//残り秒数表示の変数
        private int HardSpanTime = 700;//難易度が高い時のカウントスパン（短くするほどカウントがはやくなる)
        private int Pt;//取得したポイント
        private int SPT = 0; //ポイント初期値
        private int remain_idx;//表示させるイメージのリストインデックス
        private List<Image> imglist;//画像リスト
        private List<Image> CharaList;//キャラクターリスト
        private bool StartFlag = false;
        private bool LastPicFlag = false;//表示が最後の絵かどうか
        private int LevelFlag;//難易度フラグ(int型 0=easy,1=normal,2=hard)
        private string SOUNDPATH;
        private string SOUND_FINPATH;
        /// </summary>


        //コンストラクタ
        public RdmPicGame()
        {
            InitializeComponent();
            //コンソール起動
            AllocConsole();
            //キャラクター画像読み込み　※正しく設定すること
            CharaList = library.getImageList(curdir + "/Images/Characters");
        }


        private  void BtnStart_Click(object sender, EventArgs e)
        {
            StartFlag = true; //スタートボタンフラグON

            //スタートボタンを押した後の処理
            if (StartFlag == true)
            {
                try
                {
                    //フォルダパスからリスト取得
                    string folderpath = textBox1.Text;
                    LabelTimer.Text = "画像読み込み中・・・";
                    imglist = library.getImageList(folderpath);//画像リスト
                    imglist = library.shuffleImgList(imglist);//それをシャッフル
                                                              //画像がなかった場合
                    if (imglist.Count == 0)//例外処理
                    {
                        MessageBox.Show("読み込むjpg画像ファイルが存在しません", "画像読み込みエラー");
                        StartFlag = false;
                        return;
                    }
                    //音楽フォルダディレクトリ
                    SOUNDPATH = $"{curdir}\\sound\\";
                    SOUND_FINPATH = $"{curdir}\\sound\\final\\";
                }
                catch(Exception)
                {
                    Console.WriteLine("ファイル読み込みエラー");
                    StartFlag = false;
                    return;
                }
                //難易度フラグ取得(かんたん/ふつう/むずかしい)
                getLevel();
                //ボタン・ラベル設定（表示/非表示）
                setBtnView();
                //ラベルに秒数、ポイント表示
                LabelPoint.Text = SPT.ToString();
                LabelTimer.Text = TIMER_MAX.ToString();
                //最初の画像を表示させる。
                try
                {
                    remain_idx = imglist.Count;
                    viewPictillEnd(imglist, remain_idx);
                }
                catch (Exception)
                {
                    Console.WriteLine("画像表示エラー");
                    StartFlag = false;
                    return;
                }

                //タイマー起動
                    //キャンセルトークンの取得(ctsがインスタンス)
                    this.cts = new CancellationTokenSource();
                    CancellationToken token = this.cts.Token;
                try
                {
                    Task.Run(() => countTimer(TIMER_MAX, token));//マルチ処理
                    //戻り値ほしい場合 Task t1 = Task.Factory.StartNew(() => countTimer(TIMER_MAX, token));
                }
                catch (Exception)
                {
                    Console.WriteLine("マルチ処理エラー");
                    ResetBtnFlag(5, 0);
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
            }
            catch (Exception)
            {
                Console.WriteLine("得点計算読み込みエラー");
                ResetBtnFlag(5, 0);
            }
            //4.絵の表示へ
            //絵が全て表示されたら、ここでぬける
                if (LastPicFlag == true)
                {
                    PlayShuffleSound(SOUND_FINPATH);
                    await Task.Run(() => FinishFlag());
                    Thread.Sleep(3000);
                    return;
                }
                else
                {
                    //5キャンセルトークンの再発行(ctsがインスタンス)
                    this.cts = new CancellationTokenSource();
                    CancellationToken token = this.cts.Token;
                    //6キャラクター画像更新
                    changePic_BaseOnPt(Pt);
                    //7.絵の表示
                    viewPictillEnd(imglist, remain_idx);
                    //8.タイマー再起動
                    LabelTimer.Text = TIMER_MAX.ToString();
                    await Task.Delay(500);//タイマー起動を遅らせる
                    await Task.Run(() => countTimer(TIMER_MAX, token));
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
            ResetBtnFlag(0, 5);
        }

        /////////////////メソッド////////////////////
        private void countTimer(int COUNT, CancellationToken token)
        {
            int CountSpanTime = 1000;//いじらない
            if (LevelFlag == 0)//かんたん
            {
                COUNT = 10;
            }
            else if  (LevelFlag == 1) //ふつう
            {
                COUNT = 5;
            }
            else if (LevelFlag == 2)//むずかしい
            {
                COUNT = 5;
                CountSpanTime = HardSpanTime;//スパンを短くする
            }
            for (int n = 1; n <= COUNT; n++)
            {
                if (token.IsCancellationRequested)
                {
                    Console.WriteLine("キャンセルトークンが渡されました");
                    LabelTimer.Text = TIMER_MAX.ToString();
                    return;
                }
                Thread.Sleep(CountSpanTime);
                time_remain = COUNT - n;
                LabelTimer.Text = time_remain.ToString();
            }
        }

        //画像表示
        public void viewPictillEnd(List<Image> list, int remain_idx)
            {
            PictureBox1.Image = null;//リセット
            list.RemoveAt(0);        //前回表示した絵をリストから削除
            try
                {
                PictureBox1.Image = list[0];//次の絵を表示
                }
                catch (Exception e)
                {
                    Console.WriteLine("viewPicTillEndエラー");
                }
         
            remain_idx = list.Count - 1;//表示した絵の数を差し引いておく。
            if (remain_idx == 0)
            {
                LastPicFlag = true;
            }
            return;
        }


        private void changePic_BaseOnPt(int Pt)
        {
            try
            {
                if (Pt > 80)
                    PictureBox2.Image = CharaList[4];
                else if (Pt > 60)
                    PictureBox2.Image = CharaList[3];
                else if (Pt > 40)
                    PictureBox2.Image = CharaList[2];
                else if (Pt > 20)
                    PictureBox2.Image = CharaList[1];
                else if (Pt > 10)
                    PictureBox2.Image = CharaList[0];
                else
                     PictureBox2.Image = null;
            }
            catch (Exception e)
            {
                Console.WriteLine("キャラクター画像読み込みエラーが発生しています。");
                return;
            }
        }
        //リセット

        private void getLevel()
        {
            if (radioBtn_Easy.Checked)
            {
                LevelFlag = 0;
                Console.WriteLine("「かんたん」が選択されています");
            }
            else if (radioBtn_Normal.Checked)
            {
                LevelFlag = 1;
                Console.WriteLine("「ふつう」が選択されています");
            }
            else if (radioBtn_High.Checked) 
            {
                LevelFlag = 2;
                Console.WriteLine("「むずかしい」が選択されています");
            }
        }
        private async void ResetBtnFlag(int spoint,int stimer)
        {
            //全てをリセット
            await Task.Run(() => cts.Cancel());
            await Task.Delay(1000);
            StartFlag = false; //スタートボタンフラグをオフにする
            LastPicFlag = false; //ストップフラグをオフにする
            Pt = spoint; //初期ポイント
            TIMER_MAX = stimer; //タイマー
            BtnStart.Visible = true;//スタートボタン再表示
            BtnOpenFile.Visible = true;//フォルダ選択再表示
            BtnNextPicture.Visible = false;//画像ボタン非表示
            BtnReset.Visible = false;//リセットボタン非表示
            flowLayoutPanel1.Visible = true;//ラジオボタン再表示
            LabelTimer.Visible = true;
            textBox1.Visible = true;
            LabelTimer.Text = "タイマー";
            LabelPoint.Text = "ポイント";
            BtnStart.Text = "スタート";
            PictureBox1.Image = null;
            PictureBox2.Image = null;
            return;
        }

        private void setBtnView()
        {
            //難易度によるポイント・タイムの表示・非表示
            if (LevelFlag == 0)//かんたん
            {
                LabelTimer.Visible = false;
            }
            //ボタン表示切り替え
            textBox1.Visible = false;
            BtnStart.Visible = false;
            BtnNextPicture.Visible = true;
            BtnOpenFile.Visible = false;
            BtnReset.Visible = true;
            flowLayoutPanel1.Visible = false;//ラジオボタン非表示
            PictureBox2.Image = null;
        }
        private void FinishFlag ()
        {
            StartFlag = false; //スタートボタンフラグをオフにする
            LastPicFlag = false; //ストップフラグをオフにする
            BtnStart.Visible = true;//スタートボタン再表示
            LabelTimer.Visible = true;//ラベルタイマー再表示
            flowLayoutPanel1.Visible = true;//ラジオボタン再表示
            BtnOpenFile.Visible = true;//フォルダ選択再表示
            BtnNextPicture.Visible = false;//画像ボタン非表示
            BtnReset.Visible = false;//リセットボタン非表示
            textBox1.Visible = true;//フォルダディレクトリ
            cts.Cancel();//キャンセルトークン
            PictureBox1.Image = null;
            return;
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


        private void Stopsound(string path)
        {
            Microsoft.SmallBasic.Library.Sound.Stop(path);
        }

        private void Playsound(string path)
        {
            Microsoft.SmallBasic.Library.Sound.Play(path);
        }

    }
}

