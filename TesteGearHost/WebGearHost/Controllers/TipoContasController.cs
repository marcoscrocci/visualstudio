using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ControleFinanceiroWeb.Models;
using WebGearHost.Models;

namespace WebGearHost.Controllers
{
    public class TipoContasController : Controller
    {
        private GearHostDBContext db = new GearHostDBContext();

        // GET: TipoContas
        public async Task<ActionResult> Index()
        {
            return View(await db.TipoContas.ToListAsync());
        }

        // GET: TipoContas/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoConta tipoConta = await db.TipoContas.FindAsync(id);
            if (tipoConta == null)
            {
                return HttpNotFound();
            }
            return View(tipoConta);
        }

        // GET: TipoContas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoContas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Nome")] TipoConta tipoConta)
        {
            if (ModelState.IsValid)
            {
                db.TipoContas.Add(tipoConta);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(tipoConta);
        }

        // GET: TipoContas/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoConta tipoConta = await db.TipoContas.FindAsync(id);
            if (tipoConta == null)
            {
                return HttpNotFound();
            }
            return View(tipoConta);
        }

        // POST: TipoContas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Nome")] TipoConta tipoConta)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipoConta).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(tipoConta);
        }

        // GET: TipoContas/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoConta tipoConta = await db.TipoContas.FindAsync(id);
            if (tipoConta == null)
            {
                return HttpNotFound();
            }
            return View(tipoConta);
        }

        // POST: TipoContas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            TipoConta tipoConta = await db.TipoContas.FindAsync(id);
            db.TipoContas.Remove(tipoConta);
            await db.SaveChangesAsync();
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
