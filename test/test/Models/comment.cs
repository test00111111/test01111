namespace test.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("comment")]
    public partial class comment
    {
        public int id { get; set; }

        public int memberId { get; set; }

        public int orderDetailId { get; set; }

        [Column("comment")]
        [StringLength(255)]
        public string comment1 { get; set; }

        public int score { get; set; }

        public int skuId { get; set; }
    }
}
