namespace test.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("like")]
    public partial class like
    {
        public int id { get; set; }

        public int spuId { get; set; }

        public int memberId { get; set; }
    }
}
