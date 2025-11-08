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
    public partial class fThongtinsinhvien : Form
    {
        public fThongtinsinhvien()
        {
            InitializeComponent();
            cbb_ChuyenNganh.SelectedIndex = 0;

        }
        private void txt_MaSV_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txt_NameSV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void btn_LeftToRight_Click(object sender, EventArgs e)
        {
            var SelectedItem = lb_MonHoc.SelectedItems.Cast<string>().ToList();
            foreach (var item in SelectedItem) { 
                lb_TenMonHoc.Items.Add(item);   
            }
            foreach(var item in SelectedItem) 
            {
                lb_MonHoc.Items.Remove(item);
            }
        }
        private void btn_RightToLeft_Click(object sender, EventArgs e)
        {
            var SelectedItem = lb_TenMonHoc.SelectedItems.Cast<string>().ToList();
            foreach(var item in SelectedItem)
            {
                lb_MonHoc.Items.Add(item);
            }
            foreach(var item in SelectedItem)
            {
                lb_TenMonHoc.Items.Remove(item);
            }
        }
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if(lb_TenMonHoc.Items.Count == 0)
            {
                MessageBox.Show("Không có môn học nào để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            foreach(var item in lb_TenMonHoc.Items)
            {
                lb_MonHoc.Items.Add(item);
            }
            lb_TenMonHoc.Items.Clear();

            MessageBox.Show("Đã xóa toàn bộ các môn học đã chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string maSv = txt_MaSV.Text;
            string nameSv = txt_NameSV.Text.Trim();
            string chuyenNganh = cbb_ChuyenNganh.Text.Trim();
            string gioiTinh = chk_Nam.Checked ? "Nam" : (chk_Nu.Checked ? "Nữ" : "");
            int soMon = lb_TenMonHoc.Items.Count;
            if(string.IsNullOrEmpty(maSv) || string.IsNullOrEmpty(nameSv) || string.IsNullOrEmpty(chuyenNganh) || string.IsNullOrEmpty(gioiTinh))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(soMon == 0)
            {
                MessageBox.Show("Chưa chọn môn học nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            bool found = false;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow)
                {
                    continue;
                }
                if (row.Cells["MSSV"].Value != null && row.Cells["MSSV"].Value.ToString() == maSv)
                {
                    row.Cells["HoTen"].Value = nameSv;
                    row.Cells["ChuyenNganh"].Value = chuyenNganh;
                    row.Cells["GioiTinh"].Value = gioiTinh;
                    row.Cells["SoMon"].Value = soMon;

                    found = true;
                    MessageBox.Show($"Đã cập nhật thông tin MSSV: {maSv}", "Cập nhật thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
            }
            if (!found)
            {
                int rowIndex = dataGridView1.Rows.Add();
                dataGridView1.Rows[rowIndex].Cells["MSSV"].Value = maSv;
                dataGridView1.Rows[rowIndex].Cells["HoTen"].Value = nameSv;
                dataGridView1.Rows[rowIndex].Cells["ChuyenNganh"].Value = chuyenNganh;
                dataGridView1.Rows[rowIndex].Cells["GioiTinh"].Value = gioiTinh;
                dataGridView1.Rows[rowIndex].Cells["SoMon"].Value = soMon;
                MessageBox.Show("Đã lưu thông tin sinh viên!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }      
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow dataGridViewRow = dataGridView1.Rows[e.RowIndex];
                txt_MaSV.Text = dataGridViewRow.Cells["MSSV"].Value?.ToString();
                txt_NameSV.Text = dataGridViewRow.Cells["HoTen"].Value?.ToString();
                cbb_ChuyenNganh.Text = dataGridViewRow.Cells["ChuyenNganh"].Value?.ToString();
                string gioitinh = dataGridViewRow.Cells["GioiTinh"].Value?.ToString();
                if (gioitinh == "Nam")
                {
                    chk_Nam.Checked = true;
                    chk_Nu.Checked = false;
                }
                else
                {
                    chk_Nu.Checked = true;
                    chk_Nam.Checked = false;
                }
            }
        }
    }
}
