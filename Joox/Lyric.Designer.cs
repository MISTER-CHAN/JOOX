namespace Joox
{
    partial class Lyric
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblLyric = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLyric
            // 
            this.lblLyric.BackColor = System.Drawing.Color.Transparent;
            this.lblLyric.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLyric.Font = new System.Drawing.Font("MISTER_CHAN", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLyric.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(222)))), ((int)(((byte)(110)))));
            this.lblLyric.Location = new System.Drawing.Point(0, 0);
            this.lblLyric.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLyric.Name = "lblLyric";
            this.lblLyric.Size = new System.Drawing.Size(1067, 83);
            this.lblLyric.TabIndex = 0;
            this.lblLyric.Text = "暫時未有歌詞";
            this.lblLyric.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lyric
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(223)))), ((int)(((byte)(111)))));
            this.ClientSize = new System.Drawing.Size(1067, 83);
            this.Controls.Add(this.lblLyric);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Lyric";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "點此顯示歌詞";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(223)))), ((int)(((byte)(111)))));
            this.Load += new System.EventHandler(this.Lyric_Load);
            this.Resize += new System.EventHandler(this.Lyric_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lblLyric;
    }
}