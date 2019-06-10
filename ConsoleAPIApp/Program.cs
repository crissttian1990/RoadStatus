using ConsoleAPIApp.Model;
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
            // Getting connection string and details
            SettingsModel settings = new SettingsModel();

            // Calling the method
            RoadRepository methods = new RoadRepository();
            methods.roadStatus(args.FirstOrDefault(), settings);
            Console.WriteLine("Press any key to exit... ");
            Console.ReadLine();
        }
    }
}
