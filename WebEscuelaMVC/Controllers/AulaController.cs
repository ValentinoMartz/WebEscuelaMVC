using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using WebEscuelaMVC.Data;
using WebEscuelaMVC.Models;

namespace WebEscuelaMVC.Controllers
{
    public class AulaController : Controller
    {

        private readonly WebEscuelaMVCContext context;

        public AulaController(WebEscuelaMVCContext context)
        {
            this.context = context;
        }

        //Get aula/index
        [HttpGet]
        public IActionResult Index()
        {
            var aulas = context.Aulas.ToList();
            return View(aulas);
        }

        [HttpGet]
        public ActionResult Create()
        {
            Aula aula = new Aula();
            return View("Register", aula);
        }

        [HttpPost]
        public ActionResult Create(Aula aula)
        {
            if (ModelState.IsValid)
            {
                context.Aulas.Add(aula);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(aula);
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            var aula = TraerUna(id);
            if (aula == null)
            {
                return NotFound();
            }
            else
            {
                return View("Detalle", aula);
            }
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Aula aula = TraerUna(id);
            return View("Edit", aula);
        }

        [HttpPost]
        [ActionName("Edit")]
        public ActionResult EditConfirmed(int id, Aula aula)
        {
            if (id != aula.Id)
            {
                return NotFound();
            }
            else
            {
                context.Entry(aula).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
        }


        //Get medico/delete
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var aula = TraerUna(id);
            if (aula == null)
            {
                return NotFound();
            }
            else
            {
                return View("Delete", aula);//Devuelve el hmlt(View) al cliente
            }
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var aula = TraerUna(id);
            if (aula == null)
            {
                return NotFound();
            }
            else
            {
                context.Aulas.Remove(aula);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        private Aula TraerUna(int id)
        {
            return context.Aulas.Find(id);
        }

    }
}
