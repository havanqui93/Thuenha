namespace Thuenha.DATATHUENHA
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Gia")]
    public partial class Gia
    {
        [Key]
        [StringLength(10)]
        public string code { get; set; }

        [Column("Gia")]
        [Required]
        [StringLength(30)]
        public string Gia1 { get; set; }
    }
}
