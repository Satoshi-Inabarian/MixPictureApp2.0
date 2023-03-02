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
            this.panel1 = new System.Windows.Forms.Panel();
            this.DialogFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnNextPicture = new System.Windows.Forms.Button();
            this.BtnStart = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LabelPoint = new System.Windows.Forms.Label();
            this.LabelTimer = new System.Windows.Forms.Label();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.radioBtn_Easy = new System.Windows.Forms.RadioButton();
            this.radioBtn_Normal = new System.Windows.Forms.RadioButton();
            this.radioBtn_High = new System.Windows.Forms.RadioButton();
            this.LabelCharName = new System.Windows.Forms.Label();
            this.BtnSkip = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PictureBox1
            // 
            this.PictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBox1.BackColor = System.Drawing.Color.Linen;
            this.PictureBox1.Location = new System.Drawing.Point(-1, 3);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(486, 449);
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
            this.BtnOpenFile.Location = new System.Drawing.Point(216, 56);
            this.BtnOpenFile.Name = "BtnOpenFile";
            this.BtnOpenFile.Size = new System.Drawing.Size(90, 25);
            this.BtnOpenFile.TabIndex = 2;
            this.BtnOpenFile.Text = "フォルダ選択";
            this.BtnOpenFile.UseVisualStyleBackColor = false;
            this.BtnOpenFile.Click += new System.EventHandler(this.BtnOpenFile_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.PictureBox1);
            this.panel1.Location = new System.Drawing.Point(2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 452);
            this.panel1.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox1.Location = new System.Drawing.Point(33, 7);
            this.textBox1.MaxLength = 5;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(274, 47);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "D:\\\\Program\\\\C#\\\\Image2";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.BtnSkip);
            this.panel2.Controls.Add(this.BtnReset);
            this.panel2.Controls.Add(this.BtnNextPicture);
            this.panel2.Controls.Add(this.BtnStart);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.BtnOpenFile);
            this.panel2.Location = new System.Drawing.Point(493, 228);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(310, 219);
            this.panel2.TabIndex = 6;
            // 
            // BtnReset
            // 
            this.BtnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BtnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReset.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnReset.Location = new System.Drawing.Point(27, 86);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(100, 38);
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
            this.BtnNextPicture.Location = new System.Drawing.Point(18, 130);
            this.BtnNextPicture.Name = "BtnNextPicture";
            this.BtnNextPicture.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.BtnNextPicture.Size = new System.Drawing.Size(182, 80);
            this.BtnNextPicture.TabIndex = 9;
            this.BtnNextPicture.Text = "せいかい";
            this.BtnNextPicture.UseVisualStyleBackColor = false;
            this.BtnNextPicture.Visible = false;
            this.BtnNextPicture.Click += new System.EventHandler(this.BtnNextPicture_Click);
            // 
            // BtnStart
            // 
            this.BtnStart.BackColor = System.Drawing.Color.Gold;
            this.BtnStart.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnStart.ForeColor = System.Drawing.Color.Black;
            this.BtnStart.Location = new System.Drawing.Point(133, 147);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(143, 55);
            this.BtnStart.TabIndex = 7;
            this.BtnStart.Text = "スタート";
            this.BtnStart.UseVisualStyleBackColor = false;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.LabelPoint, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LabelTimer, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(606, 3);
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
            this.PictureBox2.Location = new System.Drawing.Point(500, 3);
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
            this.flowLayoutPanel1.Location = new System.Drawing.Point(520, 195);
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
            this.LabelCharName.AutoSize = true;
            this.LabelCharName.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LabelCharName.Location = new System.Drawing.Point(497, 162);
            this.LabelCharName.Name = "LabelCharName";
            this.LabelCharName.Size = new System.Drawing.Size(103, 16);
            this.LabelCharName.TabIndex = 8;
            this.LabelCharName.Text = "キャラクター";
            this.LabelCharName.Visible = false;
            // 
            // BtnSkip
            // 
            this.BtnSkip.BackColor = System.Drawing.Color.Yellow;
            this.BtnSkip.Font = new System.Drawing.Font("ＭＳ ゴシック", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnSkip.Location = new System.Drawing.Point(133, 85);
            this.BtnSkip.Name = "BtnSkip";
            this.BtnSkip.Size = new System.Drawing.Size(143, 39);
            this.BtnSkip.TabIndex = 9;
            this.BtnSkip.Text = "スキップ";
            this.BtnSkip.UseVisualStyleBackColor = false;
            this.BtnSkip.Visible = false;
            this.BtnSkip.Click += new System.EventHandler(this.BtnSkip_Click);
            // 
            // RdmPicGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LabelCharName);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PictureBox2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "RdmPicGame";
            this.Text = "ピクチャーゲーム";
            this.Load += new System.EventHandler(this.BtnTimer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.Button BtnOpenFile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FolderBrowserDialog DialogFolder;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnStart;
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
    }
}

