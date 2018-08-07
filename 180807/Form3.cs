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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            label1.Text = String.Format("鍵碼{0}鍵值{1}",e.KeyCode,e.KeyValue);
            if (e.Control && e.KeyCode==Keys.K) {
                //MessageBox.Show("hhhh");
                this.Close();
            }
        }

        private void Form3_KeyPress(object sender, KeyPressEventArgs e)
        {
            label2.Text = String.Format("字{0} {1}", e.KeyChar, (int)e.KeyChar);
        }
    }
}
