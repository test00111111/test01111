namespace test.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sku")]
    public partial class sku
    {
        public int id { get; set; }

        public int spuId { get; set; }

        [Required]
        [StringLength(255)]
        public string skuColor { get; set; }

        [Required]
        [StringLength(255)]
        public string skuSize { get; set; }

        [StringLength(255)]
        public string skuImg { get; set; }

        public int skuStock { get; set; }
    }
}
