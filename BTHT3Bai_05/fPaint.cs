using System;
using System.Drawing;
using System.Windows.Forms;
namespace BTHT3Bai_05
{
    public partial class fPaint : Form
    {
        bool check = false;
        Random Random = new Random();
        public fPaint()
        {
            InitializeComponent();
            DoubleBuffered = true;
            this.Paint += fPaint_Paint;
        }
        private void fPaint_Paint(object sender, PaintEventArgs e)
        {
            if (check)
            {
                string text = "Paint Event";
                Font font = new Font("Arial", 16);
                SizeF textSize = e.Graphics.MeasureString(text, font);
                int maxX = (int)(this.ClientSize.Width - textSize.Width);
                int maxY = (int)(this.ClientSize.Height - textSize.Height);
                int x = Random.Next(1, maxX);
                int y = Random.Next(1, maxY);
                e.Graphics.DrawString(text, font, Brushes.Blue, x, y);
               
            }          
        }
        private void button1_Click(object sender, EventArgs e)
        {
            check = true;
            this.Invalidate();
        }
    }
}
