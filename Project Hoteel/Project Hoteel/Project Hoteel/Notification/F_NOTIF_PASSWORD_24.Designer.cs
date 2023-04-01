namespace Project_Hoteel.Forms
{
    partial class F_NOTIF_PASSWORD_24
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_NOTIF_PASSWORD_24));
            this.Borderless_Notif_Pass_24 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.timer_notification_24 = new System.Windows.Forms.Timer(this.components);
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.t_enter_pass_24 = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictor_icon_24 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictor_icon_24)).BeginInit();
            this.SuspendLayout();
            // 
            // Borderless_Notif_Pass_24
            // 
            this.Borderless_Notif_Pass_24.AnimateWindow = true;
            this.Borderless_Notif_Pass_24.AnimationInterval = 400;
            this.Borderless_Notif_Pass_24.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_VER_POSITIVE;
            this.Borderless_Notif_Pass_24.BorderRadius = 5;
            this.Borderless_Notif_Pass_24.ContainerControl = this;
            this.Borderless_Notif_Pass_24.DockForm = false;
            this.Borderless_Notif_Pass_24.DockIndicatorTransparencyValue = 0.6D;
            this.Borderless_Notif_Pass_24.DragForm = false;
            this.Borderless_Notif_Pass_24.DragStartTransparencyValue = 0.7D;
            this.Borderless_Notif_Pass_24.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(30)))));
            this.Borderless_Notif_Pass_24.TransparentWhileDrag = true;
            // 
            // timer_notification_24
            // 
            this.timer_notification_24.Interval = 3000;
            this.timer_notification_24.Tick += new System.EventHandler(this.timer_notification_24_Tick);
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.t_enter_pass_24);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(38, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(321, 60);
            this.guna2GradientPanel1.TabIndex = 3;
            // 
            // t_enter_pass_24
            // 
            this.t_enter_pass_24.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.t_enter_pass_24.Animated = true;
            this.t_enter_pass_24.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.t_enter_pass_24.BorderThickness = 0;
            this.t_enter_pass_24.Cursor = System.Windows.Forms.Cursors.Default;
            this.t_enter_pass_24.CustomizableEdges.BottomRight = false;
            this.t_enter_pass_24.CustomizableEdges.TopRight = false;
            this.t_enter_pass_24.DefaultText = "";
            this.t_enter_pass_24.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.t_enter_pass_24.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.t_enter_pass_24.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.t_enter_pass_24.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.t_enter_pass_24.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.t_enter_pass_24.FocusedState.BorderColor = System.Drawing.Color.Thistle;
            this.t_enter_pass_24.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_enter_pass_24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.t_enter_pass_24.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.t_enter_pass_24.IconRightSize = new System.Drawing.Size(25, 25);
            this.t_enter_pass_24.Location = new System.Drawing.Point(44, 18);
            this.t_enter_pass_24.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.t_enter_pass_24.Name = "t_enter_pass_24";
            this.t_enter_pass_24.PasswordChar = '●';
            this.t_enter_pass_24.PlaceholderForeColor = System.Drawing.Color.Plum;
            this.t_enter_pass_24.PlaceholderText = "أدخل كلمة المرور";
            this.t_enter_pass_24.SelectedText = "";
            this.t_enter_pass_24.Size = new System.Drawing.Size(229, 32);
            this.t_enter_pass_24.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.t_enter_pass_24.TabIndex = 119;
            this.t_enter_pass_24.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.t_enter_pass_24.UseSystemPasswordChar = true;
            // 
            // pictor_icon_24
            // 
            this.pictor_icon_24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.pictor_icon_24.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictor_icon_24.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.pictor_icon_24.Image = ((System.Drawing.Image)(resources.GetObject("pictor_icon_24.Image")));
            this.pictor_icon_24.ImageRotate = 0F;
            this.pictor_icon_24.Location = new System.Drawing.Point(0, 0);
            this.pictor_icon_24.Name = "pictor_icon_24";
            this.pictor_icon_24.Size = new System.Drawing.Size(38, 60);
            this.pictor_icon_24.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictor_icon_24.TabIndex = 2;
            this.pictor_icon_24.TabStop = false;
            this.pictor_icon_24.Click += new System.EventHandler(this.pictor_icon_24_Click);
            // 
            // F_NOTIF_PASSWORD_24
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(359, 60);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.pictor_icon_24);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(615, 0);
            this.Name = "F_NOTIF_PASSWORD_24";
            this.Opacity = 0.87D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.F_NOTIF_PASSWORD_24_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictor_icon_24)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm Borderless_Notif_Pass_24;
        private System.Windows.Forms.Timer timer_notification_24;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2PictureBox pictor_icon_24;
        internal Guna.UI2.WinForms.Guna2TextBox t_enter_pass_24;
    }
}