//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project_Work_WPF
{
    using System;
    using System.Collections.Generic;
    
    public partial class TAXIUSER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TAXIUSER()
        {
            this.TAXIORDER = new HashSet<TAXIORDER>();
            this.USERHISTORY = new HashSet<USERHISTORY>();
        }
    
        public decimal ID { get; set; }
        public Nullable<decimal> TYPEID { get; set; }
        public string USERLOGIN { get; set; }
        public string USERPASSWORD { get; set; }
        public string USERNAME { get; set; }
        public string USERSURNAME { get; set; }
        public string USERNUMBER { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TAXIORDER> TAXIORDER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USERHISTORY> USERHISTORY { get; set; }
        public virtual TYPEOFUSER TYPEOFUSER { get; set; }
    }
}