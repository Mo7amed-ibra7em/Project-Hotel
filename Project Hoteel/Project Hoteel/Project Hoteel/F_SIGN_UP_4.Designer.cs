namespace Project_Hoteel
{
    partial class F_SIGN_UP_4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_SIGN_UP_4));
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.L_4 = new System.Windows.Forms.Label();
            this.b_back_4 = new System.Windows.Forms.Button();
            this.b_sign_up_4 = new System.Windows.Forms.Button();
            this.l_password_4 = new System.Windows.Forms.Label();
            this.l_email_4 = new System.Windows.Forms.Label();
            this.t_password_4 = new System.Windows.Forms.TextBox();
            this.t_email_4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // timer4
            // 
            this.timer4.Enabled = true;
            this.timer4.Interval = 1000;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // L_4
            // 
            this.L_4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.L_4.BackColor = System.Drawing.Color.Transparent;
            this.L_4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.L_4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_4.ForeColor = System.Drawing.Color.DarkRed;
            this.L_4.Location = new System.Drawing.Point(346, 403);
            this.L_4.Name = "L_4";
            this.L_4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.L_4.Size = new System.Drawing.Size(253, 31);
            this.L_4.TabIndex = 12;
            this.L_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // b_back_4
            // 
            this.b_back_4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b_back_4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b_back_4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("b_back_4.BackgroundImage")));
            this.b_back_4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_back_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_back_4.Location = new System.Drawing.Point(896, 12);
            this.b_back_4.Name = "b_back_4";
            this.b_back_4.Size = new System.Drawing.Size(34, 30);
            this.b_back_4.TabIndex = 13;
            this.b_back_4.UseVisualStyleBackColor = false;
            this.b_back_4.Click += new System.EventHandler(this.b_back_4_Click);
            // 
            // b_sign_up_4
            // 
            this.b_sign_up_4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b_sign_up_4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b_sign_up_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_sign_up_4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_sign_up_4.ForeColor = System.Drawing.Color.DarkRed;
            this.b_sign_up_4.Location = new System.Drawing.Point(410, 347);
            this.b_sign_up_4.Name = "b_sign_up_4";
            this.b_sign_up_4.Size = new System.Drawing.Size(120, 39);
            this.b_sign_up_4.TabIndex = 14;
            this.b_sign_up_4.Text = "إشتراك";
            this.b_sign_up_4.UseVisualStyleBackColor = false;
            this.b_sign_up_4.Click += new System.EventHandler(this.b_sign_up_4_Click);
            this.b_sign_up_4.MouseLeave += new System.EventHandler(this.b_sign_up_4_MouseLeave);
            this.b_sign_up_4.MouseHover += new System.EventHandler(this.b_sign_up_4_MouseHover);
            // 
            // l_password_4
            // 
            this.l_password_4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.l_password_4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_password_4.ForeColor = System.Drawing.Color.DarkRed;
            this.l_password_4.Location = new System.Drawing.Point(605, 258);
            this.l_password_4.Name = "l_password_4";
            this.l_password_4.Size = new System.Drawing.Size(122, 28);
            this.l_password_4.TabIndex = 18;
            this.l_password_4.Text = "كلمة المرور";
            this.l_password_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l_email_4
            // 
            this.l_email_4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.l_email_4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_email_4.ForeColor = System.Drawing.Color.DarkRed;
            this.l_email_4.Location = new System.Drawing.Point(605, 208);
            this.l_email_4.Name = "l_email_4";
            this.l_email_4.Size = new System.Drawing.Size(122, 28);
            this.l_email_4.TabIndex = 17;
            this.l_email_4.Text = "البريد الالكتروني";
            this.l_email_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // t_password_4
            // 
            this.t_password_4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.t_password_4.BackColor = System.Drawing.Color.Black;
            this.t_password_4.Font = new System.Drawing.Font("Javanese Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_password_4.ForeColor = System.Drawing.Color.White;
            this.t_password_4.Location = new System.Drawing.Point(346, 258);
            this.t_password_4.Multiline = true;
            this.t_password_4.Name = "t_password_4";
            this.t_password_4.Size = new System.Drawing.Size(255, 40);
            this.t_password_4.TabIndex = 16;
            this.t_password_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.t_password_4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.t_password_4_KeyPress);
            // 
            // t_email_4
            // 
            this.t_email_4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.t_email_4.BackColor = System.Drawing.Color.Black;
            this.t_email_4.Font = new System.Drawing.Font("Javanese Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_email_4.ForeColor = System.Drawing.Color.White;
            this.t_email_4.Location = new System.Drawing.Point(346, 208);
            this.t_email_4.Multiline = true;
            this.t_email_4.Name = "t_email_4";
            this.t_email_4.Size = new System.Drawing.Size(255, 40);
            this.t_email_4.TabIndex = 15;
            this.t_email_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.t_email_4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.t_email_4_KeyPress);
            // 
            // F_SIGN_UP_4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(942, 493);
            this.Controls.Add(this.l_password_4);
            this.Controls.Add(this.l_email_4);
            this.Controls.Add(this.t_password_4);
            this.Controls.Add(this.t_email_4);
            this.Controls.Add(this.b_sign_up_4);
            this.Controls.Add(this.b_back_4);
            this.Controls.Add(this.L_4);
            this.DoubleBuffered = true;
            this.Name = "F_SIGN_UP_4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_SIGN_UP_4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer4;
        public System.Windows.Forms.Label L_4;
        private System.Windows.Forms.Button b_back_4;
        private System.Windows.Forms.Button b_sign_up_4;
        private System.Windows.Forms.Label l_password_4;
        private System.Windows.Forms.Label l_email_4;
        private System.Windows.Forms.TextBox t_password_4;
        private System.Windows.Forms.TextBox t_email_4;
    }
}