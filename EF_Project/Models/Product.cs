namespace EF_Project
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            OrderLogs = new HashSet<OrderLog>();
            Transfers = new HashSet<Transfer>();
            SupplyPermissionLogs = new HashSet<SupplyPermissionLog>();
        }

        public int ProductId { get; set; }

        public int Code { get; set; }

        [Required]
        [StringLength(10)]
        public string Name { get; set; }

        public int? Fk_UnitID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderLog> OrderLogs { get; set; }

        public virtual Unit Unit { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transfer> Transfers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SupplyPermissionLog> SupplyPermissionLogs { get; set; }
    }
}
