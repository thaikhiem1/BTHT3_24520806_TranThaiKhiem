using System;
using System.Windows.Forms;
namespace BTHT3Bai_05
{
    public partial class fTinhToan : Form
    {
        public fTinhToan()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty( txt_Number1.Text.Trim()) || string.IsNullOrEmpty(txt_Number2.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ số liệu!", "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            double number1= Convert.ToDouble(txt_Number1.Text.Trim());
            double number2= Convert.ToDouble((txt_Number2.Text.Trim()));
            double Sum= number1 + number2;
            txt_Answer.Text = Sum.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txt_Number1.Text.Trim()) || string.IsNullOrEmpty(txt_Number2.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ số liệu!", "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            double number1 = Convert.ToDouble(txt_Number1.Text.Trim());
            double number2 = Convert.ToDouble((txt_Number2.Text.Trim()));
            double Sum = number1 - number2;
            txt_Answer.Text = Sum.ToString();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txt_Number1.Text.Trim()) || string.IsNullOrEmpty(txt_Number2.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ số liệu!", "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            double number1 = Convert.ToDouble(txt_Number1.Text.Trim());
            double number2 = Convert.ToDouble((txt_Number2.Text.Trim()));
            double Sum = number1 * number2;
            txt_Answer.Text = Sum.ToString();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txt_Number1.Text.Trim()) || string.IsNullOrEmpty(txt_Number2.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ số liệu!", "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            double number1 = Convert.ToDouble(txt_Number1.Text.Trim());
            double number2;
            if(!double.TryParse(txt_Number2.Text.Trim(), out number2) || number2 == 0)
            {
               MessageBox.Show("Không thể chia cho 0!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
               return;
            }
            double Sum = number1 / number2;
            txt_Answer.Text = Sum.ToString("F2");
        }
        private void txt_Number1_KeyPress(object sender, KeyPressEventArgs e)
        {
           if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
           {
               e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }
        private void txt_Number1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { 
                txt_Number2.Focus();
            }
        }
    }
}
