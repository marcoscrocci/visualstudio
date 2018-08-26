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
    public class ContasController : Controller
    {
        private GearHostDBContext db = new GearHostDBContext();

        // GET: Contas
        public async Task<ActionResult> Index()
        {
            var contas = db.Contas.Include(c => c.TipoContaInfo);
            return View(await contas.ToListAsync());
        }

        // GET: Contas/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Conta conta = await db.Contas.FindAsync(id);
            if (conta == null)
            {
                return HttpNotFound();
            }
            return View(conta);
        }

        // GET: Contas/Create
        public ActionResult Create()
        {
            ViewBag.TipoContaId = new SelectList(db.TipoContas, "Id", "Nome");
            return View();
        }

        // POST: Contas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Titulo,SaldoInicial,TipoContaId,Observacoes")] Conta conta)
        {
            if (ModelState.IsValid)
            {
                db.Contas.Add(conta);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.TipoContaId = new SelectList(db.TipoContas, "Id", "Nome", conta.TipoContaId);
            return View(conta);
        }

        // GET: Contas/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Conta conta = await db.Contas.FindAsync(id);
            if (conta == null)
            {
                return HttpNotFound();
            }
            ViewBag.TipoContaId = new SelectList(db.TipoContas, "Id", "Nome", conta.TipoContaId);
            return View(conta);
        }

        // POST: Contas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Titulo,SaldoInicial,TipoContaId,Observacoes")] Conta conta)
        {
            if (ModelState.IsValid)
            {
                db.Entry(conta).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.TipoContaId = new SelectList(db.TipoContas, "Id", "Nome", conta.TipoContaId);
            return View(conta);
        }

        // GET: Contas/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Conta conta = await db.Contas.FindAsync(id);
            if (conta == null)
            {
                return HttpNotFound();
            }
            return View(conta);
        }

        // POST: Contas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Conta conta = await db.Contas.FindAsync(id);
            db.Contas.Remove(conta);
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
