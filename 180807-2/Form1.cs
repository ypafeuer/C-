using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WA1070807
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //MessageBox.Show("建構子發生！");
        }
        private void Form1_Load(object sender, EventArgs e)
        {   
            //MessageBox.Show("視窗載入囉！");
        }


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            label1.Text = string.Format("打了：{0}，字碼：{1}",e.KeyChar,(int)e.KeyChar);

            //if (!((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57))
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9'))
            {
                e.Handled = true;   //程式人員自行處理
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b;

            if (!int.TryParse(textBox2.Text, out a))
            {
                MessageBox.Show("TextBox2 請輸入數值！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Text = "";
                textBox2.Focus();
                return;
            }
            if (!int.TryParse(textBox3.Text, out b))
            {
                MessageBox.Show("TextBox3 請輸入數值！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox3.Text = "";
                textBox3.Focus();
                return;
            }

            //int a = int.Parse(textBox2.Text);
            //int b = int.Parse(textBox3.Text);
            label2.Text = (a / b).ToString();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox2.Text);
            int b = int.Parse(textBox3.Text);
            label2.Text = (a / b).ToString();
        }

        private void TBs_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = sender as TextBox;

            int a;
            if (!int.TryParse(tb.Text, out a))
            {
                EP1.SetError(tb, "請輸入數值！");
                e.Cancel = true;
            }
            else
            {
                EP1.SetError(tb, "");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(textBox4.Text);
                int b = int.Parse(textBox5.Text);
                label3.Text = (a / b).ToString();
                /*
                double a = double.Parse(textBox4.Text);
                double b = double.Parse(textBox5.Text);
                label3.Text = (a / b).ToString();
                */
            }
            catch (FormatException ex)
            {
                MessageBox.Show("請輸入數值！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
            catch (DivideByZeroException ey)
            {
                MessageBox.Show("除數不能是零啦！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ez)
            {
                MessageBox.Show("反正有錯，請洽程式人員！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
            finally
            {
                MessageBox.Show("算完啦！", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Font ff = new Font("標楷體", 24, FontStyle.Bold | FontStyle.Italic);
            //textBox6.Font = ff;

            
        }

        private void FontSizeRBs_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb.Checked)
            {
                Font oldFont = textBox6.Font;
                Font newFont = new Font(oldFont.FontFamily, int.Parse(rb.Text), oldFont.Style);
                textBox6.Font = newFont;
            }
        }

        private void FontColorRBs(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb.Checked)
            {
                switch (rb.Text)
                {
                    case "黑色": textBox6.ForeColor = Color.Black; break;
                    case "紅色": textBox6.ForeColor = Color.Red; break;
                    case "綠色": textBox6.ForeColor = Color.Green; break;
                    case "藍色": textBox6.ForeColor = Color.Blue; break;
                }
            }  
        }

        private void FontStyleCBs(object sender, EventArgs e)
        {
            Font oldFont = textBox6.Font;
            Font newFont = null;

            CheckBox cb = sender as CheckBox;
            switch (cb.Text)
            {
                case "粗體":
                    if (cb.Checked)
                        newFont = new Font(oldFont.FontFamily, oldFont.Size, oldFont.Style | FontStyle.Bold);
                    else
                        newFont = new Font(oldFont.FontFamily, oldFont.Size, oldFont.Style ^ FontStyle.Bold); break;
                case "斜體":
                    if (cb.Checked)
                        newFont = new Font(oldFont.FontFamily, oldFont.Size, oldFont.Style | FontStyle.Italic);
                    else
                        newFont = new Font(oldFont.FontFamily, oldFont.Size, oldFont.Style ^ FontStyle.Italic); break;
                case "底線":
                    if (cb.Checked)
                        newFont = new Font(oldFont.FontFamily, oldFont.Size, oldFont.Style | FontStyle.Underline);
                    else
                        newFont = new Font(oldFont.FontFamily, oldFont.Size, oldFont.Style ^ FontStyle.Underline); break;
                case "刪除線":
                    if (cb.Checked)
                        newFont = new Font(oldFont.FontFamily, oldFont.Size, oldFont.Style | FontStyle.Strikeout);
                    else
                        newFont = new Font(oldFont.FontFamily, oldFont.Size, oldFont.Style ^ FontStyle.Strikeout); break;
            }

            textBox6.Font = newFont;
        }
    }
}
