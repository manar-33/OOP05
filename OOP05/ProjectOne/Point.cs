using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP05.ProjectOne
{
    internal class Point : ICloneable , IComparable
    {
        public int P01 { get; set; }
        public int P02 { get; set; }
        public int P03 { get; set; }
        public int?[] P04 { get; set; }
        public Point():base()
        {
            P01 = 10;
            P02 = 20;
            P03 = 30;
            

        }
        public override string ToString()
        {
            return $"Point Coordinates: :{P01},{P02},{P03}";
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }

        public int CompareTo(object? obj)
        {
            throw new NotImplementedException();
        }

        public static bool operator ==(Point a, Point b)
        { 
        if(a==b)
                return true ;
        else return false ;
        }
        public static bool operator !=(Point a, Point b)
        {
            if (a != b)
                return true;
            else return false;
        }

    }
}
