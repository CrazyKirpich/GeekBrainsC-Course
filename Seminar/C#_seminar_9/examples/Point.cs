// Пример инкапсуляции.

namespace MyPoint
{
    public class Point
    {
        public Point(int x, int y)
        {
            X = x;
            Y = y;
            Console.WriteLine("X = " + X + ", Y = " + Y);
        }
        /// <summary>
        /// Точка x
        /// </summary>
        public int X { get; set; }
        /// <summary>
        /// Точка y
        /// </summary>
        public int Y { get; set; }

        public static string GetPointDistance(Point p1, Point p2)
        {
            if (IsPointEquals(p1, p2))
            {
                return "Обе точки на одних и тех же координатах";
            }
            return CalculateDistance(p1, p2).ToString();
        }

        private static bool IsPointEquals(Point p1, Point p2)
        {
            return p1.X == p2.X && p1.Y == p2.Y;
        }

        private static double CalculateDistance(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
        }
    }

    public class Point3D : Point
    {
        public Point3D(int x, int y, int z) : base(x, y)
        {
            X = x;
            Y = y;
            Z = z;
            Console.WriteLine("X = " + X + ", Y = " + Y + ", Z = " + Z);
        }
        public int Z { get; set; }
    }
}





