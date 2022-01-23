namespace test.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("catalogA")]
    public partial class catalogA
    {
        public int id { get; set; }

        [Required]
        [StringLength(255)]
        public string catalogAName { get; set; }
    }
}
