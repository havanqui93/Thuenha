namespace Thuenha.DATATHUENHA
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("phanloainha")]
    public partial class phanloainha
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public phanloainha()
        {
            Thongtinnhas = new HashSet<Thongtinnha>();
        }

        [Key]
        [StringLength(10)]
        public string maloainha { get; set; }

        [Required]
        [StringLength(50)]
        public string loainha { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Thongtinnha> Thongtinnhas { get; set; }
    }
}
