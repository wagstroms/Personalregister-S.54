using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personalregister
{
    public class Anställd
    {
        public string namn { get; set; }
    }
    public class Säljare : Anställd
    {
        public double försäljning { get; set; }
        public double provision { get; set; }

        public Säljare(string namn, double försäljning, double provision)
        {
            this.namn = namn;
            this.försäljning = försäljning;
            this.provision = provision;
        }
    }
    public class Konsult : Anställd
    {
        public double timLön { get; set; }
        public double arbetadeTimmar { get; set; }
        
        public Konsult(string namn, double timLön, double arbetadeTimmar)
        {
            this.namn = namn;
            this.timLön = timLön;
            this.arbetadeTimmar = arbetadeTimmar;
        }

    }
    public class Kontorist : Anställd
    {
        public double månadsLön { get; set; }

        public Kontorist(string namn, double månadsLön)
        {
            this.namn = namn;
            this.månadsLön = månadsLön;
        }
    }
}

