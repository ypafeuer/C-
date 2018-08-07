using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6_180802
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Image ii = WindowsFormsApp6_180802.Properties.Resources.Car_GT;
            label3.Size = ii.Size;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = String.Format("X={0},y={1}",e.X,e.Y);
        }

        private void Form2_MouseClick(object sender, MouseEventArgs e)
        {
            label2.Text = String.Format("X={0},y={1},按了{2}幾次{3}", e.X, e.Y,e.Button,e.Clicks);
        }
    }
}
