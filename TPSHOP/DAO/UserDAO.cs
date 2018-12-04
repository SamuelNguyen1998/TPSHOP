using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TPSHOP.Entities;
namespace TPSHOP.DAO
{
    public class UserDAO
    {
        TPSHOPDbContex db;
        public UserDAO()
        {
            db = new TPSHOPDbContex();
        }
        public bool Login(string tk, string mk)
        {
            var res = db.User.Count(x => x.userName == tk && x.password == mk);
            if (res > 0)
                return true;
            else
                return false;
        }
    }
}