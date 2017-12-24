using System;

namespace ConsoleTests
{
    public delegate int BinaryOp(int x, int y);

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********* Simple Delegate Example *********\n");

            SimpleMath m = new SimpleMath();
            BinaryOp b = new BinaryOp(m.Add);
            DisplayDelegateInfo(b);
            Console.WriteLine("10 + 10 = {0}",b(10,10));
            Console.ReadKey();
        }

        static void DisplayDelegateInfo(Delegate delObj)
        {
            foreach (Delegate d in delObj.GetInvocationList())
            {
                Console.WriteLine("Method name: {0}", d.Method);
                Console.WriteLine("Type name: {0}", d.Target);
            }
        }
    }
}
