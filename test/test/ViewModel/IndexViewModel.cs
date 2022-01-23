using test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using test.Models;

namespace test.ViewModel
{
    public class IndexViewModel
    {
        public IEnumerable<carousel> carousels { get; set; }
        public IEnumerable<spu> spu { get; set; }

        public IndexViewModel()
        {
            shop123Entities db = new shop123Entities();
            this.carousels = db.carousel.ToList();
            this.spu = db.spu.ToList();

        }
    }
}