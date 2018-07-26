using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




        private void button1_Click(object sender, EventArgs e)
        {
            //rect.顏色 obj2 = new rect.顏色();
            //obj2.色彩 = "red";



            string result = "";
            rect obj1 = new rect();
            result += obj1 + "\r\n";

            rect obj2 = new rect(10, -5);
            result += obj2 + "\r\n";

            mybox b1 = new mybox();
            result += b1 + "\r\n";

            textBox1.Text = result;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            hero obj1 = new hero();
            enemy obj2 = new enemy();
            obj1.set(100, 10, 10);
            obj2.set(100, 10, 10);
            string result = "";
            //hero objx = obj1;
            result += string.Format("類型{0},", obj1.type);
            result += string.Format("血量{0},", obj1.hp);
            result += string.Format("攻擊{0},", obj1.atk);
            result += string.Format("防禦{0},", obj1.def);
            //objx = null;
            //enemy objx = obj2;
            result += "\r\n";
            result += string.Format("類型{0},", obj2.type);
            result += string.Format("血量{0},", obj2.hp);
            result += string.Format("攻擊{0},", obj2.atk);
            result += string.Format("防禦{0},", obj2.def);

            Random rnd1 = new Random();
            result += rnd1.Next().ToString();
            while (1==1) {
                if (obj1.hp<=0 || obj2.hp <=0) {break;}
                if (1 == 1) { break; }
            }

            textBox1.Text = result;

        }
    }
}
