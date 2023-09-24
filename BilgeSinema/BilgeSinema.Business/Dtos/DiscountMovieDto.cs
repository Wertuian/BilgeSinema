using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeSinema.Business.Dtos
{
    public class DiscountMovieDto
    {
        public int Id { get; set; }
        public int UnitPrice { get; set; }
        public bool IsDiscounted { get; set; }
    }
}
