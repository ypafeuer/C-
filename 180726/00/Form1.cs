using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WA1070724
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = "";

            /*
            MyRect r1;
            r1 = new MyRect();
            */
            
            MyRect r1 = new MyRect();
            result += r1.ToString() + "\r\n";            

            MyRect r2 = new MyRect(100,50);
            result += r2 + "\r\n";
            
            MyBox b1 = new MyBox();
            result += b1 + "\r\n";

            MyBox b2 = new MyBox(50,30,20);
            result += b2 + "\r\n";
            
            textBox1.Text = result;
        }

       
    }
}
