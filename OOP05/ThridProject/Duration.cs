using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP05.ThridProject
{
    internal class Duration
    {
        public double Hours { get; set; }
        public double Minutes { get; set; }
        public double Seconds { get; set; }
        public int FullTime { get; set; }
        public override string ToString()
        {
            return $"Hours:{Hours}, Minutes:{Minutes}, Seconds:{Seconds} , Full Time {FullTime}  ";
        }
        public  int TimeSpan()
        {
            Console.WriteLine();
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }
    }
}
