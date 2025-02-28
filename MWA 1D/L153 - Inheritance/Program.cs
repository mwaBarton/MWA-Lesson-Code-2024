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
            Console.WriteLine("Hello, I am a rectangle");
            width = inWidth;
            height = inHeight;
        }

        public Rectangle()
        {
            Console.WriteLine("Secret rectangle");
            width = -1;
            height = 42;
        }

        public int getArea()
        {
            return width * height;
        }
    }
    public class Square : Rectangle
    {
        public string name = "Peter";

        public Square(int sideLength) 
        {
            width = 5;
            Console.WriteLine("Hello, I am a square");
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

            Console.ReadKey();
        }
    }
}
