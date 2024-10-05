using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace homeWorkPartOne
{
    public struct Student
    {
        Human h;
        int stdudentNumber;
        char []field;
        double avg;
        public Human H { get { return h; } }
        public int StudentNumber
        {
            get { return stdudentNumber; }
            set { stdudentNumber = value; }
        }
        public char[] Field
        {
            get { return field; }   // get method
            set { field = value; }  // set method
        }
        public double Avg
        {
            get { return avg; }   // get method
            set { avg = value; }  // set method

        }
        public string secTarget(Human[] hm)
      {

            int i, j = 0;
            int n = hm.Length;
            for (i = 0; i < n - 1; i++)
            {
                for (j = 0; j < n - i - 1; j++)
                {
                    if (hm[j].Age > hm[j + 1].Age)
                    {
                        int temp = hm[j].Age;
                        hm[j].Age = hm[j + 1].Age;
                        hm[j + 1].Age = temp;
                    }
                }
            }
            return $"Name: {new string(hm[2].Name)}, Age: {hm[2].Age}";
        }

    }
}
