using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using test.Models;

namespace test.ViewModel
{
    public class WOMANViewModel
    {
        public IEnumerable<catalogB> Cat { get; set; }
        public IEnumerable<spu> spu { get; set; }

        public WOMANViewModel()
        {
            shop123Entities db = new shop123Entities();
            this.Cat = db.catalogB.ToList();            
            this.spu = db.spu.Where(m => m.catalogAId == 1).ToList();

        }
    }
}