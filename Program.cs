using System.Collections.Generic;
using System.Drawing;
using System.Runtime.Intrinsics.X86;

namespace OOP5
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region First Project:

            #region Define 3D Point Class and the basic Constructors(use chaining in constructors).

            ////Override the ToString Function to produce this output:
            ////Point3D P = new Point3D(10, 10, 10);
            ////Console.WriteLine(P.ToString());
            ////Output: “Point Coordinates: (10, 10, 10)”.

            //_3DPoint P = new _3DPoint(10, 10, 10);
            //Console.WriteLine(P.ToString());

            #endregion


            #region Read from the User the Coordinates for 2 points P1, P2(Check the input using try Pares, Parse, Convert).

            //int x1=0, x2 = 0, y1 = 0, y2 = 0, z1 = 0, z2 = 0;
            //Console.WriteLine("Enter your first point Coordinates");
            //x1=int.Parse(Console.ReadLine());
            //y1 = int.Parse(Console.ReadLine());
            //z1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter your Second point Coordinates");
            //x2 = int.Parse(Console.ReadLine());
            //y2 = int.Parse(Console.ReadLine());
            //z2 = int.Parse(Console.ReadLine());
            //_3DPoint P1 = new _3DPoint(x1, y1, z1);
            //_3DPoint P2 = new _3DPoint(x2, y2, z2);
            //Console.WriteLine(P1.ToString());
            //Console.WriteLine(P2.ToString());

            #endregion

            #region Try to use ==

            ////If(P1 == P2)   Does it work properly? 

            //if(P1 == P2) Console.WriteLine(" Equal points ");
            //else Console.WriteLine("Not Equal points ");

            #endregion

            #region Define an array of points and sort this array based on X &Y coordinates.

            //_3DPoint[] points = new _3DPoint[]
            //{
            //    new _3DPoint(2, 2, 11),
            //    new _3DPoint(1, 1, 22),


            //};

            //Array.Sort(points, (p1, p2) =>
            //{
            //    int xComparison = p1.x.CompareTo(p2.x);
            //    if (xComparison != 0)
            //        return xComparison;
            //    return p1.y.CompareTo(p2.y);
            //});
            //Console.WriteLine(points[0].ToString());
            //Console.WriteLine(points[1].ToString());

            #endregion

            #region Implement ICloneable interface to be able to clone the object.

            ////To implement more than one interface.
            ////class Point3D : IComparable, ICloneable

            //_3DPoint P = new _3DPoint(10, 10, 10);
            //object PTemp = P.Clone();

            #endregion

            #endregion


            #region Second Project:

            ////Define Class Maths that has four methods: Add, Subtract, Multiply, and Divide, each of them takes two parameters.Call each method in Main().
            //// Modify the program so that you do not have to create an instance of class to call the four methods.

            //Console.WriteLine($"Addition: {Maths.Add(5, 3)}");
            //Console.WriteLine($"Subtraction: {Maths.Subtract(10, 4)}");
            //Console.WriteLine($"Multiplication: {Maths.Multiply(3, 2)}");
            //Console.WriteLine($"Multiplication: {Maths.Divide(6, 2)}");

            #endregion


            #region Third Project:



            ////Define Class Duration To include Three Attributes Hours, Minutes and Seconds.

            ////Override All System.Object Members (ToString, Equals, GetHasCode) .

            ////Define All Required Constructors to Produce this output:

            //Duration D = new Duration(1, 10, 15);
            //D.ToString();

            //Duration D1 = new Duration(3600);
            //D1.ToString();

            //Duration D2 = new Duration(7800);
            //D2.ToString();

            //Duration D3 = new Duration(666);
            //D3.ToString();

            //D3 = D1 + D2;
            //D3.ToString();
            //D3 = D1 + 7800;
            //D3.ToString();
            //D3 = 666 + D3;
            //D3.ToString();
            //D3 = ++D1;
            //D3.ToString();
            //D3 = --D2;
            //D3.ToString();
            //D1 = D1 - D2;
            //D1.ToString();

            //if(D1 > D2) Console.WriteLine("D1>D2");
            //else Console.WriteLine("D1<D2");

            //if (D1 <= D2) Console.WriteLine("D1<=D2");
            //else Console.WriteLine("D1>=D2");

            ////If(D1)
            ////DateTime Obj = (DateTime)D1; invalid



            #endregion


        }
    }
}
