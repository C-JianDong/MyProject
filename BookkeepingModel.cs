using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBookkeeping
{
    public class BookkeepingModel
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Category { get; set; }
        public decimal Money { get; set; }
        public string Describe { get; set; }
        public string CreateTime { get; set; }
    }
}
