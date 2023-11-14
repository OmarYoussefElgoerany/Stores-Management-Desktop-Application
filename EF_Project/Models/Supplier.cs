namespace EF_Project
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Supplier")]
    public partial class Supplier
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Supplier()
        {
            OrderLogs = new HashSet<OrderLog>();
            Transfers = new HashSet<Transfer>();
            SupplyPermissionLogs = new HashSet<SupplyPermissionLog>();
        }

        public int SupplierId { get; set; }

        [Required]
        [StringLength(10)]
        public string Name { get; set; }

        public int? Phone { get; set; }

        public int? Fax { get; set; }

        public int? Mobile { get; set; }

        [StringLength(10)]
        public string Mail { get; set; }

        [StringLength(10)]
        public string URL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderLog> OrderLogs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transfer> Transfers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SupplyPermissionLog> SupplyPermissionLogs { get; set; }
    }
}
