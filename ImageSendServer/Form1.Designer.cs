namespace ImageSendServer
{
    partial class Form1
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
            this.lbox_fno = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbox_km = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbox_fno
            // 
            this.lbox_fno.FormattingEnabled = true;
            this.lbox_fno.ItemHeight = 18;
            this.lbox_fno.Location = new System.Drawing.Point(22, 26);
            this.lbox_fno.Margin = new System.Windows.Forms.Padding(2);
            this.lbox_fno.Name = "lbox_fno";
            this.lbox_fno.Size = new System.Drawing.Size(203, 346);
            this.lbox_fno.TabIndex = 0;
            this.lbox_fno.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(272, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(494, 346);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // lbox_km
            // 
            this.lbox_km.FormattingEnabled = true;
            this.lbox_km.ItemHeight = 18;
            this.lbox_km.Location = new System.Drawing.Point(30, 434);
            this.lbox_km.Name = "lbox_km";
            this.lbox_km.Size = new System.Drawing.Size(735, 436);
            this.lbox_km.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 911);
            this.Controls.Add(this.lbox_km);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbox_fno);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "이미지 키보드 마우스 수신 서버";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbox_fno;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox lbox_km;
    }
}

