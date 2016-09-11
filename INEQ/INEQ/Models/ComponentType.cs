using System;
using System.ComponentModel.DataAnnotations;


namespace INEQ.Models
{
    public class ComponentType
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "*Descripción del equipo es obligatorio.", AllowEmptyStrings = false)]
        public String Description { get; set; }
        public Boolean Active { get; set; }
    }
}