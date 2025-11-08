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
    public partial class fColorChange : Form
    {
        public fColorChange()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            base.BackColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
        }
    }
}
