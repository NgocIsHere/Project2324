using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPHONGKHAM
{
    public partial class ThongKe : Form
    {
        public string role;
        public ThongKe(String role)
        {
            InitializeComponent();
            this.role = role;
        }


        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem.ToString() == "Cuộc Hẹn")
            {
                load_cuochen();
            }    
            else
            {
                load_dieutri();
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home hm = new Home(role);
            this.Hide();
            hm.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            comboBox1.Items.Add("Cuộc Hẹn");
            comboBox1.Items.Add("Điều Trị");
        }

        private void load_cuochen()
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["PHONGKHAM_DBConnectionString"].ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_LOCCUOCHENTUNGAYDENNGAY", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@NGAYBATDAU", dateTimePickerStart.Value.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@NGAYKETTHUC", dateTimePickerEnd.Value.ToString("yyyy-MM-dd"));

                    try
                    {
                        connection.Open();

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            dataGridView1.DataSource = dataTable;

                            // Use the DataTable as the data source for the DataGridView
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void load_dieutri()
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["PHONGKHAM_DBConnectionString"].ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_LOCDIEUTRITUNGAYDENNGAY", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@NGAYBATDAU", dateTimePickerStart.Value.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@NGAYKETTHUC", dateTimePickerEnd.Value.ToString("yyyy-MM-dd"));
                    Debug.WriteLine(dateTimePickerStart.Value.ToString("yyyy-MM-dd"));
                    Debug.WriteLine(dateTimePickerEnd.Value.ToString("yyyy-MM-dd"));

                    try
                    {
                        connection.Open();

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            dataGridView1.DataSource = dataTable;

                            // Use the DataTable as the data source for the DataGridView
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
