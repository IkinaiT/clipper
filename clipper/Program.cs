using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clipper2Lib;

namespace clipper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            #region Геометрическая фигура 1
            List<Point64> pointsGF1 = new List<Point64>();
            pointsGF1.Add(new Point64(0, 0));
            pointsGF1.Add(new Point64(5, 0));
            pointsGF1.Add(new Point64(5, 3));
            pointsGF1.Add(new Point64(0, 3));
            Path64 GF1 = new Path64(pointsGF1);
            Paths64 paths1 = new Paths64();
            paths1.Add(GF1);
            #endregion

            #region Геометрическая фигура 2
            List<Point64> pointsGF2 = new List<Point64>();
            pointsGF2.Add(new Point64(1, 1));
            pointsGF2.Add(new Point64(6, 1));
            pointsGF2.Add(new Point64(6, 4));
            pointsGF2.Add(new Point64(1, 4));
            Path64 GF2 = new Path64(pointsGF2);
            Paths64 paths2 = new Paths64();
            paths2.Add(GF2);
            #endregion

            Paths64 jointGF = Clipper.Intersect(paths1, paths2, FillRule.Positive);

            Console.WriteLine($"Площадь пересекаемой части: {Clipper.Area(jointGF)}");

            Console.ReadKey();
        }
    }
}
