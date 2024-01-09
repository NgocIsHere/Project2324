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
            loadDanhSachThuoc();
        }

        void loadThongTinBenhAn()
        {
            this.tenBenhNhanBox.Text = DonThuoc.hoTen;
            this.sdtBox.Text = DonThuoc.sdt;
            this.ngaySinhBox.Value = Convert.ToDateTime(DonThuoc.ngaySinh);

            if (DonThuoc.gioiTinh == "Male")
            {
                this.namRadioButton.Checked = true;
                this.nuRadioButton.Checked = false;
            }
            else if (DonThuoc.gioiTinh == "Female")
            {
                this.nuRadioButton.Checked = true;
                this.namRadioButton.Checked = false;
            }

            this.tinhTrangDiUngBox.Text = DonThuoc.tinhTrangDiUng;
            this.thongTinTongQuanBox.Text = DonThuoc.thongTinTongQuan;
            this.diaChiBox.Text = DonThuoc.diaChi;
            this.ngayKeDonBox.Value = Convert.ToDateTime(DonThuoc.ngayKeDon);
        }

        void loadDanhSachThuoc()
        {
            connection.connect();
            searchThuocTable.DataSource = connection.dataTable("EXEC SP_XEMDSTHUOC");
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
                    new SqlParameter("@GHICHU", SqlDbType.NVarChar){Value = this.ghiChuThuocBox.Text},
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
            this.tenThuocBox.Text = row.Cells["TENTHUOC"].Value.ToString();
            this.ghiChuThuocBox.Text = row.Cells["GHICHU"].Value.ToString();
            idThuocSelectedGlobal = row.Cells["ID_THUOC"].Value.ToString();
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

        private void soLuongThuoc1_Click(object sender, EventArgs e)
        {

        }

        private void searchThuocButton_Click(object sender, EventArgs e)
        {
            if (this.searchThuocBox.Text != null && this.searchThuocBox.Text != "")
            {
                connection.connect();
                SqlParameter[] paras = {
                    new SqlParameter("@TENTHUOC", SqlDbType.NVarChar) { Value = this.searchThuocBox.Text }
                };
                this.searchThuocTable.DataSource = connection.dataTableWithParams("SP_TIMTHUOCTHEOTEN", paras);
            }
        }

        private void searchThuocTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = searchThuocTable.Rows[e.RowIndex];

            idThuocSelectedGlobal = row.Cells["ID_THUOC"].Value.ToString();
            tenThuocBox.Text = row.Cells["TENTHUOC"].Value.ToString();
            soLuongThuocBox.Text = null;
        }
    }
}
