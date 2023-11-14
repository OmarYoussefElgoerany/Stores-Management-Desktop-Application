namespace EF_Project
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmployeeManger")]
    public partial class EmployeeManger
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EmployeeManger()
        {
            Stores = new HashSet<Store>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(10)]
        public string Name { get; set; }

        [StringLength(10)]
        public string Role { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Store> Stores { get; set; }
    }
}
