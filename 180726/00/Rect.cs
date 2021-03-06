﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WA1070724
{
    class MyRect
    {
        //封裝屬性
        private int length;
        private int width;
        
        public int Length
        {
            get { return this.length; }
            //set { this.length=value }
        }
        public int Width
        {
            get { return this.width; }
            //set { this.width=value }
        }

        //建構子 Constructor
        public MyRect()
        {
            this.length = 10;
            this.width = 8;
        }
        public MyRect(int length,int width)
        {
            if (length > 0 && width > 0)
            {
                this.length = length;
                this.width = width;
            }

            if (length < 0) this.length = 1;
            if (width < 0) this.width = 1;            
        }


        public int Area()
        {
            return length * width;
        }
        public int Peremeter()
        {
            return (length + width) * 2;
        }
    }
}
