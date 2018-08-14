using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6 {
    public partial class Form1 : Form {
        Graphics fg;
        public Form1() {
            InitializeComponent();
            fg = this.CreateGraphics();
        }



        private void button1_Click(object sender, EventArgs e) {
            fg.DrawLine(
                new Pen(Color.Red, 10),
                new Point(100, 100),
                new Point(300, 300)
                );

        }

        private void button2_Click(object sender, EventArgs e) {
            Pen pp = new Pen(Color.Red, 10);
            pp.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            pp.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pp.EndCap = System.Drawing.Drawing2D.LineCap.RoundAnchor;
            fg.DrawLine(
                pp,
                new Point(100, 100),
                new Point(300, 300)
                );

            Pen pp2 = new Pen(Color.Blue, 5);
            fg.DrawLines(
                pp2,
                new Point[] {
                    new Point(100, 100),
                    new Point(150, 100),
                    new Point(150, 150),
                    new Point(200, 150),
                    new Point(200, 200)

                }
                );



        }

        private void button3_Click(object sender, EventArgs e) {
            fg.Clear(this.BackColor);
            Pen pp = new Pen(Color.Red, 10);
            fg.DrawRectangle(pp, 100, 100, 200, 300);
            try {
            }
            catch (Exception ee) {

            }

        }

        private void button4_Click(object sender, EventArgs e) {
            fg.Clear(this.BackColor);
            Random rr = new Random();
            for (int i =0; i < 3; i++) {
                Pen pp = new Pen(Color.FromArgb(rr.Next(256), rr.Next(256), rr.Next(256)), 10);//Color.Red
                fg.DrawRectangle(pp, 100+i*50, 100 + i * 50, 200, 300);
            }
        }

        private void button5_Click(object sender, EventArgs e) {
            fg.Clear(this.BackColor);
            Brush bb = new SolidBrush(Color.Pink);
            fg.FillRectangle(bb, new Rectangle(new Point(100,100),new Size(200,100)) );

        }

        private void button6_Click(object sender, EventArgs e) {
            fg.Clear(this.BackColor);
            Random rr = new Random();
            for (int i = 0; i < 3; i++) {
                Brush bb = new SolidBrush(Color.FromArgb(rr.Next(256), rr.Next(256), rr.Next(256)));
                //fg.FillRectangles(bb, new Rectangle[] {
                fg.FillRectangle(bb, new Rectangle(new Point(100+i*50, 100+i*50), new Size(200, 100))  );
            }

        }

        private void button7_Click(object sender, EventArgs e) {
            fg.Clear(this.BackColor);
            Random rr = new Random();
            Brush bb = new SolidBrush(Color.FromArgb(rr.Next(256), rr.Next(256), rr.Next(256)));
            fg.FillEllipse(bb,new Rectangle(new Point(100, 100), new Size(200, 100)));
        }

        private void button8_Click(object sender, EventArgs e) {
            fg.Clear(this.BackColor);
            Random rr = new Random();
            Brush bb = null;
            bb = new SolidBrush(Color.FromArgb(rr.Next(256), rr.Next(256), rr.Next(256)));
            fg.FillPie(bb, new Rectangle(new Point(100, 100), new Size(200, 100)), 0, 45);
            bb = new SolidBrush(Color.FromArgb(rr.Next(256), rr.Next(256), rr.Next(256)));
            fg.FillPie(bb, new Rectangle(new Point(100, 100), new Size(200, 100)), 45, 90);
            bb = new SolidBrush(Color.FromArgb(rr.Next(256), rr.Next(256), rr.Next(256)));
            fg.FillPie(bb, new Rectangle(new Point(100, 100), new Size(200, 100)), 135, 45);

        }

        private void button9_Click(object sender, EventArgs e) {
            fg.Clear(this.BackColor);
            //
            Dictionary<String , int> vv = new Dictionary<String ,int>();
            vv.Add("aaa", 500);
            vv.Add("bbb", 700);
            vv.Add("ccc", 1200);
            vv.Add("ddd", 600);

            int total = 0;
            String result = "";
            foreach (KeyValuePair<String, int> aa in vv) {
                total+=aa.Value;
                result += "\r\n" + aa.Value;
            }
            label1.Text = result;

            Random rr = new Random();
            Brush bb = null;
            //bb = new SolidBrush(Color.Pink);
            //fg.FillPie(bb, new Rectangle(new Point(100, 100), new Size(200, 200)), 0, 30);


            double sweep = 0.0;
            double angle = 0.0;
            foreach (KeyValuePair<String, int> aa in vv) {
                angle = ((double)aa.Value / total)*360;
                bb = new SolidBrush(Color.FromArgb(rr.Next(256), rr.Next(256), rr.Next(256)));
                fg.FillPie(bb, new Rectangle(new Point(100, 100), new Size(200, 200)), (float)sweep, (float)angle);
                sweep += angle;
            }


        }
    }
}
