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
            this.panel2 = new System.Windows.Forms.Panel();
            this.L_9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picture_cancel_12 = new System.Windows.Forms.PictureBox();
            this.b_change_password_9 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_cancel_12)).BeginInit();
            this.SuspendLayout();
            // 
            // t_password_old_9
            // 
            this.t_password_old_9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.t_password_old_9.BackColor = System.Drawing.Color.White;
            this.t_password_old_9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.t_password_old_9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.t_password_old_9.ForeColor = System.Drawing.Color.Black;
            this.t_password_old_9.Location = new System.Drawing.Point(23, 52);
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
            this.t_password_new_9.Location = new System.Drawing.Point(23, 99);
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
            this.l_old_9.BackColor = System.Drawing.Color.CadetBlue;
            this.l_old_9.Font = new System.Drawing.Font("PT Simple Bold Ruled", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.l_old_9.ForeColor = System.Drawing.Color.Black;
            this.l_old_9.Location = new System.Drawing.Point(261, 47);
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
            this.l_new_9.BackColor = System.Drawing.Color.CadetBlue;
            this.l_new_9.Font = new System.Drawing.Font("PT Simple Bold Ruled", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.l_new_9.ForeColor = System.Drawing.Color.Black;
            this.l_new_9.Location = new System.Drawing.Point(261, 95);
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
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(388, 228);
            this.panel2.TabIndex = 30;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // L_9
            // 
            this.L_9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.L_9.BackColor = System.Drawing.Color.CadetBlue;
            this.L_9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.L_9.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_9.ForeColor = System.Drawing.Color.DarkRed;
            this.L_9.Location = new System.Drawing.Point(65, 122);
            this.L_9.Name = "L_9";
            this.L_9.Size = new System.Drawing.Size(232, 28);
            this.L_9.TabIndex = 29;
            this.L_9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.L_9.Click += new System.EventHandler(this.L_9_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.picture_cancel_12);
            this.panel1.Controls.Add(this.L_9);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 204);
            this.panel1.TabIndex = 30;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // picture_cancel_12
            // 
            this.picture_cancel_12.BackgroundImage = global::Project_Hoteel.Properties.Resources.cancel_2x;
            this.picture_cancel_12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picture_cancel_12.Location = new System.Drawing.Point(330, 2);
            this.picture_cancel_12.Name = "picture_cancel_12";
            this.picture_cancel_12.Size = new System.Drawing.Size(32, 32);
            this.picture_cancel_12.TabIndex = 30;
            this.picture_cancel_12.TabStop = false;
            this.picture_cancel_12.Click += new System.EventHandler(this.picture_cancel_12_Click);
            this.picture_cancel_12.MouseLeave += new System.EventHandler(this.picture_cancel_12_MouseLeave);
            this.picture_cancel_12.MouseHover += new System.EventHandler(this.picture_cancel_12_MouseHover);
            // 
            // b_change_password_9
            // 
            this.b_change_password_9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b_change_password_9.BackColor = System.Drawing.Color.Silver;
            this.b_change_password_9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_change_password_9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b_change_password_9.Font = new System.Drawing.Font("PT Bold Broken", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.b_change_password_9.ForeColor = System.Drawing.Color.Black;
            this.b_change_password_9.Image = global::Project_Hoteel.Properties.Resources.reset_password__1_;
            this.b_change_password_9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_change_password_9.Location = new System.Drawing.Point(144, 168);
            this.b_change_password_9.MaximumSize = new System.Drawing.Size(100, 32);
            this.b_change_password_9.MinimumSize = new System.Drawing.Size(100, 32);
            this.b_change_password_9.Name = "b_change_password_9";
            this.b_change_password_9.Size = new System.Drawing.Size(100, 32);
            this.b_change_password_9.TabIndex = 0;
            this.b_change_password_9.Text = "تغيير";
            this.b_change_password_9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.b_change_password_9.UseVisualStyleBackColor = false;
            this.b_change_password_9.Click += new System.EventHandler(this.b_change_password_9_Click);
            // 
            // F_CHANGE_PASSWORD_9
            // 
            this.AcceptButton = this.b_change_password_9;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(388, 228);
            this.Controls.Add(this.l_new_9);
            this.Controls.Add(this.l_old_9);
            this.Controls.Add(this.t_password_new_9);
            this.Controls.Add(this.t_password_old_9);
            this.Controls.Add(this.b_change_password_9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F_CHANGE_PASSWORD_9";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_CHANGE_PASSWORD_9";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture_cancel_12)).EndInit();
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label L_9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picture_cancel_12;
    }
}