namespace test.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("orderDetail")]
    public partial class orderDetail
    {
        public int id { get; set; }

        public int orderId { get; set; }

        public int skuId { get; set; }

        [Required]
        [StringLength(255)]
        public string orderDetailsize { get; set; }

        [Required]
        [StringLength(255)]
        public string orderDetailcolor { get; set; }

        public int orderDetailnum { get; set; }

        public int orderDetailprice { get; set; }
    }
}
