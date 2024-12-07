using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Classs
{
    public class RashodiMaterialov
    {
        public int ID_Rashoda { get; set; }
        public int ID_Uslugi { get; set; }
        public int ID_Materiala { get; set; }
        public int Kolichestvo { get; set; }

        // Навигационные свойства
        public Uslugi Uslugi { get; set; }
        public Materiali Materiali { get; set; }
    }
}