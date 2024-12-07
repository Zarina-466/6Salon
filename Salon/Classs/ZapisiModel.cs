using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Classs
{
    public class ZapisiModel
    {
        public int ID_Zapisi { get; set; }
        public int ID_Klient { get; set; }
        public int ID_Master { get; set; }
        public int ID_Uslugi { get; set; }
        public DateTime Data { get; set; }
        public TimeSpan Vremya { get; set; }
        public string Status { get; set; }
    }
}