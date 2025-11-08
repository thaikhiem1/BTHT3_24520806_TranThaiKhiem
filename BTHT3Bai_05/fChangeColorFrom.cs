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
    public partial class fChangeColorFrom : Form
    {
        public fChangeColorFrom()
        {
            InitializeComponent();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            base.BackColor = colorDialog1.Color;
        }
    }
}
