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
            //MessageBox.Show("建構子發生！");
        }
        private void Form1_Load(object sender, EventArgs e) {
            //MessageBox.Show("視窗載入囉！");
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
                label3.Text = (int.Parse(textBox4.Text) / int.Parse(textBox5.Text)).ToString();
            }
            catch (DivideByZeroException ee) {
                MessageBox.Show("除數為零" + "\r\n" + ee.Message + "\r\n" + ee.ToString());
            }
            catch (FormatException ee) {
                MessageBox.Show("格式錯誤" + "\r\n" + ee.Message + "\r\n" + ee.ToString());
            }
            catch (Exception ee) {
                //label3.Text = ""+ee.Message;
                MessageBox.Show("" + ee.Message + "\r\n" + ee.ToString());
                //MessageBox.Show("TextBox2 請輸入數值！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally {
                MessageBox.Show("算完啦","訊息",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
        }

        private void button4_Click(object sender, EventArgs e) {
            Font ff = new Font("標楷體",24,FontStyle.Bold |FontStyle.Italic);
            textBox6.Font = ff;
            //button4.Font = ff;
        }

        private void changed01(object sender, EventArgs e) {
            Font font = textBox6.Font;
        }
    }
}
