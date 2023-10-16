namespace Thuenha.DATATHUENHA
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Dangky")]
    public partial class Dangky
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string User { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string Pass { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string Ho { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(10)]
        public string Ten { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime Ngaysinh { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(10)]
        public string Gioitinh { get; set; }

        public virtual Dangnhap Dangnhap { get; set; }
    }
}
