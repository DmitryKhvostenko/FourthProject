using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Bus bus = new Bus();
            Minibus minibus = new Minibus();
            car.ShowPoperties();
            bus.ShowPoperties();
            minibus.ShowPoperties();
            Console.ReadLine();
        }
    }
}
