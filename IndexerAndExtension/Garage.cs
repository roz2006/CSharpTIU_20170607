using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerAndExtension
{
   public class Garage
    {
        private List<Car> CarList;
        public Car this[string ix]
        {
            get { return CarList.Find(car => car.Name==ix); }
            set {  }
        }

        public Garage()
        {
            CarList = new List<Car>();
        }

        public void AddCar(Car c)
        {
            CarList.Add(c);
        }
    }
}
