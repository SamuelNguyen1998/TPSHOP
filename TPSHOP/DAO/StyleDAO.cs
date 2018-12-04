using TPSHOP.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TPSHOP.DAO
{
    public class StyleDAO
    {
        TPSHOPDbContex db;
        public StyleDAO()
        {
            db = new TPSHOPDbContex();
        }

        public IQueryable<Style> ListDanhMuc()
        {
            var res = (from st in db.Style select st);
            return res;
        }
    }
}