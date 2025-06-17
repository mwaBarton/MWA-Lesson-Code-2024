using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsBitmapGraphics
{
    public partial class Form1 : Form
    {
        Bitmap B;
        Graphics G;
        Random r = new Random();
        List<(int x, int y)> list = new List<(int x, int y)>();

        public Form1()
        {
            InitializeComponent();
            B = new Bitmap(display.Width, display.Height);
            G = Graphics.FromImage(B);


            for (int x = 0; x < 1000; x++)
            {
                list.Add((r.Next(display.Width), r.Next(display.Height)));
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Update position

            for (int x = 0; x < list.Count; x++)
            {
                list[x] = (list[x].x + r.Next(-3,4), list[x].y + r.Next(-5,6));

            }

            // Clear frame
            G.Clear(Color.White);

            // Draw
            for (int x = 0; x < list.Count; x++)
            {
                G.FillEllipse(new SolidBrush(Color.Red), list[x].x, list[x].y, 10, 10);
            }

            // Update display
            display.Image = B;
        }
    }
}
