using System;


namespace INEQ.Models
{
    public class EquipmentType
    {
        public int ID { get; set; }
        public String Description { get; set; }
        public float UsefulLife { get; set; }
        public float GuaranteeDuration { get; set; }
        public Boolean Active { get; set; }

    }
}