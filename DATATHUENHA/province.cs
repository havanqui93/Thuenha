namespace Thuenha.DATATHUENHA
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class province
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public province()
        {
            districts = new HashSet<district>();
        }

        [Key]
        [StringLength(20)]
        public string code { get; set; }

        [Required]
        [StringLength(255)]
        public string name { get; set; }

        [StringLength(255)]
        public string name_en { get; set; }

        [Required]
        [StringLength(255)]
        public string full_name { get; set; }

        [StringLength(255)]
        public string full_name_en { get; set; }

        [StringLength(255)]
        public string code_name { get; set; }

        public int? administrative_unit_id { get; set; }

        public int? administrative_region_id { get; set; }

        public virtual administrative_regions administrative_regions { get; set; }

        public virtual administrative_units administrative_units { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<district> districts { get; set; }
    }
}
