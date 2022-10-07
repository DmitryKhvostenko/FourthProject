using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Output : Parent
    {
        Random random = new Random();

        public override void Show(params object[] items)
        {
            foreach (var item in items)
            {
                Console.ForegroundColor = (ConsoleColor)random.Next(0, 16);
                Console.WriteLine($"Значение:"  + item + " Тип: " + item.GetType());
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
