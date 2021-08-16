using Controle.Data;
using Controle.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Controle.Controllers
{
    public class MarcaController : Controller
    {
        private readonly ApplicationDbContext _db;

        public MarcaController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Marca> objList = _db.Marcas;
            return View(objList);
        }
        //Get-Create
        public IActionResult Create()
        {
            return View();
        }

        //Post-Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Marca obj)
        {
            if (ModelState.IsValid)
            {
                _db.Marcas.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }


        //Get-Delete
     
        public IActionResult Delete(int? id)
        {
            
            if (id== null || id==0)
            {
                return NotFound();

            }
            var obj = _db.Marcas.Find(id);
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
            var obj = _db.Marcas.Find(id);
            if (obj == null)
            {
                return NotFound();

            }
            _db.Marcas.Remove(obj);
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
            var obj = _db.Marcas.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        //Post-Update
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Marca obj)
        {
            if (ModelState.IsValid)
            {
                _db.Marcas.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

      

    }

}