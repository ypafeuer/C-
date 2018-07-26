using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WA1070724
{
    class MyBox : MyRect
    {
        private int height;
        public int Height
        {
            get { return this.height; }
        }

        public MyBox()
        {   
            this.height = 6;
        }
        public MyBox(int length,int width,int height):base(length,width)
        {   
            //this.length = length;
            //this.width = width;
            this.height = height;
        }

        public int Volumn()
        {
            //return this.length * this.width * this.height;
            return base.Area() * this.height;
        }

        //Override 宣告部分需要一模一樣
        public int Area()
        {
            return base.Area() * 2
                + this.Length * this.height * 2
                + this.Width * this.height * 2;
        }
        public new int Peremeter()
        {
            return base.Peremeter() * 2 + 4 * height;
        }

        public override string ToString()
        {
            string result = "";
            result += string.Format("盒子的長：{0}\r\n", this.Length);
            result += string.Format("盒子的寬：{0}\r\n", this.Width);
            result += string.Format("盒子的高：{0}\r\n", this.height);
            result += string.Format("盒子的周長：{0}\r\n", this.Peremeter());
            result += string.Format("盒子的面積：{0}\r\n", this.Area());            
            result += string.Format("盒子的體積：{0}\r\n", this.Volumn());
            return result;
        }

    }
}
