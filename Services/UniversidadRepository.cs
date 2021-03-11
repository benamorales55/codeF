using CodeFirst2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirst2.Services
{
    public class UniversidadRepository
    {
        public List<Universidad> obtenerTodos()
        {
            using (var db = new UniversidadContext())
            {
                return db.Universidads.ToList();
            }
        }

        internal void Crear(Universidad model)
        {
            using(var db = new UniversidadContext())
            {
                db.Universidads.Add(model);
                db.SaveChanges();
            }
        }

        internal void Edit(Universidad model)
        {
            using (var db = new UniversidadContext())
            {
                var uni = db.Universidads.Find(model.Id);

                uni.Id = model.Id;
                uni.Nombre = model.Nombre;
                uni.Direccion = model.Direccion;
                uni.Correo = model.Correo;

                db.Entry(uni).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        internal void Eliminar(Universidad model)
        {
            using(var db = new UniversidadContext())
            {
                var uni = db.Universidads.Find(model.Id);

                db.Universidads.Remove(uni);
                db.SaveChanges();
            }
        }
    }
}