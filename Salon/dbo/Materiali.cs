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
    
    public partial class Materiali
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Materiali()
        {
            this.Rashodi_Materialov = new HashSet<Rashodi_Materialov>();
        }
    
        public int Id_Materiala { get; set; }
        public string Nazvanie { get; set; }
        public Nullable<int> Kolichestvo { get; set; }
        public Nullable<int> Id_Uslugi { get; set; }
        public Nullable<System.DateTime> Srok_godnosti { get; set; }
        public Nullable<int> Id_Uvedi { get; set; }
    
        public virtual Uslugi Uslugi { get; set; }
        public virtual Uvedi Uvedi { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rashodi_Materialov> Rashodi_Materialov { get; set; }
    }
}
