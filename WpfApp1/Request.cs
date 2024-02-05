//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Request
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Request()
        {
            this.Tasks = new HashSet<Tasks>();
        }
    
        public int request_id { get; set; }
        public int customer_id { get; set; }
        public Nullable<System.DateTime> date_requested { get; set; }
        public string content { get; set; }
        public Nullable<System.DateTime> deadline { get; set; }
        public string platforms_required { get; set; }
        public int department_id { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Departament Departament { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tasks> Tasks { get; set; }
    }
}