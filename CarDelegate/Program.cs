using System;

namespace CarDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******* Delegates as event enablers ********\n");

            Car c1 = new Car("SlugBug", 100, 10);
            //Car.CarEngineHandler handler1 = new Car.CarEngineHandler(OnCarEngineEvent);
            //Car.CarEngineHandler handler2 = new Car.CarEngineHandler(OnCarEngineEvent2);
            //c1.RegisterWithCarEngine(handler1);
            //c1.RegisterWithCarEngine(handler2);

            c1.RegisterWithCarEngine(OnCarEngineEvent);

            Console.WriteLine("***** Speeding Up *****");
            for (int i = 0; i < 6; i++)
            {
                c1.Accelerate(20);
            }
            Console.ReadKey();
        }

        public static void OnCarEngineEvent(string msg)
        {
            Console.WriteLine("\n******* Message from Car Object ********");
            Console.WriteLine("=> {0}", msg);
            Console.WriteLine("****************************************");
        }

        public static void OnCarEngineEvent2(string msg)
        {
            Console.WriteLine("=> {0}", msg.ToUpper());
        }
    }
}
