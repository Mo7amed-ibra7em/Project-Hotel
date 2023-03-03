namespace Project_Hoteel
{
    partial class F_CHANGE_PASSWORD_9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_CHANGE_PASSWORD_9));
            this.t_password_old_9 = new System.Windows.Forms.TextBox();
            this.t_password_new_9 = new System.Windows.Forms.TextBox();
            this.l_old_9 = new System.Windows.Forms.Label();
            this.l_new_9 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.t_user_old_9 = new System.Windows.Forms.TextBox();
            this.picture_cancel_12 = new System.Windows.Forms.PictureBox();
            this.l_username_9 = new System.Windows.Forms.Label();
            this.b_change_password_9 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.L_9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture_cancel_12)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // t_password_old_9
            // 
            this.t_password_old_9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.t_password_old_9.BackColor = System.Drawing.Color.White;
            this.t_password_old_9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.t_password_old_9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.t_password_old_9.ForeColor = System.Drawing.Color.Black;
            this.t_password_old_9.Location = new System.Drawing.Point(23, 63);
            this.t_password_old_9.Multiline = true;
            this.t_password_old_9.Name = "t_password_old_9";
            this.t_password_old_9.Size = new System.Drawing.Size(232, 30);
            this.t_password_old_9.TabIndex = 3;
            this.t_password_old_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.t_password_old_9.TextChanged += new System.EventHandler(this.t_password_old_9_TextChanged);
            this.t_password_old_9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.t_password_old_9_KeyPress);
            // 
            // t_password_new_9
            // 
            this.t_password_new_9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.t_password_new_9.BackColor = System.Drawing.Color.White;
            this.t_password_new_9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.t_password_new_9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.t_password_new_9.ForeColor = System.Drawing.Color.Black;
            this.t_password_new_9.Location = new System.Drawing.Point(23, 116);
            this.t_password_new_9.Multiline = true;
            this.t_password_new_9.Name = "t_password_new_9";
            this.t_password_new_9.PasswordChar = '*';
            this.t_password_new_9.Size = new System.Drawing.Size(232, 30);
            this.t_password_new_9.TabIndex = 4;
            this.t_password_new_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.t_password_new_9.TextChanged += new System.EventHandler(this.t_password_new_9_TextChanged);
            this.t_password_new_9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.t_password_new_9_KeyPress);
            // 
            // l_old_9
            // 
            this.l_old_9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.l_old_9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.l_old_9.Font = new System.Drawing.Font("PT Simple Bold Ruled", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.l_old_9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.l_old_9.Location = new System.Drawing.Point(261, 59);
            this.l_old_9.Name = "l_old_9";
            this.l_old_9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.l_old_9.Size = new System.Drawing.Size(107, 32);
            this.l_old_9.TabIndex = 27;
            this.l_old_9.Text = "كلمة المرور الحالية :";
            this.l_old_9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.l_old_9.Click += new System.EventHandler(this.l_old_9_Click);
            // 
            // l_new_9
            // 
            this.l_new_9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.l_new_9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.l_new_9.Font = new System.Drawing.Font("PT Simple Bold Ruled", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.l_new_9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.l_new_9.Location = new System.Drawing.Point(261, 113);
            this.l_new_9.Name = "l_new_9";
            this.l_new_9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.l_new_9.Size = new System.Drawing.Size(107, 32);
            this.l_new_9.TabIndex = 28;
            this.l_new_9.Text = "كلمة المرور الجديدة :";
            this.l_new_9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.l_new_9.Click += new System.EventHandler(this.l_new_9_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // t_user_old_9
            // 
            this.t_user_old_9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.t_user_old_9.BackColor = System.Drawing.Color.White;
            this.t_user_old_9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.t_user_old_9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.t_user_old_9.ForeColor = System.Drawing.Color.Black;
            this.t_user_old_9.Location = new System.Drawing.Point(23, 23);
            this.t_user_old_9.Multiline = true;
            this.t_user_old_9.Name = "t_user_old_9";
            this.t_user_old_9.Size = new System.Drawing.Size(232, 30);
            this.t_user_old_9.TabIndex = 31;
            this.t_user_old_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // picture_cancel_12
            // 
            this.picture_cancel_12.BackgroundImage = global::Project_Hoteel.Properties.Resources.cancel_2x;
            this.picture_cancel_12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picture_cancel_12.Location = new System.Drawing.Point(358, 2);
            this.picture_cancel_12.Name = "picture_cancel_12";
            this.picture_cancel_12.Size = new System.Drawing.Size(28, 25);
            this.picture_cancel_12.TabIndex = 30;
            this.picture_cancel_12.TabStop = false;
            this.picture_cancel_12.Click += new System.EventHandler(this.picture_cancel_12_Click);
            this.picture_cancel_12.MouseLeave += new System.EventHandler(this.picture_cancel_12_MouseLeave);
            this.picture_cancel_12.MouseHover += new System.EventHandler(this.picture_cancel_12_MouseHover);
            // 
            // l_username_9
            // 
            this.l_username_9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.l_username_9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.l_username_9.Font = new System.Drawing.Font("PT Simple Bold Ruled", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.l_username_9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.l_username_9.Location = new System.Drawing.Point(261, 19);
            this.l_username_9.Name = "l_username_9";
            this.l_username_9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.l_username_9.Size = new System.Drawing.Size(107, 32);
            this.l_username_9.TabIndex = 32;
            this.l_username_9.Text = "اسم المستخدم :";
            this.l_username_9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // b_change_password_9
            // 
            this.b_change_password_9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b_change_password_9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.b_change_password_9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_change_password_9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.b_change_password_9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_change_password_9.Font = new System.Drawing.Font("PT Bold Broken", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.b_change_password_9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.b_change_password_9.Image = global::Project_Hoteel.Properties.Resources.reset_password__1_;
            this.b_change_password_9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_change_password_9.Location = new System.Drawing.Point(136, 182);
            this.b_change_password_9.MinimumSize = new System.Drawing.Size(100, 32);
            this.b_change_password_9.Name = "b_change_password_9";
            this.b_change_password_9.Size = new System.Drawing.Size(117, 32);
            this.b_change_password_9.TabIndex = 0;
            this.b_change_password_9.Text = "تغيير";
            this.b_change_password_9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.b_change_password_9.UseVisualStyleBackColor = false;
            this.b_change_password_9.Click += new System.EventHandler(this.b_change_password_9_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.L_9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 228);
            this.panel1.TabIndex = 33;
            // 
            // L_9
            // 
            this.L_9.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.L_9.Location = new System.Drawing.Point(21, 147);
            this.L_9.Name = "L_9";
            this.L_9.Size = new System.Drawing.Size(341, 31);
            this.L_9.TabIndex = 0;
            this.L_9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // F_CHANGE_PASSWORD_9
            // 
            this.AcceptButton = this.b_change_password_9;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(388, 228);
            this.Controls.Add(this.t_user_old_9);
            this.Controls.Add(this.l_new_9);
            this.Controls.Add(this.l_old_9);
            this.Controls.Add(this.picture_cancel_12);
            this.Controls.Add(this.l_username_9);
            this.Controls.Add(this.t_password_new_9);
            this.Controls.Add(this.t_password_old_9);
            this.Controls.Add(this.b_change_password_9);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F_CHANGE_PASSWORD_9";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_CHANGE_PASSWORD_9";
            this.Load += new System.EventHandler(this.F_CHANGE_PASSWORD_9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture_cancel_12)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox t_password_old_9;
        private System.Windows.Forms.TextBox t_password_new_9;
        private System.Windows.Forms.Button b_change_password_9;
        public System.Windows.Forms.Label l_old_9;
        public System.Windows.Forms.Label l_new_9;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picture_cancel_12;
        private System.Windows.Forms.TextBox t_user_old_9;
        public System.Windows.Forms.Label l_username_9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label L_9;
    }
}