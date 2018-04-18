using AbstractFactory.AbstractFactory;
using AbstractFactory.Abstractproduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.ConcereteFactory
{
    public class VWFactory : CarFactory
    {
        public override FamilyCar CreateFamilyCar()
        {
            throw new NotImplementedException();
        }

        public override SportsCar CreateSportsCar()
        {
            throw new NotImplementedException();
        }
    }
}
