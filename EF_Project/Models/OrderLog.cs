namespace EF_Project
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderLog")]
    public partial class OrderLog
    {
        public int OrderLogID { get; set; }

        [Required]
        [StringLength(10)]
        public string Quantity { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }

        public int? Fk_OrderID { get; set; }

        public int? Fk_SupplierID { get; set; }

        public int? Fk_ProductID { get; set; }

        public virtual Order Order { get; set; }

        public virtual Product Product { get; set; }

        public virtual Supplier Supplier { get; set; }
    }
}
