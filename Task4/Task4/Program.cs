using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {



            while (true)
            {
                Console.Clear();
                Console.Write("Введите ключ: ");

                string msg = Console.ReadLine();
                ApplicationLicense applicationLicense = new ApplicationLicense(msg);

                break;
            }
            Console.ReadLine();
        }
    }
}

