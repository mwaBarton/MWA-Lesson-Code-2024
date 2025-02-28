using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L153___Inheritance
{
    public class Rectangle
    {
        protected int width, height;
        public Rectangle(int inWidth, int inHeight)
        {
            width = inWidth;
            height = inHeight;
        }
        public int getArea()
        {
            return width * height;
        }
    }
    public class Square : Rectangle
    {
        public string name = "Bob";

        public Square(int sideLength) : base(sideLength, sideLength)
        {
            width = 10;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(4, 6);
            Console.WriteLine(r.getArea());

            Square s = new Square(4);
            Console.WriteLine(s.getArea());

            Rectangle rect = new Square(6);
            rect.getArea();
            rect.name = "Alice";

            Square s2 = (Square)rect;
            s2.name = "Alice";


            Console.ReadKey();
        }
    }
}
