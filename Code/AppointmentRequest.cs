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

namespace Code
{
    public partial class AppointmentRequest : Form
    {
        private bool newPatient = false;
        public AppointmentRequest()
        {
            InitializeComponent();
        }

        private void AppointmentRequest_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            loadPhongCombobox();
            loadDentistNameID();
            loadtrangthaiComboBox();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string patientID = textBoxBN.Text;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectDB.connectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_TIMBENHNHAN", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ID", patientID);

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Assuming the data you want is in the first column of the result set
                                textBoxName.Text = reader[0].ToString();
                                textBoxNumber.Text = reader[1].ToString();
                                textBoxAddress.Text = reader[2].ToString();
                                textBoxMail.Text = reader[3].ToString();
                                dateTimePickerBirth.Text = reader[4].ToString();
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 

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
                                comboBoxNS.Items.Add(reader.GetString(0) + " - " + reader.GetString(1));
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

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            textBoxName.Enabled = !textBoxName.Enabled;
            textBoxNumber.Enabled = !textBoxNumber.Enabled;
            textBoxAddress.Enabled = !textBoxAddress.Enabled;
            textBoxMail.Enabled = !textBoxMail.Enabled;
            dateTimePickerBirth.Enabled = !dateTimePickerBirth.Enabled;
            newPatient = !newPatient;
        }
        private void getAppointmentRequest()
        {
            using (SqlConnection connection = new SqlConnection(ConnectDB.connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_XEMYEUCAUHEN", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@NGAYHEN", dateTimePickerngay.Value.ToString("yyyy-MM-dd"));

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

        private void dateTimePickerngay_ValueChanged(object sender, EventArgs e)
        {
            getAppointmentRequest();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Appointment appointment = new Appointment();
            this.Hide();
            appointment.ShowDialog();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            addAppointment();
            getAppointmentRequest();
            
        }
        private void addPatient()
        {
            using (SqlConnection connection = new SqlConnection(ConnectDB.connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_THEMBENHNHAN", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@HOTEN", textBoxName.Text));
                    command.Parameters.Add(new SqlParameter("@NGAYSINH", dateTimePickerBirth.Value.ToString("yyyy-MM-dd")));
                    command.Parameters.Add(new SqlParameter("@DIACHI", textBoxAddress.Text));
                    command.Parameters.Add(new SqlParameter("@EMAIL", textBoxMail.Text));
                    command.Parameters.Add(new SqlParameter("@SDT", textBoxNumber.Text));

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                textBoxBN.Text = reader[0].ToString();
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
        private void addAppointment()
        {
            using (SqlConnection connection = new SqlConnection(ConnectDB.connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_THEMCUOCHEN", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@NGAYHEN", dateTimePickerngay.Value.ToString("yyyy-MM-dd")));
                    command.Parameters.Add(new SqlParameter("@GIOHEN", DateTime.Now.ToString("HH:mm:ss")));
                    command.Parameters.Add(new SqlParameter("@NHASI", comboBoxNS.SelectedItem.ToString().Substring(comboBoxNS.SelectedItem.ToString().Length - 8)));
                    command.Parameters.Add(new SqlParameter("@BENHNHAN", textBoxBN.Text));
                    command.Parameters.Add(new SqlParameter("@GHICHU", textBoxGC.Text));
                    command.Parameters.Add(new SqlParameter("@TRANGTHAI", comboBoxTrangThai.SelectedIndex));
                    command.Parameters.Add(new SqlParameter("@PHONG", comboBoxphong.SelectedItem.ToString()));



                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();

                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(newPatient)
                addPatient();
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ConnectDB.connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_XOACUOCHENTHEONGAYGIOBENHNHANGHICHU", connection))
                {
                    string hoten = dataGridView1.CurrentRow.Cells["HOTEN"].Value.ToString();
                    string ngayhen = ((DateTime)dataGridView1.CurrentRow.Cells["NGAYHEN"].Value).ToString("yyyy-MM-dd");
                    string giohen = dataGridView1.CurrentRow.Cells["GIOHEN"].Value.ToString();
                    string ghichu = dataGridView1.CurrentRow.Cells["GHICHU"].Value.ToString();
                    Debug.WriteLine(hoten + ngayhen + giohen + ghichu);
                    //DateTime Ngayhen = dataGridView1.CurrentRow.Cells[].Value;

                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@NGAYHEN", ngayhen));
                    command.Parameters.Add(new SqlParameter("@GIOHEN", giohen));
                    command.Parameters.Add(new SqlParameter("@TENBENHNHAN", hoten));
                    command.Parameters.Add(new SqlParameter("@GHICHU", ghichu));


                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        getAppointmentRequest();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void comboBoxNS_SelectedIndexChanged(object sender, EventArgs e)
        {
                
        }

        private void autoUpdateNhasi()
        {
            if (!newPatient)
            {
                using (SqlConnection connection = new SqlConnection(ConnectDB.connectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_TIMNHASIMACDINH", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@BENHNHAN", textBoxBN.Text));
                        try
                        {
                            connection.Open();
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    foreach (var item in comboBoxNS.Items)
                                    {
                                        if (item.ToString().EndsWith(reader[0].ToString()))
                                        {
                                            comboBoxNS.SelectedItem = item;
                                            break;
                                        }
                                    }

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
        }

        private void textBoxBN_TextChanged(object sender, EventArgs e)
        {
            autoUpdateNhasi();
        }
    }
}
