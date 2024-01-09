﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPHONGKHAM.Controls
{
    public partial class LichLamViec : UserControl
    {

        Connection connection;
        Util util;

        public LichLamViec()
        {
            InitializeComponent();
            connection = new Connection();
            util = new Util();
        }
        private void LichLamViec_Load(object sender, EventArgs e)
        {
            connection.connect();
            getLichLamViecList();
            lichLamViecTable.ClearSelection();
        }

<<<<<<< HEAD
        void getLichLamViecList()
        {
            
=======
        private void RefreshDataGridView()
        {
            lichLamViecTable.DataSource = connection.dataTable("EXEC SP_XEMLICHLAMVIEC");
            xoaButton.Enabled = false;
            capNhatButton.Enabled = false;
            util.ClearControl(this.InformationSection);
        }

        void getLichLamViecList()
        {
            lichLamViecTable.DefaultCellStyle.ForeColor = Color.Black;
            lichLamViecTable.DataSource = connection.dataTable("EXEC SP_XEMLICHLAMVIEC");

            //Đổi tên column
            lichLamViecTable.Columns["NHASI"].HeaderText = "ID Nha Sĩ";
            lichLamViecTable.Columns["HOTEN"].HeaderText = "Họ và tên";
            lichLamViecTable.Columns["THANG"].HeaderText = "Tháng";
            lichLamViecTable.Columns["NGAYLAMVIEC"].HeaderText = "Ngày làm việc";
>>>>>>> cdd43a3a0d780ec49c7279ff634fe6290272bd0a
        }

        private void lichLamViecTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ngaySinhBox_ValueChanged(object sender, EventArgs e)
        {

        }

        private void themButton_Click(object sender, EventArgs e)
        {
            connection.connect();
            SqlParameter[] paras =
            {
                new SqlParameter("@NHASI", SqlDbType.Char){Value = this.iDNhaSiBox.Text},
                new SqlParameter("@NGAY", SqlDbType.Date){Value = this.ngayLamViecBox.Value},
                new SqlParameter("@THOIGIAN", SqlDbType.Time){Value = this.gioLamViecBox.Value.TimeOfDay}
            };
            int statusCode = connection.ExecuteStoredProcedureWithParams("THEMLICHLAMVIEC", paras);

            if (statusCode == 0)
            {
                MessageBox.Show("THÊM LỊCH LÀM VIỆC THÀNH CÔNG");
            }
            else if (statusCode == -1)
            {
                MessageBox.Show("LỊCH LÀM VIỆC NÀY ĐÃ TỒN TẠI");
            }
            getLichLamViecList();
            lichLamViecTable.ClearSelection();          
        }

        private void locButton_Click(object sender, EventArgs e)
        {
            locLichLamViec();
        }

        void locLichLamViec()
        {
            connection.connect();
            string procName = "";
            SqlParameter[] paras = null;

            lichLamViecTable.DefaultCellStyle.ForeColor = Color.Black;
            if (ngayradioButton.Checked)
            {
                procName = "XEMLICHLAMVIECNGAY";
                paras = new SqlParameter[] {
        new SqlParameter("@SelectedDate", SqlDbType.Date) { Value = this.ngayBatDauTimePicker.Value }
        };
            }
            else if (tuanradioButton.Checked)
            {
                procName = "XEMLICHLAMVIECTUAN";
                // Tính ngày đầu tuần và cuối tuần từ ngày được chọn
                DateTime selectedDate = this.ngayBatDauTimePicker.Value;
                DateTime startOfWeek = selectedDate.AddDays((int)DayOfWeek.Monday - (int)selectedDate.DayOfWeek);
                DateTime endOfWeek = startOfWeek.AddDays(6);

                paras = new SqlParameter[] {
        new SqlParameter("@StartDate", SqlDbType.Date) { Value = startOfWeek },
        new SqlParameter("@EndDate", SqlDbType.Date) { Value = this.NgayKetThucTimePicker.Value }
        };
            }
            else if (thangradioButton.Checked)
            {
                procName = "XEMLICHLAMVIECTHANG";
                // Lấy ngày đầu tháng và cuối tháng từ ngày được chọn
                DateTime selectedDate = this.ngayBatDauTimePicker.Value;
                DateTime startOfMonth = new DateTime(selectedDate.Year, selectedDate.Month, 1);
                DateTime endOfMonth = startOfMonth.AddMonths(1).AddDays(-1);

                paras = new SqlParameter[] {
            new SqlParameter("@StartDate", SqlDbType.Date) { Value = startOfMonth },
            new SqlParameter("@EndDate", SqlDbType.Date) { Value = this.NgayKetThucTimePicker.Value }
        };
            }

            if (!string.IsNullOrEmpty(procName) && paras != null)
            {
                DataTable resultTable = connection.dataTableWithParams(procName, paras);
                lichLamViecTable.DataSource = resultTable;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn loại lịch làm việc cần xem.");
            }
        }



        private void InformationSection_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void hoVaTenBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
