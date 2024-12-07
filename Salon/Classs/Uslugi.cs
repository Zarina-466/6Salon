using Salon.dbo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Classs
{
    public class Uslugi
    {
        public int ID_Uslugi { get; set; }
        public string Nazvanie { get; set; }
        public string Opisanie { get; set; }
        public int Dlitelnost_Min { get; set; }
        public decimal Stoimost { get; set; }

        // Навигационные свойства
        public ICollection<Zapisi> Zapisi { get; set; }
        public ICollection<RashodiMaterialov> RashodiMaterialov { get; set; }
    }
}
