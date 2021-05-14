using System;

namespace ComputerApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var builder = new Builder();
            var director = new Director(builder);
            Console.WriteLine("---Development PC Configurations---");

            Console.WriteLine(director.BuildGamingComputer().ListComponents());

            Console.WriteLine("---Gaming PC Configurations ---");
            builder.Reset();
            director.Builder = builder;
            Console.WriteLine(director.BuildDevComputer().ListComponents());


            Console.WriteLine("---Custom PC Configurations ---");
            builder.Reset();
            director.Builder = builder;
            Console.WriteLine(director.BuildCustomComputer("Windows",
                "HDD", "AMD", "Intel", "128").ListComponents());
        }
    }
}