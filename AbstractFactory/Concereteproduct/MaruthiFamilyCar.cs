using AbstractFactory.Abstractproduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractFactory.Concereteproduct
{
    public class MaruthiFamilyCar : FamilyCar
    {
        public override void Speed()
        {
            MessageBox.Show("Maruthi Family car is slower than VW Family Car");
        }
    }
}
