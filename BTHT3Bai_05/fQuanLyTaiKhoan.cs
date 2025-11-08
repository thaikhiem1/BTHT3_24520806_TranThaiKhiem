using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BTHT3Bai_05
{
    public partial class fQuanLyTaiKhoan : Form
    {
        public fQuanLyTaiKhoan()
        {
            InitializeComponent();
        }
        private void btn_Them_Capnhat_Click(object sender, EventArgs e)
        {
            string MaTK= txt_MaTK.Text.Trim();
            string TenKH= txt_NameKH.Text.Trim();
            string DiaChiKH= txt_DiachiKH.Text.Trim();
            string GiaTienTK = txt_SoTien.Text.Trim();
            double sotien;

            if (string.IsNullOrEmpty(MaTK) || string.IsNullOrEmpty(TenKH) || string.IsNullOrEmpty(DiaChiKH) || string.IsNullOrEmpty(GiaTienTK))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            if(!double.TryParse(GiaTienTK, out sotien))
            {
                MessageBox.Show("Số tiền không hợp lệ!");
                return;
            }
            bool isUpdate = false;
            foreach (ListViewItem item1 in lsv_Account.Items) {
                if (item1.SubItems[1].Text == MaTK)
                {
                    item1.SubItems[2].Text = TenKH;
                    item1.SubItems[3].Text = DiaChiKH;
                    item1.SubItems[4].Text= sotien.ToString("N0");
                    isUpdate = true;
                    break;
                }
            }
            try
            {
               if (!isUpdate)
                {
                    int STT = lsv_Account.Items.Count + 1;
                    ListViewItem item = new ListViewItem(STT.ToString());
                    item.SubItems.Add(MaTK);
                    item.SubItems.Add(TenKH);
                    item.SubItems.Add(DiaChiKH);
                    item.SubItems.Add(sotien.ToString("N0"));
                    lsv_Account.Items.Add(item);
                    MessageBox.Show("Thêm mới dữ liệu thành công!");
                }
                else
                {
                    MessageBox.Show("Cập nhật thành công!");
                }
                resetValueControls();
                double tongTien = TinhTongTien();
                txt_Tongtien.Text = tongTien.ToString("N0");
            }
             catch(Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm/cập nhật tài khoản: " + ex.Message, "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void resetValueControls()
        {
            txt_MaTK.Text = "";
            txt_NameKH.Text = "";
            txt_DiachiKH.Text = "";
            txt_SoTien.Text = "";
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát khỏi đây?", "Xác nhận!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {

                this.Close();
            }
        }
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string MaTK = txt_MaTK.Text.Trim();
            ListViewItem itemDelete = null;
            foreach (ListViewItem item1 in lsv_Account.Items)
            {
                if (item1.SubItems[1].Text == MaTK)
                {
                    itemDelete = item1;
                    break;
                }
            }
            if (itemDelete == null)
            {
                MessageBox.Show("Mã tài khoản không tồn tại!", "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này?", "Xác nhận!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try
            {
                if (result == DialogResult.Yes)
                {
                    lsv_Account.Items.Remove(itemDelete);
                    // Cập nhật lại STT
                    for (int i = 0; i < lsv_Account.Items.Count; i++)
                    {
                        lsv_Account.Items[i].SubItems[0].Text = (i + 1).ToString();
                    }
                    MessageBox.Show("Xóa tài khoản thành công!");
                }
                resetValueControls();
                double tongTien = TinhTongTien();
                txt_Tongtien.Text = tongTien.ToString("N0");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa tài khoản: " + ex.Message, "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void lsv_Account_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsv_Account.SelectedItems.Count == 0) return;
            var item = lsv_Account.SelectedItems[0];
            txt_MaTK.Text = item.SubItems[1].Text;
            txt_NameKH.Text = item.SubItems[2].Text;
            txt_DiachiKH.Text = item.SubItems[3].Text;
            txt_SoTien.Text = item.SubItems[4].Text;
        }
        private double TinhTongTien()
        {
            double tongTien = 0;
            foreach (ListViewItem item in lsv_Account.Items)
            {
                double sotien= double.Parse(item.SubItems[4].Text, System.Globalization.NumberStyles.AllowThousands);
                tongTien += sotien;
            }
            return tongTien;
        }
        private void txt_MaTK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txt_SoTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled= false;
            }
            else
            {
                e.Handled |= true;
            }
        }
    }
}
