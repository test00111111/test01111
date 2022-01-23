namespace test.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("catalogB")]
    public partial class catalogB
    {
        public int id { get; set; }

        [Required]
        [StringLength(255)]
        public string catalogBName { get; set; }
    }
}
