using ContosoUniversityAPI2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ContosoUniversityAPI2.Controllers
{
    public class EstudianteController : ApiController
    {
        private EscuelaContext db = new EscuelaContext();

        // GET: api/Estudiante
        public List<Estudiante> Get()
        {
            return db.Estudiantes.ToList();
        }

        // GET: api/Estudiante/5
        public List<Estudiante> Get(int id)
        {
            return db.Estudiantes.Where(e => e.ID == id).ToList();        
         }

        // POST: api/Estudiante
        public bool Post(string Nombre, string Apellido, DateTime FechaEnrolamiento, int id)
        {
            var e = new Estudiante
            {
                ID = id,
                Nombre = Nombre,
                Apellido = Apellido,
                FechaEnrolamiento = Convert.ToDateTime(FechaEnrolamiento)
            };
            db.Estudiantes.Attach(e);
            db.Configuration.ValidateOnSaveEnabled = true;
            db.Entry(e).State = System.Data.Entity.EntityState.Modified;
            return db.SaveChanges() > 0;
        }

        // PUT: api/Estudiante/5
        public bool Put(string Nombre, string Apellido, DateTime FechaEnrolamiento)
        {
            var estudiante = new Estudiante
            {
                Nombre = Nombre,
                Apellido = Apellido,
                FechaEnrolamiento = FechaEnrolamiento,

            };
            db.Estudiantes.Add(estudiante);
            return db.SaveChanges() > 0;
        }

        // DELETE: api/Estudiante/5
        public bool Delete(int id)
        {
            var e = db.Estudiantes.Find(id);
            db.Estudiantes.Attach(e);
            db.Estudiantes.Remove(e);
            return db.SaveChanges() > 0;
        }
    }
}
