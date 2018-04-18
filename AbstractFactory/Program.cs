using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using System.Data;
using AbstractFactory.AbstractFactory;
using AbstractFactory.Client;

namespace AbstractFactory
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            CarFactory factory = CarShowRoom.GetCar("Maruthi");
            var car = factory.CreateFamilyCar();
            car.Speed();
                        
        }
    }
}
