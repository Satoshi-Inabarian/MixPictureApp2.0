using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MixPictureApp
{
    internal class Library
    {
        //メソッド
        public static List<String> GetAllFiles(String DirPath)
        {
            List<String> lstStr = new List<String>();    // 取得したファイル名を格納するためのリスト
            String[] strBuff;   // ファイル名とディレクトリ名取得用

            try
            {
                // 取得したいファイル
                strBuff = Directory.GetFiles(DirPath, "*.jpg");        // 探索範囲がルートフォルダで時間が掛かるため、テキスト形式のファイルのみ探索
                foreach (String file in strBuff)
                {
                    lstStr.Add(file);
                }

                // ディレクトリ名の取得
                strBuff = Directory.GetDirectories(DirPath);
                foreach (String directory in strBuff)
                {
                    List<String> lstBuff = GetAllFiles(directory);    // 取得したディレクトリ名を引数にして再帰
                    lstBuff.ForEach(delegate (String str)
                    {
                        lstStr.Add(str);
                    });
                }
            }
            catch (Exception e)
            {
                // 主に発生する例外は、システムフォルダ等で発生するアクセス拒否
                //        例外名：System.UnauthorizedAccessException
                string msg = Convert.ToString(e);
                MessageBox.Show(msg);
            }

            // 取得したファイル名リストを呼び出し元に返す
            return lstStr;

        }

    }
}
