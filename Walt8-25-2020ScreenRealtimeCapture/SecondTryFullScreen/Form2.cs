using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecondTryFullScreen
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            this.DoubleBuffered = true;

            this.Paint += new PaintEventHandler(Form2_Paint);

        }
        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            if (Form1.bmp != null)
                e.Graphics.DrawImage(Form1.bmp, 100, 100);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Refresh();
        }
    }
}
