namespace test.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("cart")]
    public partial class cart
    {
        public int id { get; set; }

        public int memberId { get; set; }

        public int spuId { get; set; }

        public int num { get; set; }

        public int totalPrice { get; set; }

        public bool paid { get; set; }
    }
}
