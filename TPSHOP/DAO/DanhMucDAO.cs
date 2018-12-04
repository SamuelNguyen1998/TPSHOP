using TPSHOP.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TPSHOP.DAO
{
    public class DanhMucDAO
    {
        TPSHOPDbContex db;
        public DanhMucDAO()
        {
            db = new TPSHOPDbContex();
        }

        public IQueryable<DanhMuc> ListDanhMuc()
        {
            var res = (from dm in db.DanhMuc select dm);
            return res;
        }

    }
}