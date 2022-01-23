namespace test.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("spu")]
    public partial class spu
    {
        public int id { get; set; }

        [Required]
        [StringLength(255)]
        public string spuName { get; set; }

        public int memberId { get; set; }

        [Required]
        public string spuInfo { get; set; }

        public int spuPrice { get; set; }

        public int catalogAId { get; set; }

        public int catalogBId { get; set; }

        [Required]
        [StringLength(255)]
        public string spuImg1 { get; set; }

        [StringLength(255)]
        public string spuImg2 { get; set; }

        [StringLength(255)]
        public string spuImg3 { get; set; }

        [StringLength(255)]
        public string spuImg4 { get; set; }

        [StringLength(255)]
        public string spuImg5 { get; set; }

        [Required]
        [StringLength(255)]
        public string spuShow { get; set; }

        public DateTime spuCreatedTime { get; set; }

        public DateTime spuEditTime { get; set; }
    }
}
