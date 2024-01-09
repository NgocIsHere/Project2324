﻿using QLPHONGKHAM.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPHONGKHAM
{
    public partial class QTV : Form
    {
        NavigationControl navigationControl;
        NavigationButtons navigationButtons;

        Color btnDefaultColor = Color.Transparent;
        Color btnSelectedtColor = Color.Teal;

        public QTV()
        {
            InitializeComponent();
            InitializeNavigationControl();
            InitializeNavigationButtons();
        }

        private void InitializeNavigationControl()
        {
            List<UserControl> userControls = new List<UserControl>() // Your UserControl list
            { new DonThuoc(), new QuanLyThuoc(), new NhaSi(), new NhanVien(), new LichLamViec()};

            navigationControl = new NavigationControl(userControls, content); // create an instance of NavigationControl class
            navigationControl.Display(0); // display UserControl1 as default
        }

        private void InitializeNavigationButtons()
        {
            List<Button> buttons = new List<Button>()
            { donThuocButton, thuocButton, NSButton, NVButton, LLVButton};

            // create a NavigationButtons instance
            navigationButtons = new NavigationButtons(buttons, btnDefaultColor, btnSelectedtColor);
            // Make a default selected button
            navigationButtons.Highlight(donThuocButton);
        }

        private void donThuocButton_Click(object sender, EventArgs e)
        {
            navigationControl.Display(0);
            navigationButtons.Highlight(donThuocButton);
        }

        private void thuocButton_Click(object sender, EventArgs e)
        {
            navigationControl.Display(1);
            navigationButtons.Highlight(thuocButton);
        }

        private void NSButton_Click(object sender, EventArgs e)
        {
            navigationControl.Display(2);
            navigationButtons.Highlight(NSButton);
        }

        private void NVButton_Click(object sender, EventArgs e)
        {
            navigationControl.Display(3);
            navigationButtons.Highlight(NVButton);
        }
        private void LLVButton_Click(object sender, EventArgs e)
        {
            navigationControl.Display(4);
            navigationButtons.Highlight(LLVButton);
        }

        private void QTV_Load(object sender, EventArgs e)
        {

        }
        private void content_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}