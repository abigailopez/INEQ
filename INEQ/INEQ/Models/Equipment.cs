using System;
using System.Collections.Generic;


namespace INEQ.Models
{
    public class Equipment
    {
        public int ID { get; set; }
        public int EquipmentId { get; set; }
        public int ModelId { get; set; }
        public int BrandId { get; set; }
        public int StatusId { get; set; }
        public int WarehouseId { get; set; }
        public DateTime EntryDate { get; set; }
        public string Serie { get; set; }
        public string SoftekId { get; set; }
        public Boolean Active { get; set; }

        public virtual ICollection<EquipmentType> EquipmentTypes { get; set; }
    }
}