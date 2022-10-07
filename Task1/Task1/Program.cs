using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parent parent = new Parent();   
            parent.Show("Слово", 16, true);

            Output child = new Output();
            child.Show("Фраза", 23, false);

            Console.ReadLine();
        }
    }
}
