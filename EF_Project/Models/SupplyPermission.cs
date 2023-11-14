namespace EF_Project
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SupplyPermission")]
    public partial class SupplyPermission
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SupplyPermission()
        {
            SupplyPermissionLogs = new HashSet<SupplyPermissionLog>();
        }

        public int SupplyPermissionId { get; set; }

        public int SerialNum { get; set; }

        [Column(TypeName = "date")]
        public DateTime? date { get; set; }

        public int? Fk_StoreID { get; set; }

        public virtual Store Store { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SupplyPermissionLog> SupplyPermissionLogs { get; set; }
    }
}
