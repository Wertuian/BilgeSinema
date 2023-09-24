using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeSinema.Business.Dtos
{
    public class AddMovieDto
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Director { get; set; }
        public int UnitPrice { get; set; }
    }
}
