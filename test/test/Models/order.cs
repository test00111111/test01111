namespace test.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("order")]
    public partial class order
    {
        public int id { get; set; }

        public int memberId { get; set; }

        public int deliveryId { get; set; }

        public DateTime orderCreateTime { get; set; }

        public DateTime? orderPaymentTime { get; set; }

        [Required]
        [StringLength(255)]
        public string receiverName { get; set; }

        [Required]
        [StringLength(255)]
        public string receiverAddress { get; set; }

        [Required]
        [StringLength(255)]
        public string receiverEmail { get; set; }

        [Required]
        [StringLength(255)]
        public string receiverPhone { get; set; }

        [Required]
        [StringLength(255)]
        public string orderState { get; set; }

        public int? refundId { get; set; }

        public int totalPrice { get; set; }
    }
}
