namespace Project_Hoteel
{
    partial class F_LOGIN_SIGNUP_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_LOGIN_SIGNUP_2));
            this.b_login_2 = new System.Windows.Forms.Button();
            this.b_signup_2 = new System.Windows.Forms.Button();
            this.t_email_2 = new System.Windows.Forms.TextBox();
            this.t_password_2 = new System.Windows.Forms.TextBox();
            this.l_email_4 = new System.Windows.Forms.Label();
            this.l_password_4 = new System.Windows.Forms.Label();
            this.L_2 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // b_login_2
            // 
            this.b_login_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b_login_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_login_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_login_2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_login_2.ForeColor = System.Drawing.Color.DarkRed;
            this.b_login_2.Location = new System.Drawing.Point(410, 347);
            this.b_login_2.Name = "b_login_2";
            this.b_login_2.Size = new System.Drawing.Size(120, 39);
            this.b_login_2.TabIndex = 0;
            this.b_login_2.Text = "تسجيل الدخول";
            this.b_login_2.UseVisualStyleBackColor = true;
            this.b_login_2.Click += new System.EventHandler(this.b_login_2_Click);
            this.b_login_2.MouseLeave += new System.EventHandler(this.b_login_2_MouseLeave);
            this.b_login_2.MouseHover += new System.EventHandler(this.b_login_2_MouseHover);
            // 
            // b_signup_2
            // 
            this.b_signup_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b_signup_2.BackColor = System.Drawing.Color.Black;
            this.b_signup_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_signup_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_signup_2.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_signup_2.ForeColor = System.Drawing.Color.White;
            this.b_signup_2.Location = new System.Drawing.Point(424, 450);
            this.b_signup_2.Name = "b_signup_2";
            this.b_signup_2.Size = new System.Drawing.Size(90, 28);
            this.b_signup_2.TabIndex = 1;
            this.b_signup_2.Text = "إشتراك";
            this.b_signup_2.UseVisualStyleBackColor = false;
            this.b_signup_2.Click += new System.EventHandler(this.b_signup_2_Click_1);
            // 
            // t_email_2
            // 
            this.t_email_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.t_email_2.BackColor = System.Drawing.Color.Black;
            this.t_email_2.Font = new System.Drawing.Font("Javanese Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_email_2.ForeColor = System.Drawing.Color.White;
            this.t_email_2.Location = new System.Drawing.Point(346, 208);
            this.t_email_2.Multiline = true;
            this.t_email_2.Name = "t_email_2";
            this.t_email_2.Size = new System.Drawing.Size(255, 40);
            this.t_email_2.TabIndex = 2;
            this.t_email_2.Text = "Mohamed-ibrahem";
            this.t_email_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // t_password_2
            // 
            this.t_password_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.t_password_2.BackColor = System.Drawing.Color.Black;
            this.t_password_2.Font = new System.Drawing.Font("Javanese Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_password_2.ForeColor = System.Drawing.Color.White;
            this.t_password_2.Location = new System.Drawing.Point(346, 258);
            this.t_password_2.Multiline = true;
            this.t_password_2.Name = "t_password_2";
            this.t_password_2.PasswordChar = '*';
            this.t_password_2.Size = new System.Drawing.Size(255, 40);
            this.t_password_2.TabIndex = 3;
            this.t_password_2.Text = "123456789";
            this.t_password_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.t_password_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.t_password_2_KeyPress);
            // 
            // l_email_4
            // 
            this.l_email_4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.l_email_4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_email_4.ForeColor = System.Drawing.Color.DarkRed;
            this.l_email_4.Location = new System.Drawing.Point(605, 208);
            this.l_email_4.Name = "l_email_4";
            this.l_email_4.Size = new System.Drawing.Size(122, 28);
            this.l_email_4.TabIndex = 4;
            this.l_email_4.Text = "البريد الالكتروني";
            this.l_email_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l_password_4
            // 
            this.l_password_4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.l_password_4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_password_4.ForeColor = System.Drawing.Color.DarkRed;
            this.l_password_4.Location = new System.Drawing.Point(605, 258);
            this.l_password_4.Name = "l_password_4";
            this.l_password_4.Size = new System.Drawing.Size(122, 28);
            this.l_password_4.TabIndex = 5;
            this.l_password_4.Text = "كلمة المرور";
            this.l_password_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // L_2
            // 
            this.L_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.L_2.BackColor = System.Drawing.Color.Transparent;
            this.L_2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.L_2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_2.ForeColor = System.Drawing.Color.DarkRed;
            this.L_2.Location = new System.Drawing.Point(344, 392);
            this.L_2.Name = "L_2";
            this.L_2.Size = new System.Drawing.Size(253, 31);
            this.L_2.TabIndex = 13;
            this.L_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // F_LOGIN_SIGNUP_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(942, 493);
            this.Controls.Add(this.L_2);
            this.Controls.Add(this.l_password_4);
            this.Controls.Add(this.l_email_4);
            this.Controls.Add(this.t_password_2);
            this.Controls.Add(this.t_email_2);
            this.Controls.Add(this.b_signup_2);
            this.Controls.Add(this.b_login_2);
            this.DoubleBuffered = true;
            this.Name = "F_LOGIN_SIGNUP_2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_LOGIN_SIGNUP_2";
            this.Load += new System.EventHandler(this.F_LOGIN_LOGUP_2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_login_2;
        private System.Windows.Forms.Button b_signup_2;
        private System.Windows.Forms.TextBox t_email_2;
        private System.Windows.Forms.TextBox t_password_2;
        private System.Windows.Forms.Label l_email_4;
        private System.Windows.Forms.Label l_password_4;
        private System.Windows.Forms.Label L_2;
        public System.Windows.Forms.Timer timer2;
    }
}