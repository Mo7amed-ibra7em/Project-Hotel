namespace Project_Hoteel
{
    partial class F_ACC_EMP_19
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
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_ACC_EMP_19));
            this.label_19 = new System.Windows.Forms.Label();
            this.Transition_19 = new Guna.UI2.WinForms.Guna2Transition();
            this.label2 = new System.Windows.Forms.Label();
            this.t_emp_name_19 = new Guna.UI2.WinForms.Guna2TextBox();
            this.t_email_emp_19 = new Guna.UI2.WinForms.Guna2TextBox();
            this.l_1_6 = new System.Windows.Forms.Label();
            this.t_username_19 = new Guna.UI2.WinForms.Guna2TextBox();
            this.b_save_employe_19 = new Guna.UI2.WinForms.Guna2Button();
            this.l_2_6 = new System.Windows.Forms.Label();
            this.l_3_6 = new System.Windows.Forms.Label();
            this.t_telephone_emp_19 = new Guna.UI2.WinForms.Guna2TextBox();
            this.t_password_19 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.l_5_6 = new System.Windows.Forms.Label();
            this.date_start_date_19 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.l_8_6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.t_salary_emp_19 = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbox_type_emp_19 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.t_age_19 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbox_sex_19 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.l_notificatio_19 = new System.Windows.Forms.Label();
            this.timer_add_emp_19 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label_19
            // 
            this.label_19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_19.BackColor = System.Drawing.Color.Transparent;
            this.Transition_19.SetDecoration(this.label_19, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label_19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_19.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.label_19.Location = new System.Drawing.Point(862, 9);
            this.label_19.Name = "label_19";
            this.label_19.Size = new System.Drawing.Size(90, 36);
            this.label_19.TabIndex = 87;
            this.label_19.Text = "المـوظفيـن";
            this.label_19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Transition_19
            // 
            this.Transition_19.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Particles;
            this.Transition_19.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 1;
            animation1.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 2F;
            animation1.TransparencyCoeff = 0F;
            this.Transition_19.DefaultAnimation = animation1;
            this.Transition_19.Interval = 5;
            this.Transition_19.TimeStep = 0.01F;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.Transition_19.SetDecoration(this.label2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("PT Simple Bold Ruled", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(261, 366);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(105, 27);
            this.label2.TabIndex = 117;
            this.label2.Text = "البريد الالكتروني";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // t_emp_name_19
            // 
            this.t_emp_name_19.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.t_emp_name_19.Animated = true;
            this.t_emp_name_19.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.t_emp_name_19.BorderRadius = 10;
            this.t_emp_name_19.BorderThickness = 0;
            this.t_emp_name_19.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.t_emp_name_19.CustomizableEdges.BottomLeft = false;
            this.t_emp_name_19.CustomizableEdges.TopLeft = false;
            this.Transition_19.SetDecoration(this.t_emp_name_19, Guna.UI2.AnimatorNS.DecorationType.None);
            this.t_emp_name_19.DefaultText = "";
            this.t_emp_name_19.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.t_emp_name_19.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.t_emp_name_19.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.t_emp_name_19.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.t_emp_name_19.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.t_emp_name_19.FocusedState.BorderColor = System.Drawing.Color.Plum;
            this.t_emp_name_19.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_emp_name_19.ForeColor = System.Drawing.Color.White;
            this.t_emp_name_19.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.t_emp_name_19.Location = new System.Drawing.Point(603, 117);
            this.t_emp_name_19.Name = "t_emp_name_19";
            this.t_emp_name_19.PasswordChar = '\0';
            this.t_emp_name_19.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.t_emp_name_19.PlaceholderText = "";
            this.t_emp_name_19.SelectedText = "";
            this.t_emp_name_19.Size = new System.Drawing.Size(275, 36);
            this.t_emp_name_19.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.t_emp_name_19.TabIndex = 106;
            this.t_emp_name_19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // t_email_emp_19
            // 
            this.t_email_emp_19.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.t_email_emp_19.Animated = true;
            this.t_email_emp_19.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.t_email_emp_19.BorderRadius = 10;
            this.t_email_emp_19.BorderThickness = 0;
            this.t_email_emp_19.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.t_email_emp_19.CustomizableEdges.BottomRight = false;
            this.t_email_emp_19.CustomizableEdges.TopRight = false;
            this.Transition_19.SetDecoration(this.t_email_emp_19, Guna.UI2.AnimatorNS.DecorationType.None);
            this.t_email_emp_19.DefaultText = "";
            this.t_email_emp_19.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.t_email_emp_19.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.t_email_emp_19.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.t_email_emp_19.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.t_email_emp_19.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.t_email_emp_19.FocusedState.BorderColor = System.Drawing.Color.Plum;
            this.t_email_emp_19.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_email_emp_19.ForeColor = System.Drawing.Color.White;
            this.t_email_emp_19.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.t_email_emp_19.Location = new System.Drawing.Point(96, 392);
            this.t_email_emp_19.Name = "t_email_emp_19";
            this.t_email_emp_19.PasswordChar = '\0';
            this.t_email_emp_19.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.t_email_emp_19.PlaceholderText = "";
            this.t_email_emp_19.SelectedText = "";
            this.t_email_emp_19.Size = new System.Drawing.Size(275, 36);
            this.t_email_emp_19.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.t_email_emp_19.TabIndex = 118;
            this.t_email_emp_19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // l_1_6
            // 
            this.l_1_6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.l_1_6.AutoSize = true;
            this.l_1_6.BackColor = System.Drawing.Color.Transparent;
            this.Transition_19.SetDecoration(this.l_1_6, Guna.UI2.AnimatorNS.DecorationType.None);
            this.l_1_6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.l_1_6.Font = new System.Drawing.Font("PT Simple Bold Ruled", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.l_1_6.ForeColor = System.Drawing.Color.White;
            this.l_1_6.Location = new System.Drawing.Point(793, 92);
            this.l_1_6.Name = "l_1_6";
            this.l_1_6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.l_1_6.Size = new System.Drawing.Size(78, 27);
            this.l_1_6.TabIndex = 101;
            this.l_1_6.Text = "اسم الموظف";
            this.l_1_6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // t_username_19
            // 
            this.t_username_19.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.t_username_19.Animated = true;
            this.t_username_19.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.t_username_19.BorderRadius = 10;
            this.t_username_19.BorderThickness = 0;
            this.t_username_19.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.t_username_19.CustomizableEdges.BottomLeft = false;
            this.t_username_19.CustomizableEdges.TopLeft = false;
            this.Transition_19.SetDecoration(this.t_username_19, Guna.UI2.AnimatorNS.DecorationType.None);
            this.t_username_19.DefaultText = "";
            this.t_username_19.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.t_username_19.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.t_username_19.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.t_username_19.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.t_username_19.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.t_username_19.FocusedState.BorderColor = System.Drawing.Color.Plum;
            this.t_username_19.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_username_19.ForeColor = System.Drawing.Color.White;
            this.t_username_19.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.t_username_19.Location = new System.Drawing.Point(603, 252);
            this.t_username_19.Name = "t_username_19";
            this.t_username_19.PasswordChar = '\0';
            this.t_username_19.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.t_username_19.PlaceholderText = "";
            this.t_username_19.SelectedText = "";
            this.t_username_19.Size = new System.Drawing.Size(275, 36);
            this.t_username_19.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.t_username_19.TabIndex = 107;
            this.t_username_19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // b_save_employe_19
            // 
            this.b_save_employe_19.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.b_save_employe_19.Animated = true;
            this.b_save_employe_19.AutoRoundedCorners = true;
            this.b_save_employe_19.BackColor = System.Drawing.Color.Transparent;
            this.b_save_employe_19.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.b_save_employe_19.BorderRadius = 18;
            this.b_save_employe_19.BorderThickness = 1;
            this.b_save_employe_19.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Transition_19.SetDecoration(this.b_save_employe_19, Guna.UI2.AnimatorNS.DecorationType.None);
            this.b_save_employe_19.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.b_save_employe_19.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.b_save_employe_19.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.b_save_employe_19.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.b_save_employe_19.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.b_save_employe_19.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.b_save_employe_19.Font = new System.Drawing.Font("PT Bold Heading", 9F);
            this.b_save_employe_19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.b_save_employe_19.HoverState.BorderColor = System.Drawing.Color.Plum;
            this.b_save_employe_19.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(80)))));
            this.b_save_employe_19.Image = ((System.Drawing.Image)(resources.GetObject("b_save_employe_19.Image")));
            this.b_save_employe_19.ImageSize = new System.Drawing.Size(18, 18);
            this.b_save_employe_19.Location = new System.Drawing.Point(379, 572);
            this.b_save_employe_19.Name = "b_save_employe_19";
            this.b_save_employe_19.ShadowDecoration.BorderRadius = 0;
            this.b_save_employe_19.Size = new System.Drawing.Size(205, 39);
            this.b_save_employe_19.TabIndex = 115;
            this.b_save_employe_19.TabStop = false;
            this.b_save_employe_19.Text = "إضافة";
            this.b_save_employe_19.TextFormatNoPrefix = true;
            this.b_save_employe_19.Click += new System.EventHandler(this.b_save_employe_19_Click);
            // 
            // l_2_6
            // 
            this.l_2_6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.l_2_6.AutoSize = true;
            this.l_2_6.BackColor = System.Drawing.Color.Transparent;
            this.Transition_19.SetDecoration(this.l_2_6, Guna.UI2.AnimatorNS.DecorationType.None);
            this.l_2_6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.l_2_6.Font = new System.Drawing.Font("PT Simple Bold Ruled", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.l_2_6.ForeColor = System.Drawing.Color.White;
            this.l_2_6.Location = new System.Drawing.Point(779, 226);
            this.l_2_6.Name = "l_2_6";
            this.l_2_6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.l_2_6.Size = new System.Drawing.Size(92, 27);
            this.l_2_6.TabIndex = 102;
            this.l_2_6.Text = "اسم المستخدم";
            this.l_2_6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l_3_6
            // 
            this.l_3_6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.l_3_6.AutoSize = true;
            this.l_3_6.BackColor = System.Drawing.Color.Transparent;
            this.Transition_19.SetDecoration(this.l_3_6, Guna.UI2.AnimatorNS.DecorationType.None);
            this.l_3_6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.l_3_6.Font = new System.Drawing.Font("PT Simple Bold Ruled", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.l_3_6.ForeColor = System.Drawing.Color.White;
            this.l_3_6.Location = new System.Drawing.Point(286, 296);
            this.l_3_6.Name = "l_3_6";
            this.l_3_6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.l_3_6.Size = new System.Drawing.Size(78, 27);
            this.l_3_6.TabIndex = 103;
            this.l_3_6.Text = "نوع الوظيفة";
            this.l_3_6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // t_telephone_emp_19
            // 
            this.t_telephone_emp_19.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.t_telephone_emp_19.Animated = true;
            this.t_telephone_emp_19.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.t_telephone_emp_19.BorderRadius = 10;
            this.t_telephone_emp_19.BorderThickness = 0;
            this.t_telephone_emp_19.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.t_telephone_emp_19.CustomizableEdges.BottomRight = false;
            this.t_telephone_emp_19.CustomizableEdges.TopRight = false;
            this.Transition_19.SetDecoration(this.t_telephone_emp_19, Guna.UI2.AnimatorNS.DecorationType.None);
            this.t_telephone_emp_19.DefaultText = "";
            this.t_telephone_emp_19.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.t_telephone_emp_19.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.t_telephone_emp_19.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.t_telephone_emp_19.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.t_telephone_emp_19.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.t_telephone_emp_19.FocusedState.BorderColor = System.Drawing.Color.Plum;
            this.t_telephone_emp_19.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_telephone_emp_19.ForeColor = System.Drawing.Color.White;
            this.t_telephone_emp_19.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.t_telephone_emp_19.Location = new System.Drawing.Point(96, 117);
            this.t_telephone_emp_19.Name = "t_telephone_emp_19";
            this.t_telephone_emp_19.PasswordChar = '\0';
            this.t_telephone_emp_19.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.t_telephone_emp_19.PlaceholderText = "";
            this.t_telephone_emp_19.SelectedText = "";
            this.t_telephone_emp_19.Size = new System.Drawing.Size(275, 36);
            this.t_telephone_emp_19.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.t_telephone_emp_19.TabIndex = 108;
            this.t_telephone_emp_19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // t_password_19
            // 
            this.t_password_19.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.t_password_19.Animated = true;
            this.t_password_19.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.t_password_19.BorderRadius = 10;
            this.t_password_19.BorderThickness = 0;
            this.t_password_19.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.t_password_19.CustomizableEdges.BottomRight = false;
            this.t_password_19.CustomizableEdges.TopRight = false;
            this.Transition_19.SetDecoration(this.t_password_19, Guna.UI2.AnimatorNS.DecorationType.None);
            this.t_password_19.DefaultText = "";
            this.t_password_19.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.t_password_19.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.t_password_19.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.t_password_19.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.t_password_19.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.t_password_19.FocusedState.BorderColor = System.Drawing.Color.Plum;
            this.t_password_19.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_password_19.ForeColor = System.Drawing.Color.White;
            this.t_password_19.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.t_password_19.Location = new System.Drawing.Point(96, 252);
            this.t_password_19.Name = "t_password_19";
            this.t_password_19.PasswordChar = '\0';
            this.t_password_19.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.t_password_19.PlaceholderText = "";
            this.t_password_19.SelectedText = "";
            this.t_password_19.Size = new System.Drawing.Size(275, 36);
            this.t_password_19.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.t_password_19.TabIndex = 109;
            this.t_password_19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.Transition_19.SetDecoration(this.label3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("PT Simple Bold Ruled", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(790, 366);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(81, 27);
            this.label3.TabIndex = 113;
            this.label3.Text = "تاريخ العمل";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l_5_6
            // 
            this.l_5_6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.l_5_6.AutoSize = true;
            this.l_5_6.BackColor = System.Drawing.Color.Transparent;
            this.Transition_19.SetDecoration(this.l_5_6, Guna.UI2.AnimatorNS.DecorationType.None);
            this.l_5_6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.l_5_6.Font = new System.Drawing.Font("PT Simple Bold Ruled", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.l_5_6.ForeColor = System.Drawing.Color.White;
            this.l_5_6.Location = new System.Drawing.Point(318, 92);
            this.l_5_6.Name = "l_5_6";
            this.l_5_6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.l_5_6.Size = new System.Drawing.Size(48, 27);
            this.l_5_6.TabIndex = 104;
            this.l_5_6.Text = "الهاتف";
            this.l_5_6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // date_start_date_19
            // 
            this.date_start_date_19.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.date_start_date_19.Animated = true;
            this.date_start_date_19.BackColor = System.Drawing.Color.Transparent;
            this.date_start_date_19.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.date_start_date_19.BorderRadius = 10;
            this.date_start_date_19.BorderThickness = 1;
            this.date_start_date_19.Checked = true;
            this.date_start_date_19.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.date_start_date_19.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.date_start_date_19.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.date_start_date_19.CustomFormat = "dd - MM - yyyy";
            this.date_start_date_19.CustomizableEdges.BottomLeft = false;
            this.date_start_date_19.CustomizableEdges.TopLeft = false;
            this.Transition_19.SetDecoration(this.date_start_date_19, Guna.UI2.AnimatorNS.DecorationType.None);
            this.date_start_date_19.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.date_start_date_19.Font = new System.Drawing.Font("Simplified Arabic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_start_date_19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.date_start_date_19.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_start_date_19.HoverState.BorderColor = System.Drawing.Color.Plum;
            this.date_start_date_19.HoverState.FillColor = System.Drawing.Color.CornflowerBlue;
            this.date_start_date_19.Location = new System.Drawing.Point(603, 392);
            this.date_start_date_19.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.date_start_date_19.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.date_start_date_19.Name = "date_start_date_19";
            this.date_start_date_19.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.date_start_date_19.Size = new System.Drawing.Size(275, 36);
            this.date_start_date_19.TabIndex = 112;
            this.date_start_date_19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.date_start_date_19.Value = new System.DateTime(2023, 2, 25, 14, 59, 17, 577);
            // 
            // l_8_6
            // 
            this.l_8_6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.l_8_6.AutoSize = true;
            this.l_8_6.BackColor = System.Drawing.Color.Transparent;
            this.Transition_19.SetDecoration(this.l_8_6, Guna.UI2.AnimatorNS.DecorationType.None);
            this.l_8_6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.l_8_6.Font = new System.Drawing.Font("PT Simple Bold Ruled", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.l_8_6.ForeColor = System.Drawing.Color.White;
            this.l_8_6.Location = new System.Drawing.Point(294, 226);
            this.l_8_6.Name = "l_8_6";
            this.l_8_6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.l_8_6.Size = new System.Drawing.Size(72, 27);
            this.l_8_6.TabIndex = 105;
            this.l_8_6.Text = "كلمة المرور";
            this.l_8_6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.Transition_19.SetDecoration(this.label1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("PT Simple Bold Ruled", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(820, 296);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(50, 27);
            this.label1.TabIndex = 110;
            this.label1.Text = "الراتب";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // t_salary_emp_19
            // 
            this.t_salary_emp_19.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.t_salary_emp_19.Animated = true;
            this.t_salary_emp_19.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.t_salary_emp_19.BorderRadius = 10;
            this.t_salary_emp_19.BorderThickness = 0;
            this.t_salary_emp_19.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.t_salary_emp_19.CustomizableEdges.BottomLeft = false;
            this.t_salary_emp_19.CustomizableEdges.TopLeft = false;
            this.Transition_19.SetDecoration(this.t_salary_emp_19, Guna.UI2.AnimatorNS.DecorationType.None);
            this.t_salary_emp_19.DefaultText = "";
            this.t_salary_emp_19.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.t_salary_emp_19.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.t_salary_emp_19.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.t_salary_emp_19.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.t_salary_emp_19.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.t_salary_emp_19.FocusedState.BorderColor = System.Drawing.Color.Plum;
            this.t_salary_emp_19.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_salary_emp_19.ForeColor = System.Drawing.Color.White;
            this.t_salary_emp_19.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.t_salary_emp_19.Location = new System.Drawing.Point(603, 322);
            this.t_salary_emp_19.Name = "t_salary_emp_19";
            this.t_salary_emp_19.PasswordChar = '\0';
            this.t_salary_emp_19.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.t_salary_emp_19.PlaceholderText = "";
            this.t_salary_emp_19.SelectedText = "";
            this.t_salary_emp_19.Size = new System.Drawing.Size(275, 36);
            this.t_salary_emp_19.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.t_salary_emp_19.TabIndex = 111;
            this.t_salary_emp_19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbox_type_emp_19
            // 
            this.cbox_type_emp_19.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbox_type_emp_19.BackColor = System.Drawing.Color.Transparent;
            this.cbox_type_emp_19.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.cbox_type_emp_19.BorderRadius = 10;
            this.cbox_type_emp_19.BorderThickness = 0;
            this.cbox_type_emp_19.CustomizableEdges.BottomRight = false;
            this.cbox_type_emp_19.CustomizableEdges.TopRight = false;
            this.Transition_19.SetDecoration(this.cbox_type_emp_19, Guna.UI2.AnimatorNS.DecorationType.None);
            this.cbox_type_emp_19.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbox_type_emp_19.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_type_emp_19.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.cbox_type_emp_19.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbox_type_emp_19.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbox_type_emp_19.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbox_type_emp_19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.cbox_type_emp_19.HoverState.BorderColor = System.Drawing.Color.Thistle;
            this.cbox_type_emp_19.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.cbox_type_emp_19.IntegralHeight = false;
            this.cbox_type_emp_19.ItemHeight = 22;
            this.cbox_type_emp_19.Items.AddRange(new object[] {
            "موظف حجز",
            "محاسب"});
            this.cbox_type_emp_19.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cbox_type_emp_19.ItemsAppearance.SelectedForeColor = System.Drawing.Color.Black;
            this.cbox_type_emp_19.Location = new System.Drawing.Point(96, 322);
            this.cbox_type_emp_19.Name = "cbox_type_emp_19";
            this.cbox_type_emp_19.Size = new System.Drawing.Size(275, 28);
            this.cbox_type_emp_19.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbox_type_emp_19.TabIndex = 119;
            this.cbox_type_emp_19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.Transition_19.SetDecoration(this.label4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("PT Simple Bold Ruled", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(321, 163);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(44, 27);
            this.label4.TabIndex = 121;
            this.label4.Text = "العمر";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // t_age_19
            // 
            this.t_age_19.Animated = true;
            this.t_age_19.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.t_age_19.BorderRadius = 10;
            this.t_age_19.BorderThickness = 0;
            this.t_age_19.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.t_age_19.CustomizableEdges.BottomRight = false;
            this.t_age_19.CustomizableEdges.TopRight = false;
            this.Transition_19.SetDecoration(this.t_age_19, Guna.UI2.AnimatorNS.DecorationType.None);
            this.t_age_19.DefaultText = "";
            this.t_age_19.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.t_age_19.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.t_age_19.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.t_age_19.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.t_age_19.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.t_age_19.FocusedState.BorderColor = System.Drawing.Color.Plum;
            this.t_age_19.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_age_19.ForeColor = System.Drawing.Color.White;
            this.t_age_19.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.t_age_19.Location = new System.Drawing.Point(96, 189);
            this.t_age_19.Name = "t_age_19";
            this.t_age_19.PasswordChar = '\0';
            this.t_age_19.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.t_age_19.PlaceholderText = "";
            this.t_age_19.SelectedText = "";
            this.t_age_19.Size = new System.Drawing.Size(275, 32);
            this.t_age_19.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.t_age_19.TabIndex = 123;
            this.t_age_19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.Transition_19.SetDecoration(this.label5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("PT Simple Bold Ruled", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(814, 163);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(49, 27);
            this.label5.TabIndex = 120;
            this.label5.Text = "الجنس";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbox_sex_19
            // 
            this.cbox_sex_19.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbox_sex_19.BackColor = System.Drawing.Color.Transparent;
            this.cbox_sex_19.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.cbox_sex_19.BorderRadius = 10;
            this.cbox_sex_19.BorderThickness = 0;
            this.cbox_sex_19.CustomizableEdges.BottomLeft = false;
            this.cbox_sex_19.CustomizableEdges.TopLeft = false;
            this.Transition_19.SetDecoration(this.cbox_sex_19, Guna.UI2.AnimatorNS.DecorationType.None);
            this.cbox_sex_19.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbox_sex_19.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_sex_19.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.cbox_sex_19.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbox_sex_19.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbox_sex_19.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbox_sex_19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.cbox_sex_19.HoverState.BorderColor = System.Drawing.Color.Thistle;
            this.cbox_sex_19.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.cbox_sex_19.IntegralHeight = false;
            this.cbox_sex_19.ItemHeight = 22;
            this.cbox_sex_19.Items.AddRange(new object[] {
            "ذكر",
            "انثى"});
            this.cbox_sex_19.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cbox_sex_19.ItemsAppearance.SelectedForeColor = System.Drawing.Color.Black;
            this.cbox_sex_19.Location = new System.Drawing.Point(603, 189);
            this.cbox_sex_19.Name = "cbox_sex_19";
            this.cbox_sex_19.Size = new System.Drawing.Size(275, 28);
            this.cbox_sex_19.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbox_sex_19.TabIndex = 124;
            this.cbox_sex_19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // l_notificatio_19
            // 
            this.l_notificatio_19.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.l_notificatio_19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Transition_19.SetDecoration(this.l_notificatio_19, Guna.UI2.AnimatorNS.DecorationType.None);
            this.l_notificatio_19.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_notificatio_19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.l_notificatio_19.Location = new System.Drawing.Point(312, 503);
            this.l_notificatio_19.Name = "l_notificatio_19";
            this.l_notificatio_19.Size = new System.Drawing.Size(341, 31);
            this.l_notificatio_19.TabIndex = 125;
            this.l_notificatio_19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.l_notificatio_19.Visible = false;
            // 
            // timer_add_emp_19
            // 
            this.timer_add_emp_19.Interval = 1;
            this.timer_add_emp_19.Tick += new System.EventHandler(this.timer_add_emp_19_Tick);
            // 
            // F_ACC_EMP_19
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(964, 645);
            this.Controls.Add(this.l_notificatio_19);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbox_sex_19);
            this.Controls.Add(this.l_1_6);
            this.Controls.Add(this.l_2_6);
            this.Controls.Add(this.l_5_6);
            this.Controls.Add(this.l_8_6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.t_age_19);
            this.Controls.Add(this.l_3_6);
            this.Controls.Add(this.cbox_type_emp_19);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.t_emp_name_19);
            this.Controls.Add(this.t_email_emp_19);
            this.Controls.Add(this.t_username_19);
            this.Controls.Add(this.b_save_employe_19);
            this.Controls.Add(this.t_telephone_emp_19);
            this.Controls.Add(this.t_password_19);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.date_start_date_19);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.t_salary_emp_19);
            this.Controls.Add(this.label_19);
            this.Transition_19.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_ACC_EMP_19";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_ACC_EMP_19";
            this.Load += new System.EventHandler(this.F_ACC_EMP_19_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_19;
        private Guna.UI2.WinForms.Guna2Transition Transition_19;
        private System.Windows.Forms.Timer timer_add_emp_19;
        private System.Windows.Forms.Label label2;
        internal Guna.UI2.WinForms.Guna2TextBox t_emp_name_19;
        internal Guna.UI2.WinForms.Guna2TextBox t_email_emp_19;
        private System.Windows.Forms.Label l_1_6;
        internal Guna.UI2.WinForms.Guna2TextBox t_username_19;
        private Guna.UI2.WinForms.Guna2Button b_save_employe_19;
        private System.Windows.Forms.Label l_2_6;
        private System.Windows.Forms.Label l_3_6;
        internal Guna.UI2.WinForms.Guna2TextBox t_telephone_emp_19;
        internal Guna.UI2.WinForms.Guna2TextBox t_password_19;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label l_5_6;
        private Guna.UI2.WinForms.Guna2DateTimePicker date_start_date_19;
        private System.Windows.Forms.Label l_8_6;
        private System.Windows.Forms.Label label1;
        internal Guna.UI2.WinForms.Guna2TextBox t_salary_emp_19;
        private Guna.UI2.WinForms.Guna2ComboBox cbox_type_emp_19;
        private System.Windows.Forms.Label label4;
        internal Guna.UI2.WinForms.Guna2TextBox t_age_19;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox cbox_sex_19;
        private System.Windows.Forms.Label l_notificatio_19;
    }
}