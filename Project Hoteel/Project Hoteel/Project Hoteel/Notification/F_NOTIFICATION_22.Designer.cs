namespace Project_Hoteel.Notification
{
    partial class F_NOTIFICATION_22
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_NOTIFICATION_22));
            this.pictor_icon_22 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label_notification_22 = new System.Windows.Forms.Label();
            this.timer_notification_22 = new System.Windows.Forms.Timer(this.components);
            this.Borderless_Notification = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictor_icon_22)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictor_icon_22
            // 
            this.pictor_icon_22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.pictor_icon_22.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictor_icon_22.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.pictor_icon_22.Image = ((System.Drawing.Image)(resources.GetObject("pictor_icon_22.Image")));
            this.pictor_icon_22.ImageRotate = 0F;
            this.pictor_icon_22.Location = new System.Drawing.Point(0, 0);
            this.pictor_icon_22.Name = "pictor_icon_22";
            this.pictor_icon_22.Size = new System.Drawing.Size(38, 63);
            this.pictor_icon_22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictor_icon_22.TabIndex = 0;
            this.pictor_icon_22.TabStop = false;
            this.pictor_icon_22.Click += new System.EventHandler(this.pictor_icon_22_Click);
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.label_notification_22);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(38, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(321, 63);
            this.guna2GradientPanel1.TabIndex = 1;
            // 
            // label_notification_22
            // 
            this.label_notification_22.BackColor = System.Drawing.Color.Transparent;
            this.label_notification_22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_notification_22.Font = new System.Drawing.Font("Amiri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label_notification_22.ForeColor = System.Drawing.Color.White;
            this.label_notification_22.Location = new System.Drawing.Point(0, 0);
            this.label_notification_22.Name = "label_notification_22";
            this.label_notification_22.Size = new System.Drawing.Size(321, 63);
            this.label_notification_22.TabIndex = 0;
            this.label_notification_22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_notification_22.Click += new System.EventHandler(this.label_notification_22_Click);
            // 
            // timer_notification_22
            // 
            this.timer_notification_22.Enabled = true;
            this.timer_notification_22.Interval = 3000;
            this.timer_notification_22.Tick += new System.EventHandler(this.timer_notification_22_Tick);
            // 
            // Borderless_Notification
            // 
            this.Borderless_Notification.AnimateWindow = true;
            this.Borderless_Notification.AnimationInterval = 400;
            this.Borderless_Notification.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_VER_POSITIVE;
            this.Borderless_Notification.BorderRadius = 6;
            this.Borderless_Notification.ContainerControl = this;
            this.Borderless_Notification.DockForm = false;
            this.Borderless_Notification.DockIndicatorTransparencyValue = 0.6D;
            this.Borderless_Notification.DragForm = false;
            this.Borderless_Notification.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(30)))));
            this.Borderless_Notification.TransparentWhileDrag = true;
            // 
            // F_NOTIFICATION_22
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 63);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.pictor_icon_22);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(615, 0);
            this.Name = "F_NOTIFICATION_22";
            this.Opacity = 0.87D;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "F_notification_22";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.F_NOTIFICATION_22_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictor_icon_22)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox pictor_icon_22;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        public System.Windows.Forms.Label label_notification_22;
        private System.Windows.Forms.Timer timer_notification_22;
        private Guna.UI2.WinForms.Guna2BorderlessForm Borderless_Notification;
    }
}