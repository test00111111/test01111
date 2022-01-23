using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using test.Models;

namespace test.ViewModel
{
    public class CommonViewModel
    {
        public IEnumerable<carousel> carousels { get; set; }
        public IEnumerable<spu> spu { get; set; }
        public IEnumerable<catalogB> category { get; set; }
    }
}