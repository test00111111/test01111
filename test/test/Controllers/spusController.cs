using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using test.Models;

namespace test.Controllers
{
    public class spusController : Controller
    {
        private shop123Entities db = new shop123Entities();

        // GET: spus
        public ActionResult Index()
        {
            return View(db.spu.ToList());
        }

        // GET: spus/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            spu spu = db.spu.Find(id);
            if (spu == null)
            {
                return HttpNotFound();
            }
            return View(spu);
        }

        // GET: spus/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: spus/Create
        // 若要避免過量張貼攻擊，請啟用您要繫結的特定屬性。
        // 如需詳細資料，請參閱 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,spuName,memberId,spuInfo,spuPrice,catalogAId,catalogBId,spuImg1,spuImg2,spuImg3,spuImg4,spuImg5,spuShow,spuCreatedTime,spuEditTime")] spu spu)
        {
            if (ModelState.IsValid)
            {
                db.spu.Add(spu);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(spu);
        }

        // GET: spus/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            spu spu = db.spu.Find(id);
            if (spu == null)
            {
                return HttpNotFound();
            }
            return View(spu);
        }

        // POST: spus/Edit/5
        // 若要避免過量張貼攻擊，請啟用您要繫結的特定屬性。
        // 如需詳細資料，請參閱 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,spuName,memberId,spuInfo,spuPrice,catalogAId,catalogBId,spuImg1,spuImg2,spuImg3,spuImg4,spuImg5,spuShow,spuCreatedTime,spuEditTime")] spu spu)
        {
            if (ModelState.IsValid)
            {
                db.Entry(spu).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(spu);
        }

        // GET: spus/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            spu spu = db.spu.Find(id);
            if (spu == null)
            {
                return HttpNotFound();
            }
            return View(spu);
        }

        // POST: spus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            spu spu = db.spu.Find(id);
            db.spu.Remove(spu);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
