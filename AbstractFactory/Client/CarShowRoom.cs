using AbstractFactory.AbstractFactory;
using AbstractFactory.ConcereteFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Client
{
    public class CarShowRoom
    {
        public static CarFactory GetCar(string carName)
        {
            if(carName == "Maruthi")
            {
                return new MaruthiFactory();
            }
            else
            {
                return new VWFactory();
            }
        }

    }
}
