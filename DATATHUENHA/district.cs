namespace Thuenha.DATATHUENHA
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class district
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public district()
        {
            wards = new HashSet<ward>();
        }

        [Key]
        [StringLength(20)]
        public string code { get; set; }

        [Required]
        [StringLength(255)]
        public string name { get; set; }

        [StringLength(255)]
        public string name_en { get; set; }

        [StringLength(255)]
        public string full_name { get; set; }

        [StringLength(255)]
        public string full_name_en { get; set; }

        [StringLength(255)]
        public string code_name { get; set; }

        [StringLength(20)]
        public string province_code { get; set; }

        public int? administrative_unit_id { get; set; }

        public virtual administrative_units administrative_units { get; set; }

        public virtual province province { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ward> wards { get; set; }
    }
}
