namespace Project_Hoteel
{
    partial class F_RESIDENTS_10
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_RESIDENTS_10));
            this.gb_residents_10 = new System.Windows.Forms.GroupBox();
            this.t_search_10 = new System.Windows.Forms.TextBox();
            this.dgv_10 = new System.Windows.Forms.DataGridView();
            this.C_inmates_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_nationality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_identification_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_telephone_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_wife_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_wife_identity_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_number_of_individuals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_room_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_meal_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_reservation_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_reservation_expires = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_d_10 = new System.Windows.Forms.GroupBox();
            this.b_edit_10 = new System.Windows.Forms.Button();
            this.b_diparting_10 = new System.Windows.Forms.Button();
            this.b_cancel_10 = new System.Windows.Forms.Button();
            this.b_search_10 = new System.Windows.Forms.Button();
            this.hoteelDataSet = new Project_Hoteel.hoteelDataSet();
            this.gb_residents_10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoteelDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_residents_10
            // 
            this.gb_residents_10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gb_residents_10.BackColor = System.Drawing.Color.Transparent;
            this.gb_residents_10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gb_residents_10.Controls.Add(this.t_search_10);
            this.gb_residents_10.Controls.Add(this.dgv_10);
            this.gb_residents_10.Controls.Add(this.gb_d_10);
            this.gb_residents_10.Controls.Add(this.b_edit_10);
            this.gb_residents_10.Controls.Add(this.b_diparting_10);
            this.gb_residents_10.Controls.Add(this.b_cancel_10);
            this.gb_residents_10.Controls.Add(this.b_search_10);
            this.gb_residents_10.Font = new System.Drawing.Font("PT Bold Heading", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gb_residents_10.ForeColor = System.Drawing.Color.White;
            this.gb_residents_10.Location = new System.Drawing.Point(12, 12);
            this.gb_residents_10.Name = "gb_residents_10";
            this.gb_residents_10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gb_residents_10.Size = new System.Drawing.Size(918, 469);
            this.gb_residents_10.TabIndex = 1;
            this.gb_residents_10.TabStop = false;
            this.gb_residents_10.Text = "المقيمين";
            // 
            // t_search_10
            // 
            this.t_search_10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.t_search_10.BackColor = System.Drawing.Color.Black;
            this.t_search_10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.t_search_10.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.t_search_10.ForeColor = System.Drawing.Color.White;
            this.t_search_10.Location = new System.Drawing.Point(343, 426);
            this.t_search_10.Multiline = true;
            this.t_search_10.Name = "t_search_10";
            this.t_search_10.Size = new System.Drawing.Size(232, 30);
            this.t_search_10.TabIndex = 20;
            this.t_search_10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgv_10
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_10.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_10.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgv_10.BackgroundColor = System.Drawing.Color.Black;
            this.dgv_10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_10.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("PT Bold Heading", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_10.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_10.ColumnHeadersHeight = 40;
            this.dgv_10.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C_inmates_name,
            this.C_nationality,
            this.C_age,
            this.C_identification_number,
            this.C_telephone_number,
            this.C_wife_name,
            this.C_wife_identity_number,
            this.C_number_of_individuals,
            this.C_room_type,
            this.C_meal_type,
            this.C_reservation_date,
            this.C_reservation_expires,
            this.C_price});
            this.dgv_10.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("PT Bold Heading", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_10.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_10.EnableHeadersVisualStyles = false;
            this.dgv_10.GridColor = System.Drawing.Color.White;
            this.dgv_10.Location = new System.Drawing.Point(12, 37);
            this.dgv_10.Name = "dgv_10";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("PT Bold Heading", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_10.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_10.RowHeadersVisible = false;
            this.dgv_10.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_10.RowTemplate.Height = 26;
            this.dgv_10.Size = new System.Drawing.Size(894, 374);
            this.dgv_10.TabIndex = 19;
            // 
            // C_inmates_name
            // 
            this.C_inmates_name.HeaderText = "اسم النزيل";
            this.C_inmates_name.MinimumWidth = 6;
            this.C_inmates_name.Name = "C_inmates_name";
            this.C_inmates_name.Width = 111;
            // 
            // C_nationality
            // 
            this.C_nationality.HeaderText = "الجنسية";
            this.C_nationality.MinimumWidth = 6;
            this.C_nationality.Name = "C_nationality";
            this.C_nationality.Width = 91;
            // 
            // C_age
            // 
            this.C_age.HeaderText = "العمر";
            this.C_age.MinimumWidth = 6;
            this.C_age.Name = "C_age";
            this.C_age.Width = 77;
            // 
            // C_identification_number
            // 
            this.C_identification_number.HeaderText = "رقم الهوية";
            this.C_identification_number.MinimumWidth = 6;
            this.C_identification_number.Name = "C_identification_number";
            this.C_identification_number.Width = 106;
            // 
            // C_telephone_number
            // 
            this.C_telephone_number.HeaderText = "رقم الهاتف";
            this.C_telephone_number.MinimumWidth = 6;
            this.C_telephone_number.Name = "C_telephone_number";
            this.C_telephone_number.Width = 109;
            // 
            // C_wife_name
            // 
            this.C_wife_name.HeaderText = "اسم الزوجة";
            this.C_wife_name.MinimumWidth = 6;
            this.C_wife_name.Name = "C_wife_name";
            this.C_wife_name.Width = 113;
            // 
            // C_wife_identity_number
            // 
            this.C_wife_identity_number.HeaderText = "رقم هوية الزوجة";
            this.C_wife_identity_number.MinimumWidth = 6;
            this.C_wife_identity_number.Name = "C_wife_identity_number";
            this.C_wife_identity_number.Width = 145;
            // 
            // C_number_of_individuals
            // 
            this.C_number_of_individuals.HeaderText = "عدد الافراد";
            this.C_number_of_individuals.MinimumWidth = 6;
            this.C_number_of_individuals.Name = "C_number_of_individuals";
            this.C_number_of_individuals.Width = 108;
            // 
            // C_room_type
            // 
            this.C_room_type.HeaderText = "نوع الغرفة";
            this.C_room_type.MinimumWidth = 6;
            this.C_room_type.Name = "C_room_type";
            this.C_room_type.Width = 106;
            // 
            // C_meal_type
            // 
            this.C_meal_type.HeaderText = "نوع الوجبة";
            this.C_meal_type.MinimumWidth = 6;
            this.C_meal_type.Name = "C_meal_type";
            this.C_meal_type.ReadOnly = true;
            this.C_meal_type.Width = 108;
            // 
            // C_reservation_date
            // 
            this.C_reservation_date.HeaderText = "تاريخ الحجز";
            this.C_reservation_date.MinimumWidth = 6;
            this.C_reservation_date.Name = "C_reservation_date";
            this.C_reservation_date.Width = 111;
            // 
            // C_reservation_expires
            // 
            this.C_reservation_expires.HeaderText = "انتهاء الحجز";
            this.C_reservation_expires.MinimumWidth = 6;
            this.C_reservation_expires.Name = "C_reservation_expires";
            this.C_reservation_expires.Width = 116;
            // 
            // C_price
            // 
            this.C_price.HeaderText = "السعر";
            this.C_price.MinimumWidth = 6;
            this.C_price.Name = "C_price";
            this.C_price.Width = 79;
            // 
            // gb_d_10
            // 
            this.gb_d_10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gb_d_10.BackColor = System.Drawing.Color.Transparent;
            this.gb_d_10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gb_d_10.Font = new System.Drawing.Font("PT Bold Heading", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gb_d_10.ForeColor = System.Drawing.Color.White;
            this.gb_d_10.Location = new System.Drawing.Point(6, 18);
            this.gb_d_10.Name = "gb_d_10";
            this.gb_d_10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gb_d_10.Size = new System.Drawing.Size(906, 399);
            this.gb_d_10.TabIndex = 18;
            this.gb_d_10.TabStop = false;
            // 
            // b_edit_10
            // 
            this.b_edit_10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b_edit_10.BackColor = System.Drawing.Color.Transparent;
            this.b_edit_10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_edit_10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_edit_10.Font = new System.Drawing.Font("PT Simple Bold Ruled", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.b_edit_10.ForeColor = System.Drawing.Color.DarkRed;
            this.b_edit_10.Location = new System.Drawing.Point(652, 421);
            this.b_edit_10.MaximumSize = new System.Drawing.Size(120, 40);
            this.b_edit_10.MinimumSize = new System.Drawing.Size(120, 40);
            this.b_edit_10.Name = "b_edit_10";
            this.b_edit_10.Size = new System.Drawing.Size(120, 40);
            this.b_edit_10.TabIndex = 17;
            this.b_edit_10.Text = "تعديل";
            this.b_edit_10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.b_edit_10.UseVisualStyleBackColor = false;
            // 
            // b_diparting_10
            // 
            this.b_diparting_10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b_diparting_10.BackColor = System.Drawing.Color.Transparent;
            this.b_diparting_10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_diparting_10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_diparting_10.Font = new System.Drawing.Font("PT Simple Bold Ruled", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.b_diparting_10.ForeColor = System.Drawing.Color.DarkRed;
            this.b_diparting_10.Location = new System.Drawing.Point(793, 421);
            this.b_diparting_10.MaximumSize = new System.Drawing.Size(120, 40);
            this.b_diparting_10.MinimumSize = new System.Drawing.Size(120, 40);
            this.b_diparting_10.Name = "b_diparting_10";
            this.b_diparting_10.Size = new System.Drawing.Size(120, 40);
            this.b_diparting_10.TabIndex = 16;
            this.b_diparting_10.Text = "مغادر";
            this.b_diparting_10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.b_diparting_10.UseVisualStyleBackColor = false;
            // 
            // b_cancel_10
            // 
            this.b_cancel_10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b_cancel_10.BackColor = System.Drawing.Color.Transparent;
            this.b_cancel_10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_cancel_10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_cancel_10.Font = new System.Drawing.Font("PT Simple Bold Ruled", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.b_cancel_10.ForeColor = System.Drawing.Color.DarkRed;
            this.b_cancel_10.Location = new System.Drawing.Point(6, 421);
            this.b_cancel_10.MaximumSize = new System.Drawing.Size(120, 40);
            this.b_cancel_10.MinimumSize = new System.Drawing.Size(120, 40);
            this.b_cancel_10.Name = "b_cancel_10";
            this.b_cancel_10.Size = new System.Drawing.Size(120, 40);
            this.b_cancel_10.TabIndex = 15;
            this.b_cancel_10.Text = "رجوع";
            this.b_cancel_10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.b_cancel_10.UseVisualStyleBackColor = false;
            this.b_cancel_10.Click += new System.EventHandler(this.b_cancel_reservation_6_Click);
            // 
            // b_search_10
            // 
            this.b_search_10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b_search_10.BackColor = System.Drawing.Color.Transparent;
            this.b_search_10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_search_10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_search_10.Font = new System.Drawing.Font("PT Simple Bold Ruled", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.b_search_10.ForeColor = System.Drawing.Color.DarkRed;
            this.b_search_10.Location = new System.Drawing.Point(197, 421);
            this.b_search_10.MaximumSize = new System.Drawing.Size(120, 40);
            this.b_search_10.MinimumSize = new System.Drawing.Size(120, 40);
            this.b_search_10.Name = "b_search_10";
            this.b_search_10.Size = new System.Drawing.Size(120, 40);
            this.b_search_10.TabIndex = 14;
            this.b_search_10.Text = "بحث";
            this.b_search_10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.b_search_10.UseVisualStyleBackColor = false;
            // 
            // hoteelDataSet
            // 
            this.hoteelDataSet.DataSetName = "hoteelDataSet";
            this.hoteelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // F_RESIDENTS_10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(942, 493);
            this.Controls.Add(this.gb_residents_10);
            this.DoubleBuffered = true;
            this.Name = "F_RESIDENTS_10";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_RESIDENTS_10";
            this.gb_residents_10.ResumeLayout(false);
            this.gb_residents_10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoteelDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.GroupBox gb_residents_10;
        private hoteelDataSet hoteelDataSet;
        private System.Windows.Forms.TextBox t_search_10;
        public System.Windows.Forms.DataGridView dgv_10;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_inmates_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_nationality;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_age;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_identification_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_telephone_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_wife_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_wife_identity_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_number_of_individuals;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_room_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_meal_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_reservation_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_reservation_expires;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_price;
        public System.Windows.Forms.GroupBox gb_d_10;
        private System.Windows.Forms.Button b_edit_10;
        private System.Windows.Forms.Button b_diparting_10;
        private System.Windows.Forms.Button b_cancel_10;
        private System.Windows.Forms.Button b_search_10;
    }
}