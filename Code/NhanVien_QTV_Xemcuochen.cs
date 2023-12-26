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

namespace Code
{
    public partial class NhanVien_QTV_Xemcuochen : Form
    {
        private string TestID = "QTV00001";
        private bool  updatemode = false;
        public NhanVien_QTV_Xemcuochen()
        {
            InitializeComponent();
        }

        private void XemCuocHen_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = getAppointment().Tables[0];
        }

        DataSet getAppointment( )
        {
            DataSet data = new DataSet();
            string getAppointment = "EXEC SELECT_CUOC_HEN  "+TestID +" ";

            using (SqlConnection con = new SqlConnection(ConnectDB.connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(getAppointment, con);
                da.Fill(data);
            }

            return data;
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            string deleteAppointment = $"EXEC DELETE_CUOC_HEN " + dataGridView1.CurrentRow.Cells["ID"].Value + ", '"+ TestID + "'";
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectDB.connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(deleteAppointment, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                MessageBox.Show("xóa thành công");
            }
            catch (Exception)
            {
                MessageBox.Show("xóa thất bại");
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string addAppointment = $"EXEC ADD_APPOINTMENT "+textBoxch.Text+", '"+textBoxbn.Text+"', '"+textBoxNS.Text +"', '"+ngayhen.Value.ToString("yyyy-MM-dd") +"'," +
                " '"+giohen.Value.ToString("HH:mm:ss") +"', N'"+textBoxGC.Text +"', 0,"+(checkBoxTK.Checked == true ? "1" : "0")+", '"+ TestID + "'\r\n";
            Debug.WriteLine(addAppointment);
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectDB.connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(addAppointment, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                MessageBox.Show("thêm thành công");
                XemCuocHen_Load(sender, e);
            }
            catch (Exception)
            {
                MessageBox.Show("thêm thất bại");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBoxbn_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchAppointment = $"EXEC GET_CUOC_HEN_FROM_DATE '"+startday.Value.ToString("yyyy-MM-dd")+"', '"+enddate.Value.ToString("yyyy-MM-dd")+"', '"+ TestID + "'";
            Debug.WriteLine(searchAppointment);
            DataSet data = new DataSet();
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectDB.connectionString))
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(searchAppointment, con);
                    da.Fill(data); 
                    con.Close();
                }
                dataGridView1.DataSource = data.Tables[0];
            }
            catch (Exception)
            {
                MessageBox.Show("tìm kiếm thất bại");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count && updatemode)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    string IDAppointment = row.Cells["ID"].Value.ToString();
                    string IDBenhNhan = row.Cells["BENHNHAN"].Value.ToString();
                    string IDNhaSi = row.Cells["NHASI"].Value.ToString();
                    string Ngayhen = ((DateTime)row.Cells["NGAYHEN"].Value).Date.ToString("yyyy-MM-dd");
                    String Giohen = ((TimeSpan)row.Cells["GIOHEN"].Value).ToString(@"hh\:mm\:ss").Replace(" ", "");
                    string ghichu = row.Cells["GHICHU"].Value.ToString();
                    string trangthai = row.Cells["TRANGTHAI"].Value.ToString();
                    string taikham = row.Cells["LATAIKHAM"].Value.ToString();


                    textBoxch.Text = IDAppointment;
                    textBoxbn.Text = IDBenhNhan;
                    textBoxNS.Text = IDNhaSi;
                    ngayhen.Text = Ngayhen;
                    giohen.Text = Giohen;
                    textBoxGC.Text = ghichu;
                    checkBoxtrangthai.Checked = (trangthai == "1" ? true : false);
                    checkBoxTK.Checked = (taikham == "1" ? true : false);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void buttonupdate_Click(object sender, EventArgs e)
        {
            if (updatemode)
            {
                string updatequery = "EXEC ALTER_APPOINTMENT " + textBoxch.Text + ", '" + textBoxbn.Text + "', '" + textBoxNS.Text + "', '" + ngayhen.Value.ToString("yyyy-MM-dd") + "'," +
                    " '" + giohen.Value.ToString("HH:mm:ss") + "', N'" + textBoxGC.Text + "', " + (checkBoxtrangthai.Checked == true ? 1 : 0) + "," + (checkBoxTK.Checked == true ? "1" : "0") + ", '" + TestID + "'\r\n";
                Debug.WriteLine(updatequery);
                try
                {
                    using (SqlConnection con = new SqlConnection(ConnectDB.connectionString))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand(updatequery, con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    MessageBox.Show("Cập nhật thành công");

                    textBoxch.Text = "";
                    textBoxbn.Text = "";
                    textBoxNS.Text = "";
                    ngayhen.Text = "";
                    giohen.Text = "";
                    textBoxGC.Text = "";
                    checkBoxtrangthai.Checked = false;
                    checkBoxTK.Checked =false;

                    XemCuocHen_Load(sender, e);
                }
                catch (Exception)
                {
                    MessageBox.Show("Cập nhật thất bại");
                }
            }
            updatemode = !updatemode;
        }
    }
}
