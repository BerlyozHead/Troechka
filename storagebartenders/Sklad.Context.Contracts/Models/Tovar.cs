using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklad.Context.Contracts.Models
{
    public class Tovar
    {
        public string Data { get; set; }

        public string Tovari { get; set; }

        public int cena { get; set; }
        public Guid Id { get; set; }
    }
}
