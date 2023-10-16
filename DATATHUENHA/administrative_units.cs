namespace Thuenha.DATATHUENHA
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class administrative_units
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public administrative_units()
        {
            districts = new HashSet<district>();
            provinces = new HashSet<province>();
            wards = new HashSet<ward>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(255)]
        public string full_name { get; set; }

        [StringLength(255)]
        public string full_name_en { get; set; }

        [StringLength(255)]
        public string short_name { get; set; }

        [StringLength(255)]
        public string short_name_en { get; set; }

        [StringLength(255)]
        public string code_name { get; set; }

        [StringLength(255)]
        public string code_name_en { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<district> districts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<province> provinces { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ward> wards { get; set; }
    }
}
