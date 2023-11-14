namespace EF_Project
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Transfer")]
    public partial class Transfer
    {
        public int TransferID { get; set; }

        [Required]
        [StringLength(10)]
        public string Quantity { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ProductionDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ExpireDate { get; set; }

        public int? Fk_FromStoreID { get; set; }

        public int? Fk_ToStoreID { get; set; }

        public int? Fk_SupplierID { get; set; }

        public int? Fk_ProductID { get; set; }

        public virtual Product Product { get; set; }

        public virtual Store Store { get; set; }

        public virtual Store Store1 { get; set; }

        public virtual Supplier Supplier { get; set; }
    }
}
