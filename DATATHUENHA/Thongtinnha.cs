namespace Thuenha.DATATHUENHA
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Thongtinnha")]
    public partial class Thongtinnha
    {
        [Key]
        [StringLength(10)]
        public string manha { get; set; }

        [Required]
        [StringLength(10)]
        public string maloainha { get; set; }

        [Required]
        [StringLength(50)]
        public string dientich { get; set; }

        public int sophongngu { get; set; }

        public int sonvs { get; set; }

        [Required]
        public string diachi { get; set; }

        [Required]
        [StringLength(50)]
        public string giatien { get; set; }

        [Required]
        [StringLength(50)]
        public string ngaydang { get; set; }

        public virtual phanloainha phanloainha { get; set; }
    }
}
