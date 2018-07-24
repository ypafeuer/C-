using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int gg;
        int hp1, hp2;
        int cc;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            string result = "";
            gg = 100;
            //類型 類型cls = new 類型();
            //類型2 類型cls2 = new 類型2();
            //類型cls.x = 100;
            //類型cls2.x = 100;
            //msg(類型cls);
            //msg(類型cls2);
            //msg(類型cls);
            //msg(類型cls2);
            //msg(類型cls);
            //msg(類型cls2);

            msg(calc(1,2,3,4,5,6,7,8,9,0));
            msg(calc(5));
            msg(calc(2,8));
            //類型[] zz = { 類型cls, 類型cls };
            int[] xx = { 90, 80, 70, 60, 50 };
            int[] yy = xx;
            yy[2] = 100;

            //result += (xx == yy).ToString() + "\r\n"; 
            foreach (int a in xx)
            {
                //result += a + "\t";
            }
            result += "\r\n";
            textBox1.Text = "" + result;
        }
        public int calc(params int[] a)
        {
            int x = 0;
            foreach (int aa in a) {
                x = x + aa;
            }
            return x;
        }

            public int calc(int a) {
            int x = 1;
            for (int i = 1; i <= a; i++) {
                x = x * i;
            }
            return x;
        }
        public int calc(int a,int b)
        {
            int x = 1;
            for (int i = 1; i <= b; i++)
            {
                x = x * a;
            }
            return x;
        }
        void msg(int a)
        {
            MessageBox.Show("" + a, "預設",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        void msg(string str = "")
        {
            Random rr = new Random();
            gg = gg - 10 - (int)(rr.NextDouble() * 10 + 1);
            cc++;
            MessageBox.Show("" + gg, "回合" + cc,
                MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        void msg(類型 cls)
        {
            cc++;
            Random rr = new Random();
            cls.x = cls.x - 10 - (int)(rr.NextDouble() * 10 + 1);
            MessageBox.Show("類型="+ cls.x, "回合" + cc,
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void msg(類型2 cls)
        {
            cc++;
            Random rr = new Random();
            cls.x = cls.x - 20 - (int)(rr.NextDouble() * 10 + 1);
            MessageBox.Show("類型2="+ cls.x, "回合" + cc,
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public class 類型
        {
            public int x;
        }
        public class 類型2
        {
            public int x;

        }
    }
}
