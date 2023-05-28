using System;

namespace MixPictureApp
{
    partial class RdmPicGame
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnOpenFile = new System.Windows.Forms.Button();
            this.DialogFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnSkip = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnNextPicture = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LabelPoint = new System.Windows.Forms.Label();
            this.LabelTimer = new System.Windows.Forms.Label();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.radioBtn_Easy = new System.Windows.Forms.RadioButton();
            this.radioBtn_Normal = new System.Windows.Forms.RadioButton();
            this.radioBtn_High = new System.Windows.Forms.RadioButton();
            this.LabelCharName = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPagePic = new System.Windows.Forms.TabPage();
            this.BtnLoad = new System.Windows.Forms.Button();
            this.tabPageWord = new System.Windows.Forms.TabPage();
            this.TextBoxWord = new System.Windows.Forms.TextBox();
            this.PanelGameType = new System.Windows.Forms.Panel();
            this.radioBtn_Word = new System.Windows.Forms.RadioButton();
            this.radioBtn_Picture = new System.Windows.Forms.RadioButton();
            this.BtnPicture = new System.Windows.Forms.Button();
            this.BtnWord = new System.Windows.Forms.Button();
            this.BtnNextWord = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPagePic.SuspendLayout();
            this.tabPageWord.SuspendLayout();
            this.PanelGameType.SuspendLayout();
            this.SuspendLayout();
            // 
            // PictureBox1
            // 
            this.PictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBox1.BackColor = System.Drawing.Color.Linen;
            this.PictureBox1.Location = new System.Drawing.Point(3, 0);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(473, 408);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 0;
            this.PictureBox1.TabStop = false;
            // 
            // BtnOpenFile
            // 
            this.BtnOpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnOpenFile.AutoSize = true;
            this.BtnOpenFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnOpenFile.BackColor = System.Drawing.Color.OldLace;
            this.BtnOpenFile.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnOpenFile.Location = new System.Drawing.Point(226, 121);
            this.BtnOpenFile.Name = "BtnOpenFile";
            this.BtnOpenFile.Size = new System.Drawing.Size(90, 25);
            this.BtnOpenFile.TabIndex = 2;
            this.BtnOpenFile.Text = "フォルダ選択";
            this.BtnOpenFile.UseVisualStyleBackColor = false;
            this.BtnOpenFile.Click += new System.EventHandler(this.BtnOpenFile_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox1.Location = new System.Drawing.Point(9, 58);
            this.textBox1.MaxLength = 5;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(307, 50);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "D:\\\\Program\\\\C#\\\\Image2";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.BtnNextWord);
            this.panel2.Controls.Add(this.PanelGameType);
            this.panel2.Controls.Add(this.BtnPicture);
            this.panel2.Controls.Add(this.BtnLoad);
            this.panel2.Controls.Add(this.BtnWord);
            this.panel2.Controls.Add(this.BtnSkip);
            this.panel2.Controls.Add(this.BtnReset);
            this.panel2.Controls.Add(this.BtnNextPicture);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.BtnOpenFile);
            this.panel2.Location = new System.Drawing.Point(499, 225);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(322, 227);
            this.panel2.TabIndex = 6;
            // 
            // BtnSkip
            // 
            this.BtnSkip.BackColor = System.Drawing.Color.Yellow;
            this.BtnSkip.Font = new System.Drawing.Font("ＭＳ ゴシック", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnSkip.Location = new System.Drawing.Point(99, 114);
            this.BtnSkip.Name = "BtnSkip";
            this.BtnSkip.Size = new System.Drawing.Size(117, 31);
            this.BtnSkip.TabIndex = 9;
            this.BtnSkip.Text = "スキップ";
            this.BtnSkip.UseVisualStyleBackColor = false;
            this.BtnSkip.Visible = false;
            this.BtnSkip.Click += new System.EventHandler(this.BtnSkip_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BtnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReset.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnReset.Location = new System.Drawing.Point(8, 115);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(85, 31);
            this.BtnReset.TabIndex = 10;
            this.BtnReset.Text = "リセット";
            this.BtnReset.UseVisualStyleBackColor = false;
            this.BtnReset.Visible = false;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click_1);
            // 
            // BtnNextPicture
            // 
            this.BtnNextPicture.BackColor = System.Drawing.Color.Coral;
            this.BtnNextPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNextPicture.Font = new System.Drawing.Font("MS UI Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnNextPicture.Location = new System.Drawing.Point(134, 156);
            this.BtnNextPicture.Name = "BtnNextPicture";
            this.BtnNextPicture.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.BtnNextPicture.Size = new System.Drawing.Size(182, 68);
            this.BtnNextPicture.TabIndex = 9;
            this.BtnNextPicture.Text = "せいかい";
            this.BtnNextPicture.UseVisualStyleBackColor = false;
            this.BtnNextPicture.Visible = false;
            this.BtnNextPicture.Click += new System.EventHandler(this.BtnNextPicture_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.LabelPoint, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LabelTimer, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(624, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.67196F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.32804F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(197, 189);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // LabelPoint
            // 
            this.LabelPoint.AccessibleName = "";
            this.LabelPoint.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LabelPoint.AutoSize = true;
            this.LabelPoint.Font = new System.Drawing.Font("MS UI Gothic", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LabelPoint.Location = new System.Drawing.Point(13, 122);
            this.LabelPoint.Name = "LabelPoint";
            this.LabelPoint.Size = new System.Drawing.Size(181, 53);
            this.LabelPoint.TabIndex = 1;
            this.LabelPoint.Text = "ポイント";
            // 
            // LabelTimer
            // 
            this.LabelTimer.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LabelTimer.AutoSize = true;
            this.LabelTimer.Font = new System.Drawing.Font("MS UI Gothic", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LabelTimer.Location = new System.Drawing.Point(13, 28);
            this.LabelTimer.Name = "LabelTimer";
            this.LabelTimer.Size = new System.Drawing.Size(181, 53);
            this.LabelTimer.TabIndex = 0;
            this.LabelTimer.Text = "タイマー";
            // 
            // PictureBox2
            // 
            this.PictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBox2.Location = new System.Drawing.Point(511, 1);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(100, 150);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox2.TabIndex = 2;
            this.PictureBox2.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.radioBtn_Easy);
            this.flowLayoutPanel1.Controls.Add(this.radioBtn_Normal);
            this.flowLayoutPanel1.Controls.Add(this.radioBtn_High);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(538, 200);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(283, 27);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // radioBtn_Easy
            // 
            this.radioBtn_Easy.AutoSize = true;
            this.radioBtn_Easy.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioBtn_Easy.Location = new System.Drawing.Point(3, 3);
            this.radioBtn_Easy.Name = "radioBtn_Easy";
            this.radioBtn_Easy.Size = new System.Drawing.Size(77, 20);
            this.radioBtn_Easy.TabIndex = 0;
            this.radioBtn_Easy.Text = "かんたん";
            this.radioBtn_Easy.UseVisualStyleBackColor = true;
            // 
            // radioBtn_Normal
            // 
            this.radioBtn_Normal.AutoSize = true;
            this.radioBtn_Normal.Checked = true;
            this.radioBtn_Normal.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioBtn_Normal.Location = new System.Drawing.Point(86, 3);
            this.radioBtn_Normal.Name = "radioBtn_Normal";
            this.radioBtn_Normal.Size = new System.Drawing.Size(61, 20);
            this.radioBtn_Normal.TabIndex = 1;
            this.radioBtn_Normal.TabStop = true;
            this.radioBtn_Normal.Text = "ふつう";
            this.radioBtn_Normal.UseVisualStyleBackColor = true;
            // 
            // radioBtn_High
            // 
            this.radioBtn_High.AutoSize = true;
            this.radioBtn_High.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioBtn_High.Location = new System.Drawing.Point(153, 3);
            this.radioBtn_High.Name = "radioBtn_High";
            this.radioBtn_High.Size = new System.Drawing.Size(90, 20);
            this.radioBtn_High.TabIndex = 2;
            this.radioBtn_High.Text = "むずかしい";
            this.radioBtn_High.UseVisualStyleBackColor = true;
            // 
            // LabelCharName
            // 
            this.LabelCharName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelCharName.AutoSize = true;
            this.LabelCharName.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LabelCharName.Location = new System.Drawing.Point(515, 176);
            this.LabelCharName.Name = "LabelCharName";
            this.LabelCharName.Size = new System.Drawing.Size(103, 16);
            this.LabelCharName.TabIndex = 8;
            this.LabelCharName.Text = "キャラクター";
            this.LabelCharName.Visible = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.tabControl);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 1);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(489, 457);
            this.flowLayoutPanel2.TabIndex = 9;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPagePic);
            this.tabControl.Controls.Add(this.tabPageWord);
            this.tabControl.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tabControl.ItemSize = new System.Drawing.Size(100, 35);
            this.tabControl.Location = new System.Drawing.Point(3, 3);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(486, 454);
            this.tabControl.TabIndex = 0;
            // 
            // tabPagePic
            // 
            this.tabPagePic.Controls.Add(this.PictureBox1);
            this.tabPagePic.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tabPagePic.ForeColor = System.Drawing.Color.Red;
            this.tabPagePic.Location = new System.Drawing.Point(4, 39);
            this.tabPagePic.Name = "tabPagePic";
            this.tabPagePic.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePic.Size = new System.Drawing.Size(478, 411);
            this.tabPagePic.TabIndex = 0;
            this.tabPagePic.Text = "ピクチャー";
            this.tabPagePic.UseVisualStyleBackColor = true;
            // 
            // BtnLoad
            // 
            this.BtnLoad.BackColor = System.Drawing.Color.Moccasin;
            this.BtnLoad.Font = new System.Drawing.Font("ＭＳ ゴシック", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnLoad.ForeColor = System.Drawing.Color.Black;
            this.BtnLoad.Location = new System.Drawing.Point(62, 156);
            this.BtnLoad.Name = "BtnLoad";
            this.BtnLoad.Size = new System.Drawing.Size(220, 62);
            this.BtnLoad.TabIndex = 1;
            this.BtnLoad.Text = "よーい！";
            this.BtnLoad.UseVisualStyleBackColor = false;
            this.BtnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // tabPageWord
            // 
            this.tabPageWord.Controls.Add(this.TextBoxWord);
            this.tabPageWord.Font = new System.Drawing.Font("ＭＳ ゴシック", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tabPageWord.ForeColor = System.Drawing.Color.Black;
            this.tabPageWord.Location = new System.Drawing.Point(4, 39);
            this.tabPageWord.Name = "tabPageWord";
            this.tabPageWord.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageWord.Size = new System.Drawing.Size(478, 411);
            this.tabPageWord.TabIndex = 1;
            this.tabPageWord.Text = "ワード";
            this.tabPageWord.UseVisualStyleBackColor = true;
            // 
            // TextBoxWord
            // 
            this.TextBoxWord.Font = new System.Drawing.Font("ＭＳ ゴシック", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TextBoxWord.Location = new System.Drawing.Point(97, 166);
            this.TextBoxWord.Name = "TextBoxWord";
            this.TextBoxWord.Size = new System.Drawing.Size(279, 71);
            this.TextBoxWord.TabIndex = 0;
            // 
            // PanelGameType
            // 
            this.PanelGameType.BackColor = System.Drawing.Color.Goldenrod;
            this.PanelGameType.Controls.Add(this.radioBtn_Word);
            this.PanelGameType.Controls.Add(this.radioBtn_Picture);
            this.PanelGameType.Location = new System.Drawing.Point(73, 21);
            this.PanelGameType.Name = "PanelGameType";
            this.PanelGameType.Size = new System.Drawing.Size(243, 31);
            this.PanelGameType.TabIndex = 11;
            // 
            // radioBtn_Word
            // 
            this.radioBtn_Word.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioBtn_Word.AutoSize = true;
            this.radioBtn_Word.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioBtn_Word.Location = new System.Drawing.Point(136, 6);
            this.radioBtn_Word.Name = "radioBtn_Word";
            this.radioBtn_Word.Size = new System.Drawing.Size(101, 20);
            this.radioBtn_Word.TabIndex = 1;
            this.radioBtn_Word.Text = "ワードゲーム";
            this.radioBtn_Word.UseVisualStyleBackColor = true;
            // 
            // radioBtn_Picture
            // 
            this.radioBtn_Picture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioBtn_Picture.AutoSize = true;
            this.radioBtn_Picture.Checked = true;
            this.radioBtn_Picture.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioBtn_Picture.ForeColor = System.Drawing.Color.Black;
            this.radioBtn_Picture.Location = new System.Drawing.Point(6, 6);
            this.radioBtn_Picture.Name = "radioBtn_Picture";
            this.radioBtn_Picture.Size = new System.Drawing.Size(124, 20);
            this.radioBtn_Picture.TabIndex = 0;
            this.radioBtn_Picture.TabStop = true;
            this.radioBtn_Picture.Text = "ピクチャーゲーム";
            this.radioBtn_Picture.UseVisualStyleBackColor = true;
            // 
            // BtnPicture
            // 
            this.BtnPicture.BackColor = System.Drawing.Color.Gold;
            this.BtnPicture.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnPicture.ForeColor = System.Drawing.Color.Black;
            this.BtnPicture.Location = new System.Drawing.Point(19, 165);
            this.BtnPicture.Name = "BtnPicture";
            this.BtnPicture.Size = new System.Drawing.Size(251, 55);
            this.BtnPicture.TabIndex = 12;
            this.BtnPicture.Text = "スタート！";
            this.BtnPicture.UseVisualStyleBackColor = false;
            this.BtnPicture.Visible = false;
            this.BtnPicture.Click += new System.EventHandler(this.BtnPicture_Click);
            // 
            // BtnWord
            // 
            this.BtnWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnWord.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnWord.ForeColor = System.Drawing.Color.Black;
            this.BtnWord.Location = new System.Drawing.Point(39, 163);
            this.BtnWord.Name = "BtnWord";
            this.BtnWord.Size = new System.Drawing.Size(264, 55);
            this.BtnWord.TabIndex = 13;
            this.BtnWord.Text = "スタート";
            this.BtnWord.UseVisualStyleBackColor = false;
            this.BtnWord.Visible = false;
            this.BtnWord.Click += new System.EventHandler(this.BtnWord_Click);
            // 
            // BtnNextWord
            // 
            this.BtnNextWord.BackColor = System.Drawing.Color.Coral;
            this.BtnNextWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNextWord.Font = new System.Drawing.Font("MS UI Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnNextWord.Location = new System.Drawing.Point(134, 156);
            this.BtnNextWord.Name = "BtnNextWord";
            this.BtnNextWord.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.BtnNextWord.Size = new System.Drawing.Size(182, 68);
            this.BtnNextWord.TabIndex = 10;
            this.BtnNextWord.Text = "せいかい";
            this.BtnNextWord.UseVisualStyleBackColor = false;
            this.BtnNextWord.Visible = false;
            this.BtnNextWord.Click += new System.EventHandler(this.BtnNextWord_Click);
            // 
            // RdmPicGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(818, 455);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.LabelCharName);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PictureBox2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "RdmPicGame";
            this.Text = "ピクチャーゲーム";
            this.Load += new System.EventHandler(this.BtnTimer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPagePic.ResumeLayout(false);
            this.tabPageWord.ResumeLayout(false);
            this.tabPageWord.PerformLayout();
            this.PanelGameType.ResumeLayout(false);
            this.PanelGameType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.Button BtnOpenFile;
        private System.Windows.Forms.FolderBrowserDialog DialogFolder;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button BtnNextPicture;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.PictureBox PictureBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton radioBtn_Easy;
        private System.Windows.Forms.RadioButton radioBtn_Normal;
        private System.Windows.Forms.RadioButton radioBtn_High;
        private System.Windows.Forms.Label LabelPoint;
        private System.Windows.Forms.Label LabelTimer;
        private System.Windows.Forms.Label LabelCharName;
        private System.Windows.Forms.Button BtnSkip;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPagePic;
        private System.Windows.Forms.TabPage tabPageWord;
        private System.Windows.Forms.TextBox TextBoxWord;
        private System.Windows.Forms.Button BtnLoad;
        private System.Windows.Forms.Panel PanelGameType;
        private System.Windows.Forms.RadioButton radioBtn_Word;
        private System.Windows.Forms.RadioButton radioBtn_Picture;
        private System.Windows.Forms.Button BtnPicture;
        private System.Windows.Forms.Button BtnWord;
        private System.Windows.Forms.Button BtnNextWord;
    }
}

