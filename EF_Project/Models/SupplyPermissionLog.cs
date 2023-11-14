namespace EF_Project
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SupplyPermissionLog")]
    public partial class SupplyPermissionLog
    {
        public int SupplyPermissionLogId { get; set; }

        [Required]
        [StringLength(10)]
        public string Quantity { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ProductionDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ExpireDat { get; set; }

        public int? Fk_SupplyPermissionId { get; set; }

        public int? Fk_SupplierID { get; set; }

        public int? Fk_ProductID { get; set; }

        public virtual Product Product { get; set; }

        public virtual Supplier Supplier { get; set; }

        public virtual SupplyPermission SupplyPermission { get; set; }
    }
}
