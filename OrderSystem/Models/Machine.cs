using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OrderSystem.Models
{
    public class Machine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        [Range(1900, 2100)]
        public int ManufacturingYear { get; set; }
    }
}
