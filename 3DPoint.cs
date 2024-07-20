using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5
{
    public class _3DPoint : ICloneable
    {
        public int x {  get; set; }
        public int y { get; set; }
        int z {  get; set; }

        // Constructor with parameters
        public _3DPoint(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        // Override ToString method
        public override string ToString()
        {
            return $"Point Coordinates: ({x}, {y}, {z})";
        }
        public static bool operator ==(_3DPoint p1, _3DPoint p2)
        {
            return p1.x == p2.x && p1.y == p2.y && p1.z == p2.z;
        }
        public static bool operator !=(_3DPoint p1, _3DPoint p2)
        {
            return !(p1 == p2);
        }
        public object Clone()
        {
            return new _3DPoint(x, y, z);
        }
    }

}
