using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class A
    {
        private int num1;
        public int num2;
        public void Add(int a,int b)
        {
            num1 = a;
            num2 = b;
            Console.WriteLine("Addition of " + num1 + "and " + num2 + " is " + (a + 10));
        }
        public virtual void Add(int a)
        {
            Console.WriteLine("Addition is " + (a + 10));
        }
    }
    class Program:A
    {
        public override void Add(int a)
        {
            Console.WriteLine("Addition is " + (a + 10));
        }
        static void Main(string[] args)
        {
            A obj = new A();
            obj.num2 = 30;
            obj.Add(10, obj.num2);
            obj.Add(15);
            Console.ReadLine();
        }
    }
}
