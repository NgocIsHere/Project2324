using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Code
{
    public partial class Appointment : Form
    {
        private string UserID = "NV000001";
        private bool updatemode = true;
        public Appointment()
        {
            InitializeComponent();
        }

        private void XemCuocHen_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            if (UserID.Substring(0,2) == "NS")
            {
                dateTimePickergio.Enabled = false;
                dateTimePickerngay.Enabled = false;
                textBoxBN.Enabled = false;
                comboBoxNS.Enabled = false;
                comboBoxTrangThai.Enabled = false;
                comboBoxphong.Enabled = false;
                buttonupdate.Enabled = false;
            }


            getAppointment();
            loadDentistNameID();
            loadLocCombobox();
            loadtrangthaiComboBox();
            loadPhongCombobox();
        }
        private void loadPhongCombobox()
        {
            comboBoxphong.Items.Add(1);
            comboBoxphong.Items.Add(2);
            comboBoxphong.Items.Add(3);
            comboBoxphong.Items.Add(4);
            comboBoxphong.Items.Add(5);
            comboBoxphong.Items.Add(6);
            comboBoxphong.Items.Add(7);

        }
        private void loadtrangthaiComboBox()
        {
            comboBoxTrangThai.Items.Add("Cuộc Hẹn Mới");
            comboBoxTrangThai.Items.Add("Tái Khám");
        }
        private void loadLocCombobox()
        {
            comboBoxLoc.Items.Add("Bệnh Nhân");
            comboBoxLoc.Items.Add("Nha Sĩ");
            comboBoxLoc.Items.Add("Phòng");
            comboBoxLoc.Items.Add("None");
        }

        private void loadDentistNameID()
        {
            using (SqlConnection connection = new SqlConnection(ConnectDB.connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_LAYTENVAIDNHASI", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                comboBoxNS.Items.Add(reader.GetString(0)+" - "+ reader.GetString(1));
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void getAppointment()
        {
            string datenow = (DateTime.Now).ToString("yyyy-MM-dd");
            using (SqlConnection connection = new SqlConnection(ConnectDB.connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_XEMDANHSACHCUOCHEN", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@NGAYHEN", datenow);

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

        private void comboBoxLoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = comboBoxLoc.SelectedItem.ToString();

            if (selectedItem != "None")
            {
                buttonsearch.Visible = true;
                textBoxLoc.Visible = true;
            }
            else
            {
                buttonsearch.Visible = false;
                textBoxLoc.Visible = false;
                getAppointment();
            } 
                
        }

        private void buttonsearch_Click(object sender, EventArgs e)
        {

            string proc = "";
            
            if (comboBoxLoc.SelectedItem.ToString() == "Bệnh Nhân")
            {
                proc = "SP_LOCUOCHENTHEOBENHNHAN";
            }
            else if (comboBoxLoc.SelectedItem.ToString() == "Nha Sĩ")
            {
                proc = "SP_LOCCUOCHENTHEONHASI";
            }    
            else if (comboBoxLoc.SelectedItem.ToString() == "Phòng")
            {
                proc = "SP_LOCUOCHENTHEOPHONGKHAM";
            }
  

            using (SqlConnection connection = new SqlConnection(ConnectDB.connectionString))
            {
                using (SqlCommand command = new SqlCommand(proc, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    try
                    {
                        if (comboBoxLoc.SelectedItem.ToString() == "Bệnh Nhân")
                        {
                            command.Parameters.AddWithValue("@TENBENHNHAN", textBoxLoc.Text);
                        }
                        else if (comboBoxLoc.SelectedItem.ToString() == "Nha Sĩ")
                        {
                            command.Parameters.AddWithValue("@ID", textBoxLoc.Text);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@PHONG", int.Parse(textBoxLoc.Text));
                        }
                        command.Parameters.AddWithValue("@NGAYHEN", (DateTime.Now).ToString("yyyy-MM-dd"));
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
                    catch(Exception)
                    {
                        MessageBox.Show("Vui Lòng Nhập đúng dạng dữ liệu");
                    }

                    
                   
                }
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "TRANGTHAI")
            {
                if (e.Value != null)
                {
                    switch (e.Value)
                    {
                        case 1:
                            e.Value = "Tái Khám";
                            e.FormattingApplied = true;
                            break;
                        case 0:
                            e.Value = "Cuộc Hẹn Mới";
                            e.FormattingApplied = true;
                            break;
                    }
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
             {
                if (e.RowIndex >= 0 && (e.RowIndex < dataGridView1.Rows.Count) && updatemode)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    string IDcuochen = row.Cells["ID"].Value.ToString();
                    string tenBenhNhan = row.Cells["HOTEN"].Value.ToString();
                    string TENVAIDNhaSi = row.Cells["NHASI"].Value.ToString();
                    //string tenNhaSi = TENVAIDNhaSi[1].Trim();
                    string Ngayhen = ((DateTime)row.Cells["NGAYHEN"].Value).Date.ToString("yyyy-MM-dd");
                    String Giohen = ((TimeSpan)row.Cells["GIOHEN"].Value).ToString(@"hh\:mm\:ss").Replace(" ", "");
                    string trangthai = row.Cells["TRANGTHAI"].Value.ToString();
                    string phong = row.Cells["PHONG"].Value.ToString();
                    /*Debug.WriteLine(IDcuochen + " " + tenBenhNhan + " " + TENVAIDNhaSi + " " + Ngayhen + " " + Giohen
                        + " " + phong + " " + trangthai);*/


                    textBoxmach.Text = IDcuochen;
                    textBoxBN.Text = tenBenhNhan;
                    comboBoxphong.SelectedItem = int.Parse(phong) ;
                    dateTimePickergio.Text = Giohen;
                    dateTimePickerngay.Text = Ngayhen;
                    foreach (var item in comboBoxNS.Items)
                    {
                        if(item.ToString().StartsWith(TENVAIDNhaSi))
                        {
                            comboBoxNS.SelectedItem = item;
                            break; 
                        }
                    }

                    comboBoxTrangThai.SelectedIndex = int.Parse(trangthai);

                }
            }
             catch (Exception )
             {
                Debug.WriteLine(e.RowIndex + " " + dataGridView1.Rows.Count);
                MessageBox.Show("no value found");
            }
        }

        private void buttonupdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ConnectDB.connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_CAPNHATCUOCHEN", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add(new SqlParameter("@ID", textBoxmach.Text));
                    command.Parameters.Add(new SqlParameter("@NGAYHEN", dateTimePickerngay.Value.ToString("yyyy-MM-dd")));
                    command.Parameters.Add(new SqlParameter("@GIOHEN", dateTimePickergio.Value.ToString("HH:mm:ss")));
                    command.Parameters.Add(new SqlParameter("@NHASI", comboBoxNS.SelectedItem.ToString().Substring(comboBoxNS.SelectedItem.ToString().Length - 8)));
                    command.Parameters.Add(new SqlParameter("@PHONG", comboBoxphong.SelectedItem));

                    try 
                    { 
                        connection.Open();
                        command.ExecuteNonQuery();
                        getAppointment();
                    } 
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AppointmentRequest form = new AppointmentRequest();
            this.Hide();
            form.ShowDialog();
        }

       
    }
}
