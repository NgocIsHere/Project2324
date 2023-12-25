using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Code
{
    public partial class DangNhap : Form
    {
        public SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PHONGKHAM_DBConnectionString"].ConnectionString);
        public DangNhap()
        {
            InitializeComponent();
        }

        private void userId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string sqlQuery = null;
            string home = null;
            if (userId.Text.ToString()[1] == 'V')
            {
                sqlQuery = "select MATKHAU from NHANVIEN NV where NV.ID = '" + userId.Text + "'";
                home = "NV";
            }
            else if (userId.Text.ToString()[1] == 'S')
            {
                sqlQuery = "select MATKHAU from NHASI NS where NS.ID = '" + userId.Text + "'";
                home = "NS";
            }
            else if (userId.Text.ToString()[1] == 'T')
            {
                sqlQuery = "select MATKHAU from QTV where QTV.ID = '" + userId.Text + "'";
                home = "QTV";
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
                        if (password.Text.ToString() == dr["MATKHAU"].ToString())
                        {
                            MessageBox.Show("Đăng nhập thành công", dr["MATKHAU"].ToString());
                            this.Hide();
                            con.Close();
                            if (home == "NV")
                            {
                                HomeNV  interf = new HomeNV();
                                interf.Show();
                            }
                            else if(home == "NS")
                            {
                                HomeNS interf = new HomeNS();
                                interf.Show();
                            }
                            else
                            {
                                HomeQTV interf = new HomeQTV();
                                interf.Show();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Mật khẩu không chính xác vui lòng nhập lại" + dr["MATKHAU"].ToString() + "." + password.Text.ToString());
                        }

                    }
                    
                }
          
            }

        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangKy neef = new DangKy();
            neef.Show();
        }
    }
}
