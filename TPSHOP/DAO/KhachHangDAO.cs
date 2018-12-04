using TPSHOP.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TPSHOP.DAO
{
    public class KhachHangDAO
    {
        TPSHOPDbContex db;
        public KhachHangDAO()
        {
            db = new TPSHOPDbContex();
        }
        public IQueryable<KhachHang> listKH()
        {
            var res = (from kh in db.KhachHang select kh);
            return res;
        }
    }
}