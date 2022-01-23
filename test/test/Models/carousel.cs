namespace test.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("carousel")]
    public partial class carousel
    {
        public int id { get; set; }

        [Required]
        [StringLength(255)]
        public string catalogAId { get; set; }

        [Required]
        [StringLength(255)]
        public string catalogBId { get; set; }

        [Required]
        [StringLength(255)]
        public string carouselImg { get; set; }
    }
}
