using TPSHOP.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TPSHOP.DAO
{
    public class GioHangDAO
    {
        TPSHOPDbContex db;
        public GioHangDAO()
        {
            db = new TPSHOPDbContex();
        }
    }
}