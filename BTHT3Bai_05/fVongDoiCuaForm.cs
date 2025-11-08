using System;
using System.Windows.Forms;
namespace BTHT3Bai_05
{
    public partial class fVongDoiCuaForm : Form
    {
        public fVongDoiCuaForm()
        {
            InitializeComponent();
            MessageBox.Show("Constructor: Form được khởi tạo");
        }
        private void fVongDoiCuaForm_Activated(object sender, EventArgs e)
        {
            MessageBox.Show("Activated: Form nhận được focus (được kích hoạt)");
        }
        private void fVongDoiCuaForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("FormClosed: Form đã đóng xong");
        }
        private void fVongDoiCuaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("FormClosing: Form chuẩn bị đóng");
        }
        private void fVongDoiCuaForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Load: Dữ liệu và control được tải vào form");
        }
        private void fVongDoiCuaForm_Deactivate(object sender, EventArgs e)
        {
            MessageBox.Show("Deactivate: Form bị mất focus");
        }
        private void fVongDoiCuaForm_Shown(object sender, EventArgs e)
        {
            MessageBox.Show("Shown: Form đã được hiển thị lần đầu tiên");
        }
    }
}
