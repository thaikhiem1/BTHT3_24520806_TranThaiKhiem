using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTHT3Bai_05
{
    public partial class FormBTTHT3 : Form
    {
        public FormBTTHT3()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            fTinhToan fTinhToan = new fTinhToan();
            fTinhToan.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            fThongtinsinhvien fThongtinsinhvien = new fThongtinsinhvien();
            fThongtinsinhvien.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fColorChange fColorChange = new fColorChange();
            fColorChange.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fPaint fPaint = new fPaint();
            fPaint.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fChangeColorFrom fChangeColorFrom = new fChangeColorFrom();
            fChangeColorFrom.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            fQuanLyTaiKhoan fQuanLyTaiKhoan = new fQuanLyTaiKhoan();
            fQuanLyTaiKhoan.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
           fBanve fBanve = new fBanve();
           fBanve.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fVongDoiCuaForm fVongDoiCuaForm = new fVongDoiCuaForm();
            fVongDoiCuaForm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            fCalculator fCalculator = new fCalculator();
            fCalculator.ShowDialog();
        }
    }
}
