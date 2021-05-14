using System;

namespace ComputerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Development PC Configurations---");
            var devpc = new Development();
            var director = new Director(devpc);
            Console.WriteLine(director.BuildComp().ToString());

            Console.WriteLine("---Gaming PC Configurations ---");
            var gamingpc = new Gaming();
            director = new Director(gamingpc);
            Console.WriteLine(director.BuildComp().ToString());


            Console.WriteLine("---Custom PC Configurations ---");


       }
    }
}


