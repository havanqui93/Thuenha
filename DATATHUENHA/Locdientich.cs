namespace Thuenha.DATATHUENHA
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Locdientich")]
    public partial class Locdientich
    {
        [Key]
        [StringLength(10)]
        public string code { get; set; }

        [Column("locdientich")]
        [Required]
        public string locdientich1 { get; set; }
    }
}
