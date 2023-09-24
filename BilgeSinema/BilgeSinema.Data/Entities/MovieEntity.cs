using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeSinema.Data.Entities
{
    public class MovieEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Director { get; set; }
        public bool IsDiscounted { get; set; }

        public int UnitPrice { get; set; }
        public bool IsDeleted { get; set; }
    }
}
