﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Hoteel
{
    public partial class F_EMP_ACCOUNT_4 : Form
    {

        string connstr = "Data Source=M-A-IBRAHEM; Initial Catalog=Hotel Reservation;Integrated Security = True";

        public F_EMP_ACCOUNT_4()
        {
            InitializeComponent();
        }

        private void b_edit_10_Click(object sender, EventArgs e)
        {

        }

        private void F_EMP_ACCOUNT_4_Load(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection();
            try
            {
                sqlconn.ConnectionString = connstr;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            SqlCommand sqlcmd1 = new SqlCommand();
            sqlcmd1.Connection = sqlconn;
            sqlcmd1.CommandText = "select id as 'رقم الموظف', username as ' اسم المستخدم' , password as ' كلمة المرور' , emp_name as 'اسم الموظف ' , id_emp as 'حالة الموظف' from SECURITY_LOGIN;";
            SqlDataAdapter sqladap = new SqlDataAdapter();
            sqladap.SelectCommand = sqlcmd1;
            DataTable mylist = new DataTable();
            try
            {
                sqlconn.Open();
                sqladap.Fill(mylist);
                dgv_4.DataSource = mylist;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlconn.Close();
            }
        }

        private void b_search_10_Click(object sender, EventArgs e)
        {
            if (b_edit_10.BackColor == Color.CadetBlue)
            {
                dgv_4.ReadOnly = false;
                b_edit_10.BackColor = Color.LightGray;
            }
            else if (b_edit_10.BackColor == Color.LightGray)
            {
                dgv_4.ReadOnly = true;
                b_edit_10.BackColor = Color.CadetBlue;
                int ID = Convert.ToInt32(dgv_4.CurrentRow.Cells[0].Value);


                SqlConnection sqlconn = new SqlConnection();
                try
                {
                    sqlconn.ConnectionString = connstr;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                try
                {
                    SqlCommand sqlcmd = new SqlCommand();
                    sqlcmd.Connection = sqlconn;
                    sqlcmd.CommandText = "UPDATE F_RESIDENTS_10 SET inmates_name = '" + dgv_4.CurrentRow.Cells[1].Value + "' , nationality = '" + dgv_4.CurrentRow.Cells[2].Value + "' , age = " + dgv_4.CurrentRow.Cells[3].Value + " , identification_number = " + dgv_4.CurrentRow.Cells[4].Value + " , telephone_number = " + dgv_4.CurrentRow.Cells[5].Value + " , wife_name = '" + dgv_4.CurrentRow.Cells[6].Value + "' , wife_identity_number = " + dgv_4.CurrentRow.Cells[7].Value + " , number_of_individuals = " + dgv_4.CurrentRow.Cells[8].Value + " , room_type = '" + dgv_4.CurrentRow.Cells[9].Value + "' , n_room = " + dgv_4.CurrentRow.Cells[10].Value + " , reservation_date = '" + dgv_4.CurrentRow.Cells[11].Value.ToString() + "' , reservation_expires = '" + dgv_4.CurrentRow.Cells[12].Value.ToString() + "' , Price = " + dgv_4.CurrentRow.Cells[13].Value + " where Id = " + ID + "";
                    sqlconn.Open();
                    sqlcmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sqlconn.Close();
                }

                try
                {
                    sqlconn.ConnectionString = connstr;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                SqlCommand sqlcmd1 = new SqlCommand();
                sqlcmd1.Connection = sqlconn;
                sqlcmd1.CommandText = "select id as 'رقم الموظف', username as ' اسم المستخدم' , password as ' كلمة المرور' , emp_name as 'اسم الموظف ' , id_emp as 'حالة الموظف' from SECURITY_LOGIN;";
                SqlDataAdapter sqladap = new SqlDataAdapter();
                sqladap.SelectCommand = sqlcmd1;
                DataTable mylist = new DataTable();
                try
                {
                    sqlconn.Open();
                    sqladap.Fill(mylist);
                    dgv_4.DataSource = mylist;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sqlconn.Close();
                }
            }
        }
    }
}
