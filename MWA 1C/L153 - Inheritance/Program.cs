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
            this.width = inWidth;
            this.height = inHeight;
        }

        public Rectangle()
        {
            Console.WriteLine("The silly rectangle constructor with no parameters");
            width = 0;
            height = 0;
        }
        public int getArea()
        {
            return this.width * height;
        }
    }
    public class Square : Rectangle
    {
        public Square(int sideLength) : base()
        {
            width = 6;
            Console.WriteLine("hello I'm a square");
        }

        public void DoASquareThing()
        {
            Console.WriteLine("Square thing");
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

            s.DoASquareThing();

            Rectangle rect = (Rectangle)s;

            Square itsactuallyasquare = (Square)rect;
            itsactuallyasquare.DoASquareThing();

            Console.ReadKey();
        }
    }
}
