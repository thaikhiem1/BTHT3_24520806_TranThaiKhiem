using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
namespace BTHT3Bai_05
{
    public partial class fBanve : Form
    {
        List<Button> SelectedSeat = new List<Button>();
        public fBanve()
        {
            InitializeComponent();
            CreateEventBtnClick();
            btn_Chon.Enabled = false;
            btn_HuyBo.Enabled = false;
            btn_Chon.DialogResult = DialogResult.None;
            btn_HuyBo.DialogResult = DialogResult.None;
            btn_KetThuc.DialogResult = DialogResult.None;
        }
        private void CreateEventBtnClick()
        {
            foreach (var item in tableLayoutPanel1.Controls)
            {
                if (item is Button btn)
                {
                    btn.Click += Btn_Click;
                }
            }
        }
        private void EnabledControl()
        {
            btn_Chon.Enabled = true;
            btn_HuyBo.Enabled = true;
        }
        private void DisEnabledControl()
        {
            btn_Chon.Enabled = false;
            btn_HuyBo.Enabled = false;
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            EnabledControl();
            if (btn != null)
            {
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Blue;
                    txt_TongTien.Text = "";
                    SelectedSeat.Add(btn);
                }
                else if (btn.BackColor == Color.Blue)
                {
                    btn.BackColor = Color.White;
                    txt_TongTien.Text = "";
                    SelectedSeat.Remove(btn);
                }
                else if (btn.BackColor == Color.Yellow)
                {
                    {
                        MessageBox.Show($"Vé ở vị trí ghế số {btn.Text} đã được bán!", "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        return;
                    }
                }
            }
        }
        private void btn_Chon_Click(object sender, EventArgs e)
        {
            int TotalPrice = 0;
            if (SelectedSeat.Count > 0)
            {
                foreach (var item in SelectedSeat)
                {
                    int NumberSeat = int.Parse(item.Text);
                    int Price = 0;
                    if (NumberSeat > 0 && NumberSeat <= 5)
                    {
                        Price = 5000;
                    }
                    else if (NumberSeat > 0 && NumberSeat <= 10)
                    {
                        Price = 6500;
                    }
                    else
                    {
                        Price = 8000;
                    }
                    TotalPrice += Price;
                    item.BackColor = Color.Yellow;
                }
                txt_TongTien.Text = TotalPrice.ToString("C0", new CultureInfo("vi-VN"));
                SelectedSeat.Clear();
            }
            DisEnabledControl();
        }
        private void btn_HuyBo_Click(object sender, EventArgs e)
        {
            if (SelectedSeat.Count > 0)
            {
                foreach (var item in SelectedSeat)
                {
                    item.BackColor = Color.White;
                }
                int TotalPrice = 0;
                txt_TongTien.Text = TotalPrice.ToString("C0", new CultureInfo("vi-VN"));
                SelectedSeat.Clear();
            }
            DisEnabledControl();
        }
        private void btn_KetThuc_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát khỏi đây!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
