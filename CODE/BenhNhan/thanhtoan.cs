using QLPHONGKHAM;
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

namespace QLPHONGKHAM
{
    public partial class thanhtoan : UserControl
    {
        public SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PHONGKHAM_DBConnectionString"].ConnectionString);
        public string idBN;
        public thanhtoan()
        {
            InitializeComponent();
        }

        private void thanhtoan_Load(object sender, EventArgs e)
        {
            con.Open();
            using (SqlCommand command = new SqlCommand("SP_DANHSACHCANTHANHTOAN", con))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@BENHNHAN", idBN);
                DataTable dataTable = new DataTable();
                // Use SqlDataAdapter to fill the DataTable
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(dataTable); 
                    dataGridView1.DataSource = dataTable;
                    listBox1.DataSource = dataTable;
                    listBox1.DisplayMember = "ID_DIEUTRI";
                }
            }
            using (SqlCommand command = new SqlCommand("SP_DANHSACHDATHANHTOAN", con))
            {
                command.CommandType = CommandType.StoredProcedure;
                // Add parameters
                command.Parameters.AddWithValue("@BENHNHAN", idBN);
                DataTable dataTable = new DataTable();
                // Use SqlDataAdapter to fill the DataTable
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(dataTable); // Fill with data from the stored procedure
                    dataGridView2.DataSource = dataTable;
                }
            }
            using(SqlCommand command = new SqlCommand("SP_THANHTOAN", con)) { }
            using (SqlCommand command = new SqlCommand("SP_TTCANTHANHTOAN", con))
            {
                command.CommandType = CommandType.StoredProcedure;
                // Add parameters
                command.Parameters.AddWithValue("@BENHNHAN", idBN);
                command.Parameters.Add("@tongtien", SqlDbType.Int).Direction = ParameterDirection.Output;
                command.ExecuteNonQuery();
                if(command.Parameters["@tongtien"].Value.ToString() != "")
                {
                    label12.Text = command.Parameters["@tongtien"].Value.ToString();
                }
            }
            using (SqlCommand command = new SqlCommand("SP_TTDATHANHTOAN", con))
            {
                command.CommandType = CommandType.StoredProcedure;
                // Add parameters
                command.Parameters.AddWithValue("@BENHNHAN", idBN);
                command.Parameters.Add("@tongtien", SqlDbType.Int).Direction = ParameterDirection.Output;
                command.ExecuteNonQuery();
                string tt = command.Parameters["@tongtien"].Value.ToString();
                if (tt != "")
                {
                    label11.Text = tt;
                }
            }
            con.Close();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            int tiennhan = Convert.ToInt32(textBox1.Text.ToString());
            int tongtien = Convert.ToInt32(label12.Text.ToString());
            DataRowView selectedRow = (DataRowView)listBox1.SelectedItem;
            if (checkBox1.Checked)
            {
                if (tiennhan< tongtien)
                {
                    MessageBox.Show("Số tiền không đủ thanh toán tất cả điều trị");
                }
                else
                {
                    using (SqlCommand command = new SqlCommand("SP_THANHTOANTATCA", con))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        // Add parameters
                        command.Parameters.AddWithValue("@BENHNHAN", idBN);
                        command.Parameters.AddWithValue("@TIENNHAN", textBox1.Text.ToString());
                        command.ExecuteNonQuery();
                        MessageBox.Show(" Đã thanh toán tất cả");
                    }
                }
                
            }
            else
            {
                if (selectedRow["ID_DIEUTRI"].ToString() != "")
                {
                    int gia;
                    using (SqlCommand command = new SqlCommand("SP_GIADIEUTRI", con))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        // Add parameters
                        command.Parameters.AddWithValue("@DIEUTRI", Convert.ToInt32(selectedRow["ID_DIEUTRI"]));
                        command.Parameters.Add("@GIA", SqlDbType.Int).Direction = ParameterDirection.Output;
                        command.ExecuteNonQuery();
                        gia = Convert.ToInt32(command.Parameters["@GIA"].Value.ToString());
                    }
                    if (tiennhan < gia)
                    {
                        MessageBox.Show("Số tiền không đủ thanh toán điều trị " + selectedRow["ID_DIEUTRI"].ToString());
                    }
                    else
                    {
                        using (SqlCommand command = new SqlCommand("SP_THANHTOANDT", con))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            // Add parameters
                            command.Parameters.AddWithValue("@DIEUTRI", Convert.ToInt32(selectedRow["ID_DIEUTRI"]));
                            command.Parameters.AddWithValue("@TIENNHAN", textBox1.Text.ToString());
                            command.ExecuteNonQuery();
                            MessageBox.Show(" Đã thanh toán" + selectedRow["ID_DIEUTRI"].ToString());
                        }
                    }
              
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn thanh toán");
                }
            }
            con.Close();
        }
    }
}
