using AbstractFactory.Abstractproduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractFactory.Concereteproduct
{
    public class VWFamilyCar : FamilyCar
    {
        public override void Speed()
        {
            MessageBox.Show("VW family car has decent speed");
        }
    }
}
