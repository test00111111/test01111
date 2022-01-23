namespace test.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("delivery")]
    public partial class delivery
    {
        public int id { get; set; }

        public int orderId { get; set; }

        [Required]
        [StringLength(255)]
        public string deliveryType { get; set; }

        public int DeliveryState { get; set; }
    }
}
