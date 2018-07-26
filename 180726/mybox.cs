using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class mybox :rect
    {
        private int height;
        public int Height
        {
            get { return this.height; }
        }

        public mybox()
        {
            this.height = 6;
            this.長 = base.長get();
            this.寬 = base.寬get();
        }
        public mybox(int length, int width, int height):base(width,length)
        {
            this.height = height;
            this.寬 = width;
            this.長 = length;

        }
        public override String ToString()
        {
            String result = base.ToString();
            result += string.Format("高{0}", this.Height) + "\r\n";
            result += string.Format("體積{0}", this.Volumn()) + "\r\n";
            return result;
        }

        public int Volumn() {
            return base.面積() * this.Height;
        }
        public new int 周長() {
            return 長 * 4 + 寬 * 4 + (this.height*2);
        }
    }
}
