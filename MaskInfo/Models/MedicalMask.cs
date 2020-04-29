using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaskInfo.Models
{
    public class MedicalMask
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Tel { get; set; }
        public int AdultNum { get; set; }
        public int KidNum { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
