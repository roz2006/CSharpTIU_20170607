using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerAndExtension
{
    public static class MyExtension
    {
        public static void Print(this DateTime dt)
        {
            Console.WriteLine("At {0} extension print is called",dt.Date);
        }

        public static void AddCartoGarage(this Garage g, Car c)
        {
            g.AddCar(c);
        }
    }
}
