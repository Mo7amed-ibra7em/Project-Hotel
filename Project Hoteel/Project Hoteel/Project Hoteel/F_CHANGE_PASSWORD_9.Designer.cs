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
            this.b_change_password_9 = new System.Windows.Forms.Button();
            this.l_old_9 = new System.Windows.Forms.Label();
            this.l_new_9 = new System.Windows.Forms.Label();
            this.L_9 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // t_password_old_9
            // 
            this.t_password_old_9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.t_password_old_9.BackColor = System.Drawing.Color.Black;
            this.t_password_old_9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.t_password_old_9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.t_password_old_9.ForeColor = System.Drawing.Color.White;
            this.t_password_old_9.Location = new System.Drawing.Point(125, 89);
            this.t_password_old_9.Multiline = true;
            this.t_password_old_9.Name = "t_password_old_9";
            this.t_password_old_9.Size = new System.Drawing.Size(232, 30);
            this.t_password_old_9.TabIndex = 3;
            this.t_password_old_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.t_password_old_9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.t_password_old_9_KeyPress);
            // 
            // t_password_new_9
            // 
            this.t_password_new_9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.t_password_new_9.BackColor = System.Drawing.Color.Black;
            this.t_password_new_9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.t_password_new_9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.t_password_new_9.ForeColor = System.Drawing.Color.White;
            this.t_password_new_9.Location = new System.Drawing.Point(125, 136);
            this.t_password_new_9.Multiline = true;
            this.t_password_new_9.Name = "t_password_new_9";
            this.t_password_new_9.PasswordChar = '*';
            this.t_password_new_9.Size = new System.Drawing.Size(232, 30);
            this.t_password_new_9.TabIndex = 4;
            this.t_password_new_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.t_password_new_9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.t_password_new_9_KeyPress);
            // 
            // b_change_password_9
            // 
            this.b_change_password_9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b_change_password_9.BackColor = System.Drawing.Color.Transparent;
            this.b_change_password_9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_change_password_9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_change_password_9.Font = new System.Drawing.Font("PT Bold Broken", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.b_change_password_9.ForeColor = System.Drawing.Color.DarkRed;
            this.b_change_password_9.Location = new System.Drawing.Point(191, 213);
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
            // l_old_9
            // 
            this.l_old_9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.l_old_9.BackColor = System.Drawing.Color.Transparent;
            this.l_old_9.Font = new System.Drawing.Font("PT Simple Bold Ruled", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.l_old_9.ForeColor = System.Drawing.Color.DarkRed;
            this.l_old_9.Location = new System.Drawing.Point(363, 84);
            this.l_old_9.Name = "l_old_9";
            this.l_old_9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.l_old_9.Size = new System.Drawing.Size(107, 32);
            this.l_old_9.TabIndex = 27;
            this.l_old_9.Text = "كلمة المرور الحالية :";
            this.l_old_9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l_new_9
            // 
            this.l_new_9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.l_new_9.BackColor = System.Drawing.Color.Transparent;
            this.l_new_9.Font = new System.Drawing.Font("PT Simple Bold Ruled", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.l_new_9.ForeColor = System.Drawing.Color.DarkRed;
            this.l_new_9.Location = new System.Drawing.Point(363, 132);
            this.l_new_9.Name = "l_new_9";
            this.l_new_9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.l_new_9.Size = new System.Drawing.Size(107, 32);
            this.l_new_9.TabIndex = 28;
            this.l_new_9.Text = "كلمة المرور الجديدة :";
            this.l_new_9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // L_9
            // 
            this.L_9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.L_9.BackColor = System.Drawing.Color.Transparent;
            this.L_9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.L_9.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_9.ForeColor = System.Drawing.Color.DarkRed;
            this.L_9.Location = new System.Drawing.Point(125, 247);
            this.L_9.Name = "L_9";
            this.L_9.Size = new System.Drawing.Size(232, 28);
            this.L_9.TabIndex = 29;
            this.L_9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // F_CHANGE_PASSWORD_9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(482, 303);
            this.Controls.Add(this.L_9);
            this.Controls.Add(this.l_new_9);
            this.Controls.Add(this.l_old_9);
            this.Controls.Add(this.t_password_new_9);
            this.Controls.Add(this.t_password_old_9);
            this.Controls.Add(this.b_change_password_9);
            this.DoubleBuffered = true;
            this.Name = "F_CHANGE_PASSWORD_9";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_CHANGE_PASSWORD_9";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox t_password_old_9;
        private System.Windows.Forms.TextBox t_password_new_9;
        private System.Windows.Forms.Button b_change_password_9;
        public System.Windows.Forms.Label l_old_9;
        public System.Windows.Forms.Label l_new_9;
        private System.Windows.Forms.Label L_9;
        private System.Windows.Forms.Timer timer1;
    }
}