using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP05.ProjectTwo
{
    public class Maths
    {
        public int X { get; set; }
        public int Y { get; set; }

       
        public virtual int Add(int a, int b)
        {
            return a + b;
        }
        public virtual int Sub(int a, int b)
        {
            return a - b;
        }
        public virtual int Multiply(int a, int b)
        {
            return a * b;
        }
        public virtual int Divide(int a, int b)
        {
            return a / b;
        }
        public override string ToString()
        {
            return$"";
        }

    }
}
