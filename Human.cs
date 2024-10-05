using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorkPartOne
{
    public struct Human
    {
        char []name;
        char family;
        int  nCode;
        int  age; 
        public Human(char[]na, char fa, int nc, int ag)
        {
            this.name = na;
            this.family = fa;
            this.nCode = nc;
            this.age = ag;
        }
        public char []Name
        {
            get { return name; }   // get method
            set { name = value; }  // set method
        }
        public char Family
        {
            get { return family; }   // get method
            set { family = value; }  // set method
        }
        public int NCode
        {
            get { return nCode; }   // get method
            set { nCode = value; }  // set method
        }
        public int Age
        {
            get { return age; }   // get method
            set { age = value; }  // set method
        }


    }
}
