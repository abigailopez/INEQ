using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContosoUniversityAPI2.Models
{
    public class Enrolamiento
    {
        public int ID { get; set; }
        public int CursoID { get; set; }
        public int EstudianteID { get; set; }
        public char Grado { get; set; }

        public virtual Curso Curso {get; set;}
        public virtual Estudiante Estudiante { get; set; }
    }
}