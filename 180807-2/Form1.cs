using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6_180807 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e) {
            label1.Text = string.Format("按了{0} 字碼{1}",e.KeyChar,(int)e.KeyChar);
            if (e.KeyChar >= '0' && e.KeyChar <= '9' ) {
                //ok
            } else {
                if ((int)e.KeyChar == 8) {
                    //ok
                } else {
                    e.Handled = true;
                }
            }

        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e) {
            label1.Text = string.Format("按了{0} 字碼{1}", e.KeyChar, (int)e.KeyChar);

        }

        private void button1_Click(object sender, EventArgs e) {
            int a, b;
            if (int.TryParse(textBox2.Text, out a)) {
            } else {
                textBox2.Text = "";
                textBox2.Focus();
                label2.Text = "textBox2轉換失敗";
                return;
            }
            if (int.TryParse(textBox3.Text, out b)) {
            } else {
                textBox3.Text = "";
                textBox3.Focus();
                label2.Text = "textBox3轉換失敗";
                return;
            }

            //label2.Text = ((double)int.Parse(textBox2.Text) / (double)int.Parse(textBox3.Text)).ToString();
            label2.Text = ((double)a / b).ToString();
        }





        private void tb_Validating(object sender, CancelEventArgs e) {
            TextBox tb = (TextBox)sender;
            if (int.TryParse(tb.Text, out int a)) {
            } else {
                tb.Text = "";
                tb.Focus();
                label2.Text = "轉換失敗";
                EP1.SetError(tb,"輸入數值");
                //e.Cancel=true;
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e) {
            try {
                label3.Text = ((double)int.Parse(textBox4.Text) / (double)int.Parse(textBox5.Text)).ToString();
            }
            catch (Exception ee) {
                label3.Text = ""+ee.Message;
            }
        }
    }
}
