﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Transport
    {
        public int Speed { get; set; }
        public int Passengers { get; set; }

        public void ShowPoperties()
        {
            Console.WriteLine(GetType().Name);
            foreach (var propertyInfo in GetType().GetProperties())
            {
                Console.WriteLine($"{propertyInfo.PropertyType} {propertyInfo.Name}");
            }
            Console.WriteLine();
        }
    }
}
