using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Car:BaseEntity
    {
        public int BrandId { get; set;}
        public int ColorId { get; set; }
        public string Name { get; set; } = null!;
        public int ModelYear { get; set; }
        public int DailyPrice { get; set; }
        
        // null alabilir anlamında ? koyduk
        public string? Description { get; set; }
    }
}
