using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TPSHOP.Models
{
    public class SanPhamModel
    {
        public string img { get; set; }

        public SanPhamModel() { }

        public SanPhamModel(string url) { img = url; }
    }
}