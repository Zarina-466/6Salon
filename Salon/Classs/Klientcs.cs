using Salon.dbo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Classs
{
    public class Klient
    {
        public int ID_Klient { get; set; }
        public string FIO { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public DateTime? DataRozhdeniya { get; set; }

        // Навигационные свойства
        public ICollection<Zapisi> Zapisi { get; set; }
    }
}
