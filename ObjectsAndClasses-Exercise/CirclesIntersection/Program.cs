using System;

namespace CirclesIntersection
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Circle w1 = new Circle(new Point(double.Parse(input[0]), double.Parse(input[1])), double.Parse(input[2]));
            input = Console.ReadLine().Split();
            Circle w2 = new Circle(new Point(double.Parse(input[0]), double.Parse(input[1])), double.Parse(input[2]));
            Console.WriteLine(Intersect(w1, w2) ? "Yes" : "No");
        }
        public static bool Intersect(Circle w1, Circle w2)
        {
            bool ans = false;
            Point o1 = w1.center, o2 = w2.center;
            if ((o1.x - o2.x) * (o1.x - o2.x) + (o1.y - o2.y) * (o1.y - o2.y) <= (w1.radius + w2.radius)*(w1.radius + w2.radius))
                ans = true;
            return ans;
        }
    }
    public class Point
    {

        public Point(double v1, double v2)
        {
            this.x = v1;
            this.y = v2;
        }

        public double x { get; set; }
        public double y { get; set; }
    }
    public class Circle
    {
        public Circle(Point point, double v)
        {
            this.center = point;
            this.radius = v;
        }

        public Point center { get; set; }
        public double radius { get; set; }
    }
}
