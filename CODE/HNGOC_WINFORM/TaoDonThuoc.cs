using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLPHONGKHAM.Controls;

namespace QLPHONGKHAM
{
    public partial class TaoDonThuoc : Form
    {
        Connection connection;
        Util util;
        public static string idThuocSelectedGlobal { get; set; }

        //Dictionary mapping with combo box value
        private Dictionary<string, string> thuocDictionary = new Dictionary<string, string>();

        //DanhSachThuoc dsThuoc;
        public TaoDonThuoc()
        {
            InitializeComponent();
            connection = new Connection();
            util = new Util();
        }
        private void TaoDonThuoc_Load(object sender, EventArgs e)
        {
            loadThongTinBenhAn();
            maDonThuocBox.Text = DonThuoc.idDonThuocGlobal;
            xoaThuocButton.Enabled = false;
            loadChiTietDon();
        }
       
        void loadThongTinBenhAn()
        {
            this.tenBenhNhanBox.Text = DonThuoc.hoTen;
            this.sdtBox.Text = DonThuoc.sdt;
            this.ngaySinhBox.Value = Convert.ToDateTime(DonThuoc.ngaySinh);

            if (DonThuoc.gioiTinh == "Nam")
            {
                this.namRadioButton.Checked = true;
                this.nuRadioButton.Checked = false;
            }
            else if (DonThuoc.gioiTinh == "Nữ")
            {
                this.nuRadioButton.Checked = true;
                this.namRadioButton.Checked = false;
            }

            this.tinhTrangDiUngBox.Text = DonThuoc.tinhTrangDiUng;
            this.thongTinTongQuanBox.Text = DonThuoc.thongTinTongQuan;
            this.diaChiBox.Text = DonThuoc.diaChi;
            this.ngayKeDonBox.Value = Convert.ToDateTime(DonThuoc.ngayKeDon);
        }
        void loadChiTietDon()
        {
            connection.connect();
            SqlParameter[] paras =
            {
                new SqlParameter("@ID_DON", SqlDbType.VarChar){Value = DonThuoc.idDonThuocGlobal},
                new SqlParameter("@ID_BENHAN", SqlDbType.Char){Value = DonThuoc.idBenhAn},
            };
            chiTietDonTable.DataSource = connection.dataTableWithParams("SP_XEMCHITIETDON", paras);
        }

        private void TenThuocComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = TenThuocComboBox.SelectedItem.ToString();
            if (thuocDictionary.ContainsKey(selected))
            {
                idThuocSelectedGlobal = thuocDictionary[selected];
                //MessageBox.Show(idThuocSelectedGlobal);
            }
        }

        void loadComboBoxData()
        {
            connection.connect();
            DataTable dataTable = connection.dataTable("EXEC SP_XEMDANHSACHTHUOC");
            TenThuocComboBox.Items.Clear();
            thuocDictionary.Clear();

            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    string idThuoc = row["ID_THUOC"].ToString();
                    string tenThuoc = row["TENTHUOC"].ToString();
                    string soLuong = row["SOLUONG"].ToString();
                    string donVi = row["DONVI"].ToString();

                    string formattedString = $"{tenThuoc} - Kho: {soLuong} ({donVi})";
                    TenThuocComboBox.Items.Add(formattedString);
                    thuocDictionary.Add(formattedString, idThuoc);
                }
            }
            else
            {
                // Handle case when no data is retrieved
                TenThuocComboBox.Items.Add("Không có thuốc");
            }
        }
        private void TenThuocComboBox_Click(object sender, EventArgs e)
        {
            loadComboBoxData();
        }

        private void themThuocButton_Click(object sender, EventArgs e)
        {
            if (idThuocSelectedGlobal != null && soLuongThuocBox.Text != null)
            {
                connection.connect();
                SqlParameter[] paras =
                {
                    new SqlParameter("@ID_DON", SqlDbType.VarChar){Value = DonThuoc.idDonThuocGlobal},
                    new SqlParameter("@ID_BENHAN", SqlDbType.Char){Value = DonThuoc.idBenhAn},
                    new SqlParameter("@ID_THUOC", SqlDbType.VarChar){Value = idThuocSelectedGlobal},
                    new SqlParameter("@SOLUONG", SqlDbType.Int){Value = Convert.ToInt16(soLuongThuocBox.Text)},
                };

                int status = connection.ExecuteStoredProcedureWithParams("SP_THEMCHITIETDON", paras);
                if (status == 0)
                {
                    //MessageBox.Show("THÊM THUỐC THÀNH CÔNG");
                    loadChiTietDon();
                }
                else if (status == -3)
                {
                    MessageBox.Show("ĐÃ TỒN TẠI THUỐC TRONG ĐƠN, KHÔNG THỂ THÊM");
                }
                else if (status == -4)
                {
                    MessageBox.Show("SỐ LƯỢNG TRONG KHO KHÔNG ĐỦ");
                }
                else if (status == -5)
                {
                    MessageBox.Show("SỐ LƯỢNG KHÔNG HỢP LỆ");
                }
            }
            else
            {
                MessageBox.Show("ĐIỀN ĐẦY ĐỦ THÔNG TIN ĐỂ THÊM THUỐC VÀO ĐƠN");
            }
        }

        private void chiTietDonTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            xoaThuocButton.Enabled = true;

            DataGridViewRow row = new DataGridViewRow();
            row = chiTietDonTable.Rows[e.RowIndex];

            //Binding data
            this.soLuongThuocBox.Text = Convert.ToString(row.Cells["SOLUONG"].Value);

            string idThuocFromGrid = row.Cells["ID_THUOC"].Value.ToString();

            loadComboBoxData();
            // Check if the ID_THUOC exists as a key in the dictionary and assign it to combo box
            if (thuocDictionary.ContainsValue(idThuocFromGrid))
            {
                var selectedItem = thuocDictionary.FirstOrDefault(x => x.Value == idThuocFromGrid);
                if (!string.IsNullOrEmpty(selectedItem.Key))
                {
                    TenThuocComboBox.SelectedItem = selectedItem.Key;
                    idThuocSelectedGlobal = selectedItem.Value;
                    //MessageBox.Show(idThuocSelectedGlobal);
                }
            }
        }

        private void xoaThuocButton_Click(object sender, EventArgs e)
        {
            if (idThuocSelectedGlobal != null && soLuongThuocBox.Text != null)
            {
                connection.connect();
                SqlParameter[] paras =
                {
                    new SqlParameter("@ID_DON", SqlDbType.VarChar){Value = DonThuoc.idDonThuocGlobal},
                    new SqlParameter("@ID_BENHAN", SqlDbType.Char){Value = DonThuoc.idBenhAn},
                    new SqlParameter("@ID_THUOC", SqlDbType.VarChar){Value = idThuocSelectedGlobal}
                };
                int status = connection.ExecuteStoredProcedureWithParams("SP_XOACHITIETDON", paras);
                if (status == 0)
                {
                    MessageBox.Show("XÓA THUỐC THÀNH CÔNG");
                    loadChiTietDon();
                }
            }
            else
            {
                MessageBox.Show("THIẾU THÔNG TIN ĐỂ XÓA THUỐC");
            }
        }

        private void TaoDonThuoc_FormClosed(object sender, FormClosedEventArgs e)
        {
            bool hasData = chiTietDonTable.Rows.Cast<DataGridViewRow>().Any(row => !row.IsNewRow);

            if (!hasData)
            {
                // No rows in DataGridView, call the SP_XOADONTHUOC stored procedure
                connection.connect();
                SqlParameter[] paras =
                {
                    new SqlParameter("@ID_DON", SqlDbType.VarChar){Value = DonThuoc.idDonThuocGlobal},
                    new SqlParameter("@ID_BENHAN", SqlDbType.Char){Value = DonThuoc.idBenhAn},
                };

                int status = connection.ExecuteStoredProcedureWithParams("SP_XOADONTHUOC", paras);
                if (status == 0)
                {

                    idThuocSelectedGlobal = null;
                    DonThuoc.idDonThuocGlobal = null;
                    MessageBox.Show("ĐÃ HỦY ĐƠN THUỐC DO KHÔNG CÓ THUỐC TRONG ĐƠN");
                }
                else
                {
                    MessageBox.Show("KHÔNG THỂ XÓA ĐƠN THUỐC");
                }
            }
        }

        private void hoanThanhButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void huyButton_Click(object sender, EventArgs e)
        {
            SqlParameter[] paras =
                {
                    new SqlParameter("@ID_DON", SqlDbType.VarChar){Value = DonThuoc.idDonThuocGlobal},
                    new SqlParameter("@ID_BENHAN", SqlDbType.Char){Value = DonThuoc.idBenhAn},
                };
            int status = connection.ExecuteStoredProcedureWithParams("SP_XOADONTHUOC", paras);
            if (status == 0)
            {
                MessageBox.Show("ĐÃ XÓA ĐƠN THUỐC");
                this.Close();
            }
            else 
            {
                MessageBox.Show("LỖI XÓA ĐƠN THUỐC");
            }
        }
    }
}
