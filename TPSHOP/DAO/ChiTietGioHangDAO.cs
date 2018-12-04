using TPSHOP.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TPSHOP.DAO
{
    public class ChiTietGioHangDAO
    {
        TPSHOPDbContex db;
        public ChiTietGioHangDAO()
        {
            db = new TPSHOPDbContex();
        }
        public IQueryable<ChiTietGioHang> ChiTietGH(int mahd)
        {
            var res = (from sp in db.ChiTietGioHang where sp.magiohang == mahd select sp);
            return res;
        }
    }
}