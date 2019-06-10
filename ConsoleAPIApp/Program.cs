using ConsoleAPIApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAPIApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calling the method
            RoadRepository methods = new RoadRepository();
            methods.roadStatus(args.FirstOrDefault());
            Console.WriteLine("Press any key to exit... ");
            Console.ReadLine();
        }
    }
}
