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
        [Column("Giá cao nhất", Order = 0)]
        [StringLength(30)]
        public string Giá_cao_nhất { get; set; }

        [Key]
        [Column("Giá thấp nhất", Order = 1)]
        [StringLength(30)]
        public string Giá_thấp_nhất { get; set; }
    }
}
