namespace remote
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbox_ip = new System.Windows.Forms.TextBox();
            this.tbox_controller_ip = new System.Windows.Forms.TextBox();
            this.btn_setting = new System.Windows.Forms.Button();
            this.timer_send_image = new System.Windows.Forms.Timer(this.components);
            this.noti = new System.Windows.Forms.NotifyIcon(this.components);
            this.btn_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "원격 호스트 주소 : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "원격 컨트롤러 주소 : ";
            // 
            // tbox_ip
            // 
            this.tbox_ip.Location = new System.Drawing.Point(425, 98);
            this.tbox_ip.Name = "tbox_ip";
            this.tbox_ip.Size = new System.Drawing.Size(418, 42);
            this.tbox_ip.TabIndex = 2;
            this.tbox_ip.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbox_controller_ip
            // 
            this.tbox_controller_ip.Location = new System.Drawing.Point(425, 189);
            this.tbox_controller_ip.Name = "tbox_controller_ip";
            this.tbox_controller_ip.ReadOnly = true;
            this.tbox_controller_ip.Size = new System.Drawing.Size(418, 42);
            this.tbox_controller_ip.TabIndex = 3;
            // 
            // btn_setting
            // 
            this.btn_setting.AutoEllipsis = true;
            this.btn_setting.Location = new System.Drawing.Point(900, 87);
            this.btn_setting.Name = "btn_setting";
            this.btn_setting.Size = new System.Drawing.Size(282, 58);
            this.btn_setting.TabIndex = 4;
            this.btn_setting.Text = "설정하기";
            this.btn_setting.Click += new System.EventHandler(this.btn_setting_Click);
            this.btn_setting.UseVisualStyleBackColor = true;
            // 
            // noti
            // 
            this.noti.Text = "notifyIcon1";
            this.noti.Visible = true;
            // 
            // btn_ok
            // 
            this.btn_ok.Enabled = false;
            this.btn_ok.Location = new System.Drawing.Point(900, 183);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(282, 58);
            this.btn_ok.TabIndex = 5;
            this.btn_ok.Text = "원격 제어 허용";
            this.btn_ok.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 412);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_setting);
            this.Controls.Add(this.tbox_controller_ip);
            this.Controls.Add(this.tbox_ip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbox_ip;
        private System.Windows.Forms.TextBox tbox_controller_ip;
        private System.Windows.Forms.Button btn_setting;
        private System.Windows.Forms.Timer timer_send_image;
        private System.Windows.Forms.NotifyIcon noti;
        private System.Windows.Forms.Button btn_ok;
    }
}

