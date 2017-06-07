using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerAndExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            Garage g1 = new Garage();
            g1.AddCar(new Car("Car1", 1980));
            g1.AddCartoGarage(new Car("Car2", 2017));

            Console.WriteLine(g1["Car1"].Year);
            Console.WriteLine(g1["Car2"].Year);
            MyExtension.Print(new DateTime());
            DateTime dt1 = new DateTime();
            dt1.Print();
        }
    }
}
