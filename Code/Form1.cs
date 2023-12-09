using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Code
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["PHONGKHAM_DBConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string sqlQuery = null;
            if (textBox1.Text.ToString()[1] == 'V')
            {
                sqlQuery = "select MATKHAU from NHANVIEN NV where NV.ID = '" + textBox1.Text + "'";
                

            }
            else if (textBox1.Text.ToString()[1] == 'S')
            {
                sqlQuery = "select MATKHAU from NHASI NS where NS.ID = '" + textBox1.Text + "'";
            }
            else if (textBox1.Text.ToString()[1] == 'T')
            {
                sqlQuery = "select MATKHAU from QTV where QTV.ID = '" + textBox1.Text + "'";
                
            }
            else
            {
                MessageBox.Show("Sai định dạng Tên đăng nhập");
            }
            if (sqlQuery != null)
            {
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null)
                {
                    while (dr.Read())
                    {
                        if (textBox2.Text.ToString() == dr["MATKHAU"].ToString())
                        {
                            MessageBox.Show("Đăng nhập thành công", dr["MATKHAU"].ToString());
                            this.Hide();
                            Form2 neef = new Form2();
                            neef .Show();
                        }
                        else
                        {
                            MessageBox.Show("Mật khẩu không chính xác vui lòng nhập lại" + dr["MATKHAU"].ToString() + "." + textBox2.Text.ToString());
                        }

                    }
                }
            }
            
        }

        
    }
}
