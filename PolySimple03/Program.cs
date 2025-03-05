using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolySimple03 // Operator overloading allows us to redefine how operators
                       // work for user-defined types.

{
    class Box
    {
        public int Width { get; set; }

        public Box(int width)
        {
            Width = width;
        }

        public static Box operator +(Box b1, Box b2)
        {
            return new Box(b1.Width + b2.Width);
        }

        public void Show()
        {
            Console.WriteLine("Box Width: " + Width);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Box box1 = new Box(10);
            Box box2 = new Box(20);
            Box result = box1 + box2; // Calls the overloaded + operator

            result.Show(); // Output: Box Width: 30
        }
    }
}
