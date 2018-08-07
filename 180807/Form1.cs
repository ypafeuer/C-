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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Form2 xx = new Form2();
            int cc = 0;
            Form2 f2 = null;
            foreach (Form f in Application.OpenForms) {
                if (f.Text == "第二視窗") {
                    cc++;
                    f2 = f as Form2;
                    //f2.Activate();
                    f2.Close();
                    return;

                }

            }
            f2= new Form2();
            f2.Text = "第二視窗";
            f2.Show();
            //xx.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Application.StartupPath);
            //MessageBox.Show(Environment.OSVersion.ToString());
            String result = "";
            //result += Application.CompanyName + "\r\n";
            //result += Application.ProductName + "\r\n";
            //result += Application.ProductVersion + "\r\n";
            result += Application.OpenForms.Count.ToString() + "\r\n";
            result += Application.OpenForms.GetType() + "\r\n";
            textBox1.Text = result;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Show();
        }
    }
}
