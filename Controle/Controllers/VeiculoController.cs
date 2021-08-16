using Controle.Models;
using Controle.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Controle.Controllers
{
    public class VeiculoController : Controller
    {
        private readonly ApplicationDbContext _db;

        public VeiculoController(ApplicationDbContext db)
        {
            _db = db;
        }

       public async Task<IActionResult> Index(string searchString)
        {
            var veiculos = from v in _db.Veiculos
                         select v;

            if (!String.IsNullOrEmpty(searchString))
            {
                //veiculos =  veiculos.Where(v => v.Modelo.Descricao.Contains(searchString));
            }

            return View(await veiculos.ToListAsync());
        }

        //public IActionResult Index()
        //{
        //    ViewBag.Modelo = new SelectList(_db.Modelos, "IDModelo", "Descricao");
        //    IEnumerable<Veiculo> objList = _db.Veiculos;
        //    return View(objList);
        //}





        //Get-Create
        [HttpGet]
        public IActionResult Create()
        {
            //ViewBag.Marca = new SelectList(_db.Marcas, "IDMarca", "Descricao");
            ViewBag.Marca = new SelectList(_db.Marcas, "IDMarca", "Descricao");
            ViewBag.Modelo = new SelectList(_db.Modelos, "IDModelo", "Descricao");
            return View();
        }

        //Post-Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Veiculo obj)
        {
            

            
            //ViewBag.Modelo = new SelectList(_db.Modelos, "IDModelo", "Descricao");
            
            _db.Veiculos.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");


        }


        public JsonResult CarregaMarcas()
        {
            var marcas = _db.Marcas.ToList();
            return Json(new SelectList(marcas, "IDMarca", "Descricao"));
        }

        public JsonResult CarregaModelos(int id)
        {
            var modelos = _db.Modelos.Where(m => m.MarcaId == id).ToList();
            return Json(new SelectList(modelos, "IDModelo", "Descricao"));
        }


    }
}
