namespace test.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("member")]
    public partial class member
    {
        public int id { get; set; }

        [Required]
        [StringLength(255)]
        public string memberAccount { get; set; }

        [Required]
        [StringLength(255)]
        public string memberPassword { get; set; }

        [Required]
        [StringLength(255)]
        public string memberName { get; set; }

        [StringLength(50)]
        public string memberPhone { get; set; }

        [Required]
        [StringLength(255)]
        public string memberEmail { get; set; }

        [StringLength(255)]
        public string memberImg { get; set; }

        public bool? memberBanned { get; set; }

        public int memberAccess { get; set; }

        public DateTime memberCreateTime { get; set; }
    }
}
