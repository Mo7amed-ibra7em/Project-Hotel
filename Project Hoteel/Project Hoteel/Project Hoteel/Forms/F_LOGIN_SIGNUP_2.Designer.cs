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
            Guna.UI2.AnimatorNS.Animation animation2 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_LOGIN_SIGNUP_2));
            this.timer_progress_2 = new System.Windows.Forms.Timer(this.components);
            this.t_password_2 = new System.Windows.Forms.TextBox();
            this.l_notificatio_2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.l_progress_2 = new System.Windows.Forms.Label();
            this.ProgressBar_2 = new CircularProgressBar.CircularProgressBar();
            this.l_username_2 = new System.Windows.Forms.Label();
            this.t_email_2 = new System.Windows.Forms.TextBox();
            this.b_login_2 = new Guna.UI2.WinForms.Guna2Button();
            this.picture_cancel_12 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Transition_form_2 = new Guna.UI2.WinForms.Guna2Transition();
            ((System.ComponentModel.ISupportInitialize)(this.picture_cancel_12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // timer_progress_2
            // 
            this.timer_progress_2.Interval = 2;
            this.timer_progress_2.Tick += new System.EventHandler(this.timer_progress_2_Tick);
            // 
            // t_password_2
            // 
            this.t_password_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.t_password_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.t_password_2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Transition_form_2.SetDecoration(this.t_password_2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.t_password_2.Font = new System.Drawing.Font("Sitka Heading", 10.2F, System.Drawing.FontStyle.Bold);
            this.t_password_2.ForeColor = System.Drawing.Color.LightGray;
            this.t_password_2.Location = new System.Drawing.Point(85, 217);
            this.t_password_2.Multiline = true;
            this.t_password_2.Name = "t_password_2";
            this.t_password_2.Size = new System.Drawing.Size(263, 35);
            this.t_password_2.TabIndex = 1;
            this.t_password_2.Text = "Password";
            this.t_password_2.WordWrap = false;
            this.t_password_2.Click += new System.EventHandler(this.t_password_2_Click);
            this.t_password_2.TextChanged += new System.EventHandler(this.t_password_2_TextChanged);
            this.t_password_2.Leave += new System.EventHandler(this.t_password_2_Leave);
            // 
            // l_notificatio_2
            // 
            this.l_notificatio_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.l_notificatio_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.Transition_form_2.SetDecoration(this.l_notificatio_2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.l_notificatio_2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.l_notificatio_2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.l_notificatio_2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.l_notificatio_2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.l_notificatio_2.Location = new System.Drawing.Point(71, 277);
            this.l_notificatio_2.Name = "l_notificatio_2";
            this.l_notificatio_2.Size = new System.Drawing.Size(255, 31);
            this.l_notificatio_2.TabIndex = 19;
            this.l_notificatio_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.l_notificatio_2.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.Transition_form_2.SetDecoration(this.panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(48, 254);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 1);
            this.panel1.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.Transition_form_2.SetDecoration(this.panel2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel2.Location = new System.Drawing.Point(48, 174);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 1);
            this.panel2.TabIndex = 23;
            // 
            // l_progress_2
            // 
            this.l_progress_2.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Transition_form_2.SetDecoration(this.l_progress_2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.l_progress_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.l_progress_2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.l_progress_2.ForeColor = System.Drawing.Color.Plum;
            this.l_progress_2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.l_progress_2.Location = new System.Drawing.Point(164, 445);
            this.l_progress_2.Name = "l_progress_2";
            this.l_progress_2.Size = new System.Drawing.Size(71, 31);
            this.l_progress_2.TabIndex = 28;
            this.l_progress_2.Text = "1 %";
            this.l_progress_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProgressBar_2
            // 
            this.ProgressBar_2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ProgressBar_2.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.CircularEaseInOut;
            this.ProgressBar_2.AnimationSpeed = 5000;
            this.ProgressBar_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.ProgressBar_2.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Transition_form_2.SetDecoration(this.ProgressBar_2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.ProgressBar_2.Font = new System.Drawing.Font("Lucida Fax", 24F);
            this.ProgressBar_2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.ProgressBar_2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ProgressBar_2.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.ProgressBar_2.InnerMargin = 2;
            this.ProgressBar_2.InnerWidth = -1;
            this.ProgressBar_2.Location = new System.Drawing.Point(123, 385);
            this.ProgressBar_2.MarqueeAnimationSpeed = 2000;
            this.ProgressBar_2.Maximum = 500;
            this.ProgressBar_2.Name = "ProgressBar_2";
            this.ProgressBar_2.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.ProgressBar_2.OuterMargin = -25;
            this.ProgressBar_2.OuterWidth = 26;
            this.ProgressBar_2.ProgressColor = System.Drawing.Color.CornflowerBlue;
            this.ProgressBar_2.ProgressWidth = 5;
            this.ProgressBar_2.SecondaryFont = new System.Drawing.Font("Monotype Corsiva", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgressBar_2.Size = new System.Drawing.Size(150, 150);
            this.ProgressBar_2.StartAngle = 270;
            this.ProgressBar_2.Step = 3;
            this.ProgressBar_2.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.ProgressBar_2.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.ProgressBar_2.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.ProgressBar_2.SubscriptText = "";
            this.ProgressBar_2.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.ProgressBar_2.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.ProgressBar_2.SuperscriptText = "";
            this.ProgressBar_2.TabIndex = 27;
            this.ProgressBar_2.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.ProgressBar_2.Value = 5;
            // 
            // l_username_2
            // 
            this.l_username_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.l_username_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.Transition_form_2.SetDecoration(this.l_username_2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.l_username_2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.l_username_2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.l_username_2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.l_username_2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.l_username_2.Location = new System.Drawing.Point(71, 88);
            this.l_username_2.Name = "l_username_2";
            this.l_username_2.Size = new System.Drawing.Size(255, 31);
            this.l_username_2.TabIndex = 29;
            this.l_username_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // t_email_2
            // 
            this.t_email_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.t_email_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.t_email_2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Transition_form_2.SetDecoration(this.t_email_2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.t_email_2.Font = new System.Drawing.Font("Sitka Heading", 10.2F, System.Drawing.FontStyle.Bold);
            this.t_email_2.ForeColor = System.Drawing.Color.LightGray;
            this.t_email_2.Location = new System.Drawing.Point(85, 137);
            this.t_email_2.Multiline = true;
            this.t_email_2.Name = "t_email_2";
            this.t_email_2.Size = new System.Drawing.Size(263, 35);
            this.t_email_2.TabIndex = 0;
            this.t_email_2.Text = "UserName";
            this.t_email_2.WordWrap = false;
            this.t_email_2.Click += new System.EventHandler(this.t_email_2_Click);
            this.t_email_2.TextChanged += new System.EventHandler(this.t_email_2_TextChanged);
            this.t_email_2.Leave += new System.EventHandler(this.t_email_2_Leave);
            // 
            // b_login_2
            // 
            this.b_login_2.Animated = true;
            this.b_login_2.AutoRoundedCorners = true;
            this.b_login_2.BackColor = System.Drawing.Color.Transparent;
            this.b_login_2.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.b_login_2.BorderRadius = 13;
            this.b_login_2.BorderThickness = 1;
            this.b_login_2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Transition_form_2.SetDecoration(this.b_login_2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.b_login_2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.b_login_2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.b_login_2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.b_login_2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.b_login_2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.b_login_2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.b_login_2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_login_2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.b_login_2.HoverState.BorderColor = System.Drawing.Color.Plum;
            this.b_login_2.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(80)))));
            this.b_login_2.Image = global::Project_Hoteel.Properties.Resources.login___1_;
            this.b_login_2.ImageSize = new System.Drawing.Size(18, 18);
            this.b_login_2.Location = new System.Drawing.Point(48, 319);
            this.b_login_2.Name = "b_login_2";
            this.b_login_2.ShadowDecoration.BorderRadius = 0;
            this.b_login_2.Size = new System.Drawing.Size(300, 29);
            this.b_login_2.TabIndex = 30;
            this.b_login_2.TabStop = false;
            this.b_login_2.Text = "Log In";
            this.b_login_2.TextFormatNoPrefix = true;
            this.b_login_2.Click += new System.EventHandler(this.b_login_2_Click);
            // 
            // picture_cancel_12
            // 
            this.picture_cancel_12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picture_cancel_12.BackColor = System.Drawing.Color.Transparent;
            this.picture_cancel_12.BackgroundImage = global::Project_Hoteel.Properties.Resources.cross__2_;
            this.picture_cancel_12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Transition_form_2.SetDecoration(this.picture_cancel_12, Guna.UI2.AnimatorNS.DecorationType.None);
            this.picture_cancel_12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picture_cancel_12.Location = new System.Drawing.Point(365, 7);
            this.picture_cancel_12.Name = "picture_cancel_12";
            this.picture_cancel_12.Size = new System.Drawing.Size(27, 27);
            this.picture_cancel_12.TabIndex = 26;
            this.picture_cancel_12.TabStop = false;
            this.picture_cancel_12.Click += new System.EventHandler(this.picture_cancel_12_Click);
            this.picture_cancel_12.MouseLeave += new System.EventHandler(this.picture_cancel_12_MouseLeave);
            this.picture_cancel_12.MouseHover += new System.EventHandler(this.picture_cancel_12_MouseHover);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Transition_form_2.SetDecoration(this.pictureBox4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pictureBox4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox4.Location = new System.Drawing.Point(124, 7);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(152, 78);
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.Transition_form_2.SetDecoration(this.pictureBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(34, 128);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.Transition_form_2.SetDecoration(this.pictureBox2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox2.Location = new System.Drawing.Point(34, 204);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // Transition_form_2
            // 
            this.Transition_form_2.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Transparent;
            this.Transition_form_2.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 1F;
            this.Transition_form_2.DefaultAnimation = animation2;
            // 
            // F_LOGIN_SIGNUP_2
            // 
            this.AcceptButton = this.b_login_2;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(399, 601);
            this.Controls.Add(this.t_email_2);
            this.Controls.Add(this.b_login_2);
            this.Controls.Add(this.l_username_2);
            this.Controls.Add(this.l_progress_2);
            this.Controls.Add(this.ProgressBar_2);
            this.Controls.Add(this.picture_cancel_12);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.t_password_2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.l_notificatio_2);
            this.Transition_form_2.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_LOGIN_SIGNUP_2";
            this.Opacity = 0.93D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_LOGIN_SIGNUP_2";
            this.Load += new System.EventHandler(this.F_LOGIN_SIGNUP_2_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.F_LOGIN_SIGNUP_2_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.picture_cancel_12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        public System.Windows.Forms.Timer timer_progress_2;
        private System.Windows.Forms.TextBox t_password_2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox picture_cancel_12;
        private System.Windows.Forms.Label l_progress_2;
        private CircularProgressBar.CircularProgressBar ProgressBar_2;
        private System.Windows.Forms.Label l_username_2;
        private Guna.UI2.WinForms.Guna2Button b_login_2;
        private System.Windows.Forms.TextBox t_email_2;
        public System.Windows.Forms.Label l_notificatio_2;
        private Guna.UI2.WinForms.Guna2Transition Transition_form_2;
    }
}