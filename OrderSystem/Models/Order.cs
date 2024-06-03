using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CreatedBy { get; set; }
        [DataType(DataType.Date)]
        public DateTime CreatedAt { get; set; }
        [DataType(DataType.Date)]
        public DateTime? StartDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime? EndDate { get; set; }
        public int? EndedBy { get; set; }
        public int? LastEditBy { get; set; }
        public string Status { get; set; }
        public int? Machine { get; set; }

        [ForeignKey("Machine")]
        public virtual Machine MachineObject { get; set; }
        [ForeignKey("CreatedBy")]
        public virtual User CreatedByUser { get; set; }
        [ForeignKey("EndedBy")]
        public virtual User EndedByUser { get; set; }
        [ForeignKey("LastEditBy")]
        public virtual User LastEditByUser { get; set; }
    }
}
