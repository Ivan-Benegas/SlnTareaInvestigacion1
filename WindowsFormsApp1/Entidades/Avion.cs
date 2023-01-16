using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entidades
{
    public class Avion
    {
        public string Piloto { get; set; }
        public string Copiloto { get; set; }
        public string Azafata { get; set; }

        public string Aterriza()
        {
            return "El avión aterrizó.";
        }

        public string Despega()
        {
            return "El avión despegó.";
        }

    }
}
