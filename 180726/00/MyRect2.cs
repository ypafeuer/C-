using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WA1070724
{
    class MyRect2
    {
        //封裝屬性
        public int Length { get; set; }
        public int Width { get; set; }

        public int Area()
        {
            return Length * Width;
        }
        public int Peremeter()
        {
            return (Length + Width) * 2;
        }
    }
}
