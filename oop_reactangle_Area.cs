using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class rectangle
    {
        public int length, width;
        public void input(int x,int y)
        {
            length = x;
            width = y;
        }
        public int rectarea()
        {
            int area;
            area = length * width;
            return (area);
        }
    }
    class area
    {
        static void Main(string[] args)
        {
            int area1, area2;
            rectangle rect1 = new rectangle();
            rectangle rect2= new rectangle();
            rect1.length = 15;
            rect1.width = 10;
            area1 = rect1.length * rect1.width;
            rect2.input(5,4);
            area2 = rect2.rectarea();
            Console.WriteLine("Area = " + area1);
            Console.WriteLine("Area = " + area2);
            Console.ReadLine();
        }
    }
}
