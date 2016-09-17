using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContosoUniversityAPI2.Models
{
    public class Estudiante
    {
        public int ID { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public DateTime FechaEnrolamiento { get; set; }
    }
}