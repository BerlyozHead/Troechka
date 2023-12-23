using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklad.Context.Contracts.Models
{
    public class Vedomost
    {
        public int Kolic { get; set; }

        public int Summa { get; set; }
        public object Postavhik { get; set; }
        public Guid Id { get; set; }
    }
}
