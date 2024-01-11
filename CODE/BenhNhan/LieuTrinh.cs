using QLPHONGKHAM.Controls;
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
    public partial class LieuTrinh : Form
    {
        public SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PHONGKHAM_DBConnectionString"].ConnectionString);
        Connection connection;
        public DateTime selectedDateTime;

        public LieuTrinh(string benhnhan, string kehoach)
        {
            InitializeComponent();
            label1.Text = benhnhan;
            label2.Text = kehoach;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
        }

        private void LieuTrinh_Load(object sender, EventArgs e)
        {
           
            string query = "select BENHNHAN, KEHOACH, ID_DIEUTRI, MALOAIDIEUTRI, NHASI, NGAY,MOTA,GIA,TRANGTHAI from DIEUTRI DT where  DT.BENHNHAN = '" + label1.Text.ToString() + "' and DT.KEHOACH = '" +label2.Text.ToString()+ "'; ";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            selectedDateTime = dateTimePicker1.Value;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
            DataRowView selectedRow = (DataRowView)listBox1.SelectedItem;
            DataRowView selectedRow1 = (DataRowView)listBox2.SelectedItem;
            if (textBox2.Text.ToString() != "")
            {
                using (SqlCommand cmd = new SqlCommand("SP_THEMDIEUTRI", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@BENHNHAN", Convert.ToInt32(label1.Text));
                    cmd.Parameters.AddWithValue("@KEHOACH", Convert.ToInt32(label2.Text));
                    cmd.Parameters.AddWithValue("@NHASI", selectedRow1["ID"]);
                    cmd.Parameters.AddWithValue("@MALOAIDIEUTRI", Convert.ToInt32(selectedRow["MALOAIDIEUTRI"]));
                    cmd.Parameters.AddWithValue("@GIA", Convert.ToInt32(textBox2.Text.ToString()));
                    cmd.Parameters.AddWithValue("@MOTA", textBox1.Text.ToString());
                    cmd.Parameters.AddWithValue("@NGAY", selectedDateTime.ToString("MM/dd/yyyy"));
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Đã thêm liệu trình");
                }
            }
            
        }

        
    }
}
