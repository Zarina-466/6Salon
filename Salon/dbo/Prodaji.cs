//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Salon.dbo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Prodaji
    {
        public int Id_Prodaji { get; set; }
        public Nullable<int> Id_Klienta { get; set; }
        public Nullable<int> Id_Uslugi { get; set; }
        public Nullable<System.DateTime> Data { get; set; }
        public Nullable<int> Summa { get; set; }
    
        public virtual Otzivi Otzivi { get; set; }
        public virtual Uslugi Uslugi { get; set; }
    }
}