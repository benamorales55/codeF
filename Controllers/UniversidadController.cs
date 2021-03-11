using CodeFirst2.Models;
using CodeFirst2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirst2.Controllers
{
    public class UniversidadController : Controller
    {
        public UniversidadRepository _repo;
        public UniversidadController()
        {
            _repo = new UniversidadRepository();
        }
        // GET: Universidad
        public ActionResult Index()
        {
            var model = _repo.obtenerTodos();
            return View(model);
        }

        // GET: Universidad/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Universidad/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Universidad/Create
        [HttpPost]
        public ActionResult Create(Universidad model)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    _repo.Crear(model);
                     return RedirectToAction("Index");  
                }
                // TODO: Add insert logic here

                return Redirect("Index");
            }
            catch
            {
               
            }
            return View();
        }

        // GET: Universidad/Edit/5
        public ActionResult Edit(int id)
        {
            Universidad model = new Universidad();
            using(UniversidadContext db = new UniversidadContext())
            {
                var uni = db.Universidads.Find(id);
                model.Nombre = uni.Nombre;
                model.Direccion = uni.Direccion;
                model.Telefono = uni.Telefono;
                model.Correo = uni.Correo;
            }
            return View(model);
        }

        // POST: Universidad/Edit/5
        [HttpPost]
        public ActionResult Edit(Universidad model)
        {
           
            try
            {
                if (ModelState.IsValid)
                {
                    _repo.Edit(model);
                    return RedirectToAction("Index");
                }
                // TODO: Add insert logic here

                return Redirect("Index");
            }
            catch
            {

            }
            return View();
        }

        // GET: Universidad/Delete/5
        public ActionResult Delete(int id)
        {
            Universidad model = new Universidad();
            using (UniversidadContext db = new UniversidadContext())
            {
                var uni = db.Universidads.Find(id);
                model.Nombre = uni.Nombre;
                model.Direccion = uni.Direccion;
                model.Telefono = uni.Telefono;
                model.Correo = uni.Correo;
            }
            return View(model);
        }

        // POST: Universidad/Delete/5
        [HttpPost]
        public ActionResult Delete(Universidad model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _repo.Eliminar(model);
                    return RedirectToAction("Index");
                }
                // TODO: Add insert logic here

                return Redirect("Index");
            }
            catch
            {

            }
            return View();
        }
    }
}
