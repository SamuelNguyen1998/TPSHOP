using TPSHOP.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TPSHOP.DAO
{
    public class SanPhamDAO
    {
        TPSHOPDbContex db;
        public SanPhamDAO()
        {
            db = new TPSHOPDbContex();
        }

        public IQueryable<SanPham> ListSP()
        {
            var res = (from sp in db.SanPham select sp);
            return res;
        }

        public IQueryable<SanPham> ListSP(int? dm)
        {
            var res = (from sp in db.SanPham where sp.madanhmuc==dm select sp);
            return res;
        }
        public IQueryable<SanPham> ListSPTL(int? tl)
        {
            var res = (from sp in db.SanPham where sp.mastyle == tl select sp);
            return res;
        }
        public List<SanPham> listspTimkiem(string tensp)
        {
            string search = "select * from SanPham where ten like '%" + tensp + "%'";
            var rs = db.SanPham.SqlQuery(search).ToList();
            return rs;
        }
    }
}