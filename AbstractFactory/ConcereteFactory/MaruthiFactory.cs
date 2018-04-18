using AbstractFactory.AbstractFactory;
using AbstractFactory.Abstractproduct;
using AbstractFactory.Concereteproduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.ConcereteFactory
{
    public class MaruthiFactory : CarFactory
    {
        public override FamilyCar CreateFamilyCar()
        {
            return new MaruthiFamilyCar();
        }

        public override SportsCar CreateSportsCar()
        {
            return new MaruthiSportsCar();
        }
    }
}
