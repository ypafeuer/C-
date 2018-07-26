using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class rect
    {
        protected int 長;
        protected int 寬;
        public int 長get() { return this.長; }
        public int 寬get() { return this.寬; }
        public void 長set(int x) { this.長 = x; }
        public void 寬set(int x) { this.寬 = x; }


        public rect() {
            this.長 = 2;
            this.寬 = 3;

        }
        public rect(int 長,int 寬){
            if (長 > 0) { this.長 = 長; }
            else { this.長 = 1; }
            if (寬 > 0) { this.寬 = 寬; }
            else { this.寬 = 1; }

        }
        public override String ToString() {
            String result="";
            result += string.Format("長{0}", this.長)+"\r\n";
            result += string.Format("寬{0}", this.寬) + "\r\n";
            result += string.Format("面積{0}", this.面積()) + "\r\n";
            result += string.Format("周長{0}", this.周長()) + "\r\n";
            return result;
        }
        /*

          */
        public class 顏色 {
            public string 色彩="red";

        };
        public int 面積() { return 長 * 寬; }
        public int 周長() { return 長*2 + 寬*2; }
        /*
        public int get長() { return 長; }
        public int get寬() { return 寬; }
        public void set長(int 長) { this.長=長; }
        public void set寬(int 寬) { this.寬=寬; }
         */

    }
    class unit { }
    class hero : unit

    {
        public readonly string type = "我方";
        public int hp;
        public int atk;
        public int def;

        public void set(int hp,int atk,int def) {
            this.hp = hp;
            this.atk = atk;
            this.def = def;
            return;
        }
        public void sethp(int hp) { this.hp = hp; }
        public void setatk(int atk) { this.atk = atk; }
        public void setdef(int def) { this.def = def; }
    }
    class enemy : unit
    {
        public readonly string type ="敵方";
        public int hp;
        public int atk;
        public int def;
        public void set(int hp, int atk, int def)
        {
            this.hp = hp;
            this.atk = atk;
            this.def = def;
            return;
        }
        public void sethp(int hp) { this.hp = hp; }
        public void setatk(int atk) { this.atk = atk; }
        public void setdef(int def) { this.def = def; }
    }
}
