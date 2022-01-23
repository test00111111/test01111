namespace test.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("refund")]
    public partial class refund
    {
        public int id { get; set; }

        public int orderId { get; set; }

        public int refundState { get; set; }

        [StringLength(255)]
        public string refundReason { get; set; }
    }
}
