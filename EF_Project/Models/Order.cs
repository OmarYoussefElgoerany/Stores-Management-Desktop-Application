namespace EF_Project
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            OrderLogs = new HashSet<OrderLog>();
        }

        public int OrderID { get; set; }

        [Required]
        [StringLength(10)]
        public string SerialNum { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }

        public int? Fk_StoreID { get; set; }

        public int? Fk_CustomerID { get; set; }

        public virtual Customer Customer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderLog> OrderLogs { get; set; }

        public virtual Store Store { get; set; }
    }
}
