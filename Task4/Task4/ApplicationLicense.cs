using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class ApplicationLicense
    {
        public bool Common { get; set; }
        public bool Trial { get; set; }
        public bool Pro { get; set; }

        public string TrialKey { get; set; }
        public string ProKey { get; set; }

        public ApplicationLicense(string key)
        {
            this.TrialKey = "Trial";
            this.ProKey = "Pro";

            if (key == "Trial") { this.AllowTrial(); }
            else if (key == "Pro") { this.AllowPro(); }
            else {this.AllowCommon(); }
        }

        public void AllowCommon()
        {
            this.Common = true;
            Console.WriteLine("Неверный ключ. Ваша лицензия: 'Стандартная'!");
        }

        public void AllowTrial()
        {
            this.Trial = true;
            this.Common = false;
            Console.WriteLine("Ваша лицензия: 'Пробный период'");
        }

        public void AllowPro()
        {
            this.Pro = true;
            this.Common = false;
            Console.WriteLine("Ваша лицензия: 'Продвинутая'");
        }

    }
}
