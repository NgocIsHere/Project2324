using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace QLPHONGKHAM.Controls
{
    public partial class BenhNhan : UserControl
    {
        public SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PHONGKHAM_DBConnectionString"].ConnectionString);
        string name, address, phone, gender;
        DateTime birth;
        public string bnID;

        public BenhNhan()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
 

        private void BenhNhan_Load_1(object sender, EventArgs e)
        {
            string query = "select HOTEN, NGAYSINH, DIACHI, SDT, GIOITINH from BENHAN where ID =" + bnID;
            con.Open();
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
            {
                // Create a new DataTable
                DataTable dataTable = new DataTable();

                // Fill the DataTable with the results of the query
                adapter.Fill(dataTable);

                // Set the DataGridView's DataSource to the DataTable
                DataRow selectedRow = dataTable.Rows[0];
                name = selectedRow["HOTEN"].ToString();
                birth = (DateTime)selectedRow["NGAYSINH"];
                address = selectedRow["DIACHI"].ToString();
                phone = selectedRow["SDT"].ToString();
                gender = selectedRow["GIOITINH"].ToString();
                // Update TextBoxes
                hoten.Text = name;
                ngaysinh.Text = birth.ToString("MM/dd/yyyy");
                diachi.Text = address;
                sdt.Text = phone;
                gioitinh.Text = gender;

            }

            con.Close();
        }

        private void hoten_TextChanged(object sender, EventArgs e)
        {

        }

        private void ngaysinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            con.Open();
            string updateQuery = "UPDATE BENHAN SET HOTEN = @HOTEN, NGAYSINH = @NGAYSINH, DIACHI =@DIACHI, SDT=@SDT, GIOITINH=@GIOITINH" +
                    " WHERE ID ="+ bnID;
            SqlCommand command = new SqlCommand(updateQuery, con);
            command.Parameters.AddWithValue("@HOTEN", hoten.Text.ToString());
            command.Parameters.AddWithValue("@NGAYSINH", ngaysinh.Text.ToString());
            command.Parameters.AddWithValue("@DIACHI", diachi.Text.ToString());
            command.Parameters.AddWithValue("@SDT", sdt.Text.ToString());
            command.Parameters.AddWithValue("@GIOITINH", gioitinh.Text.ToString());
            command.ExecuteNonQuery();
            MessageBox.Show("Đã cập nhật thay đổi!");
            con.Close();
        }
    }
}
