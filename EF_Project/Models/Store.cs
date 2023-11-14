namespace EF_Project
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Store")]
    public partial class Store
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Store()
        {
            Orders = new HashSet<Order>();
            SupplyPermissions = new HashSet<SupplyPermission>();
            Transfers = new HashSet<Transfer>();
            Transfers1 = new HashSet<Transfer>();
        }

        public int StoreID { get; set; }

        [Required]
        [StringLength(10)]
        public string Name { get; set; }

        [Required]
        [StringLength(10)]
        public string Address { get; set; }

        public int? EmployeManger { get; set; }

        public virtual EmployeeManger EmployeeManger { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SupplyPermission> SupplyPermissions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transfer> Transfers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transfer> Transfers1 { get; set; }
    }
}
