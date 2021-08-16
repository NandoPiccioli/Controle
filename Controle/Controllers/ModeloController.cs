using Controle.Data;
using Controle.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace Controle.Controllers
{
    public class ModeloController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ModeloController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult New()
        {
            var Modelo = _db.Modelos.ToList();

            return View();
        }

        public IActionResult Index()
        {
            ViewBag.Marca = _db.Marcas; ;
            IEnumerable <Modelos> objList = _db.Modelos;
            return View(objList);
        }


        public IActionResult Create()
        {
           ViewBag.Marca = _db.Marcas;
           var obj = new Modelos();
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Modelos obj)
        {
            ViewBag.Marca = _db.Marcas;
            //if (ModelState.IsValid)
            //{
            _db.Modelos.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            //}
            //return View(obj);
        }


        //Get-Delete

        public IActionResult Delete(int? id)
        {

            if (id == null || id == 0)
            {
                return NotFound();

            }
            ViewBag.Marca = _db.Marcas;
            var obj = _db.Modelos.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }



        //Post-Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            ViewBag.Marca = _db.Marcas;
            var obj = _db.Modelos.Find(id);
            if (obj == null)
            {
                return NotFound();

            }
            _db.Modelos.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }


        //Get Update

        public IActionResult Update(int? id)
        {

            if (id == null || id == 0)
            {
                return NotFound();

            }
            ViewBag.Marca = _db.Marcas;
            var obj = _db.Modelos.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        //Post-Update
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Modelos obj)
        {
            ViewBag.Marca = _db.Marcas;
            //if (ModelState.IsValid)
            //{
            _db.Modelos.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
           // }
            //return View(obj);
        }

    }

}
