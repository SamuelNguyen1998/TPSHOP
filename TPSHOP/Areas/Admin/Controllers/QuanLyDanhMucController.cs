using TPSHOP.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TPSHOP.Areas.Admin.Controllers
{
    public class QuanLyDanhMucController : Controller
    {
        TPSHOPDbContex db = new TPSHOPDbContex();
        // GET: Admin/QuanLyDanhMuc
        public ActionResult Category()
        {
            return View(db.DanhMuc.ToList().OrderBy(x => x.ma));
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(DanhMuc dm)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.DanhMuc.Add(dm);
                    db.SaveChanges();
                    return RedirectToAction("Category");
                }
                else
                    return View(dm);
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            DanhMuc dm = db.DanhMuc.SingleOrDefault(x => x.ma == id);
            if (dm == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            else
            {
                return View(dm);
            }
        }

        [HttpPost]
        public ActionResult Edit(DanhMuc dmcs)
        {
            if (ModelState.IsValid)
            {
                DanhMuc dm = db.DanhMuc.Find(dmcs.ma);

                dm.tendanhmuc = dmcs.tendanhmuc;

                db.SaveChanges();

                return RedirectToAction("Category");
            }
            else
            {
                return View(dmcs);
            }
        }

        public ActionResult Delete(int id)
        {
            DanhMuc dm = db.DanhMuc.Find(id);
            db.DanhMuc.Remove(dm);
            db.SaveChanges();
            return Redirect(Request.UrlReferrer.ToString());
        }
    }
}