using Salon.dbo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Classs
{
    public class Materiali
    {
        public int ID_Materiala { get; set; }
        public string Nazvanie { get; set; }
        public int Kolichestvo { get; set; }
        public DateTime SrokGodnosti { get; set; }
        public string EdIzmereniya { get; set; }

        // Навигационные свойства
        public ICollection<RashodiMaterialov> RashodiMaterialov { get; set; }
    }
}