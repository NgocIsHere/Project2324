using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code
{
    public partial class QuanLyBenhNhan : Form
    {
        public SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PHONGKHAM_DBConnectionString"].ConnectionString);

        public QuanLyBenhNhan()
        {
            InitializeComponent();
        }

        private void QuanLyBenhNhan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pHONGKHAM_DBDataSet.BENHAN' table. You can move, or remove it, as needed.
            this.bENHANTableAdapter.Fill(this.pHONGKHAM_DBDataSet.BENHAN);
            // TODO: This line of code loads data into the 'pHONGKHAM_DBDataSet.BENHAN' table. You can move, or remove it, as needed.
            this.bENHANTableAdapter.Fill(this.pHONGKHAM_DBDataSet.BENHAN);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string number = "select count(*) from NHASI";
            string sql = "insert into [BENHAN] values (@ID, @HOTEN, @NGAYSINH, @DIACHI, @SDT, @GIOITINH, @THONGTINTONGQUAN, @TINHTRANGDIUNG);";
            SqlCommand commandCount = new SqlCommand(number, con);
            int count = (int)commandCount.ExecuteScalar() + 1;
            using (var cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@ID", "BN"+ count.ToString("D6"));
                cmd.Parameters.AddWithValue("@HOTEN", textBox2.Text.ToString());
                cmd.Parameters.AddWithValue("@NGAYSINH", dateTimePicker1.Value.ToString("MM/dd/yyyy"));
                cmd.Parameters.AddWithValue("@DIACHI", textBox3.Text.ToString());
                cmd.Parameters.AddWithValue("@SDT", textBox4.Text.ToString());
                cmd.Parameters.AddWithValue("@GIOITINH", listBoxGender.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@THONGTINTONGQUAN", " ");
                cmd.Parameters.AddWithValue("@TINHTRANGDIUNG", " ");
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Đã thêm bệnh nhân!");
            con.Close();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "select ID, HOTEN, NGAYSINH, DIACHI, SDT, GIOITINH from BENHAN BN where BN.HOTEN LIKE  N'%"+ textBox1.Text.ToString()+"%'; ";
            con.Open();
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
            {
                // Create a new DataTable
                DataTable dataTable = new DataTable();

                // Fill the DataTable with the results of the query
                adapter.Fill(dataTable);

                // Set the DataGridView's DataSource to the DataTable
                dataGridView1.DataSource = dataTable;
            }
            con.Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox5.Text.ToString()!=null)
            {
                con.Open();
                string query = "SELECT ID, HOTEN, NGAYSINH, DIACHI, SDT, GIOITINH FROM BENHAN BN WHERE BN.ID = '" + textBox5.Text.ToString() + "';";
                SqlCommand command = new SqlCommand(query, con);
                object data = command.ExecuteScalar();
                if (data != null)
                {
                    this.Hide();
                    BenhNhan newinterf = new BenhNhan(textBox5.Text.ToString());
                    newinterf.Show();
                }
                else
                {
                    MessageBox.Show("Không có bệnh nhân có ID " + textBox5.Text.ToString());
                }
                con.Close();
            }
            

        }
    }
}
