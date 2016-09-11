using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace INEQ.Models
{
    public class Equipment
    {
        [Required(ErrorMessage = "*Campo obligatorio.", AllowEmptyStrings = false)]
        public int ID { get; set; }
        [Required(ErrorMessage = "*Campo obligatorio.", AllowEmptyStrings = false)]
        public int EquipmentId { get; set; }
        [Required(ErrorMessage = "*Campo obligatorio.", AllowEmptyStrings = false)]
        public int ModelId { get; set; }
        [Required(ErrorMessage = "*Campo obligatorio.", AllowEmptyStrings = false)]
        public int BrandId { get; set; }
        [Required(ErrorMessage = "*Campos obligatorio.", AllowEmptyStrings = false)]
        public int StatusId { get; set; }
        [Required(ErrorMessage = "*Campo obligatorio.", AllowEmptyStrings = false)]
        public int WarehouseId { get; set; }
        [Required(ErrorMessage = "*Campo obligatorio.", AllowEmptyStrings = false)]
        public DateTime EntryDate { get; set; }
        [Required(ErrorMessage = "*Campo obligatorio.", AllowEmptyStrings = false)]
        public string Serie { get; set; }
        [Required(ErrorMessage = "*Campo obligatorio.", AllowEmptyStrings = false)]
        public string SoftekId { get; set; }
        public Boolean Active { get; set; }

        public virtual ICollection<EquipmentType> EquipmentTypes { get; set; }
    }
}