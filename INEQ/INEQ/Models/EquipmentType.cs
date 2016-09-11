using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace INEQ.Models
{
    public class EquipmentType
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "*Descripción del equipo es obligatorio.",AllowEmptyStrings = false)]
        public String Description { get; set; }

        [Required(ErrorMessage = "*Dato de años de vida del equipo es obligatorio.", AllowEmptyStrings = false)]
        public float UsefulLife { get; set; }

        [Required(ErrorMessage = "*Datos de garantía del equipo es obligatorio.", AllowEmptyStrings = false)]
        public float GuaranteeDuration { get; set; }

        public Boolean Active { get; set; }

    }
}