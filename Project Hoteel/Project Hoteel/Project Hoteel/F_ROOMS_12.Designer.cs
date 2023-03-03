namespace Project_Hoteel
{
    partial class F_ROOMS_12
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_ROOMS_12));
            this.n_room_12 = new System.Windows.Forms.TextBox();
            this.t_room_12 = new System.Windows.Forms.TextBox();
            this.p_room_12 = new System.Windows.Forms.TextBox();
            this.l_1_6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picture_cancel_12 = new System.Windows.Forms.PictureBox();
            this.b_add_room_12 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_cancel_12)).BeginInit();
            this.SuspendLayout();
            // 
            // n_room_12
            // 
            resources.ApplyResources(this.n_room_12, "n_room_12");
            this.n_room_12.BackColor = System.Drawing.Color.White;
            this.n_room_12.ForeColor = System.Drawing.Color.Black;
            this.n_room_12.Name = "n_room_12";
            this.n_room_12.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.t_fore_name_6_KeyPress);
            // 
            // t_room_12
            // 
            resources.ApplyResources(this.t_room_12, "t_room_12");
            this.t_room_12.BackColor = System.Drawing.Color.White;
            this.t_room_12.ForeColor = System.Drawing.Color.Black;
            this.t_room_12.Name = "t_room_12";
            // 
            // p_room_12
            // 
            resources.ApplyResources(this.p_room_12, "p_room_12");
            this.p_room_12.BackColor = System.Drawing.Color.White;
            this.p_room_12.ForeColor = System.Drawing.Color.Black;
            this.p_room_12.Name = "p_room_12";
            // 
            // l_1_6
            // 
            resources.ApplyResources(this.l_1_6, "l_1_6");
            this.l_1_6.BackColor = System.Drawing.Color.CadetBlue;
            this.l_1_6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.l_1_6.ForeColor = System.Drawing.Color.Black;
            this.l_1_6.Name = "l_1_6";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.CadetBlue;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.CadetBlue;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Name = "label2";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.picture_cancel_12);
            this.panel1.Controls.Add(this.b_add_room_12);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // picture_cancel_12
            // 
            this.picture_cancel_12.BackgroundImage = global::Project_Hoteel.Properties.Resources.cancel_2x;
            resources.ApplyResources(this.picture_cancel_12, "picture_cancel_12");
            this.picture_cancel_12.Name = "picture_cancel_12";
            this.picture_cancel_12.TabStop = false;
            this.picture_cancel_12.Click += new System.EventHandler(this.pictureBox1_Click);
            this.picture_cancel_12.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.picture_cancel_12.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // b_add_room_12
            // 
            resources.ApplyResources(this.b_add_room_12, "b_add_room_12");
            this.b_add_room_12.BackColor = System.Drawing.Color.Silver;
            this.b_add_room_12.ForeColor = System.Drawing.Color.Black;
            this.b_add_room_12.Name = "b_add_room_12";
            this.b_add_room_12.UseVisualStyleBackColor = false;
            this.b_add_room_12.Click += new System.EventHandler(this.b_add_room_12_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // F_ROOMS_12
            // 
            this.AcceptButton = this.b_add_room_12;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.l_1_6);
            this.Controls.Add(this.p_room_12);
            this.Controls.Add(this.t_room_12);
            this.Controls.Add(this.n_room_12);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_ROOMS_12";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture_cancel_12)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox n_room_12;
        public System.Windows.Forms.TextBox t_room_12;
        public System.Windows.Forms.TextBox p_room_12;
        private System.Windows.Forms.Label l_1_6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button b_add_room_12;
        private System.Windows.Forms.PictureBox picture_cancel_12;
        private System.Windows.Forms.Panel panel2;
    }
}