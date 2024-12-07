using Salon.dbo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Classs
{
    public class Master
    {
        public int ID_Master { get; set; }
        public string FIO { get; set; }
        public string Specializaciya { get; set; }
        public string Telefon { get; set; }
        public double Reiting { get; set; }

        // Навигационные свойства
        public ICollection<Zapisi> Zapisi { get; set; }
        public ICollection<Zarplati> Zarplati { get; set; }
    }
}
