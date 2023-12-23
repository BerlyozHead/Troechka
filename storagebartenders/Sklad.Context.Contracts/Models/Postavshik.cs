using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklad.Context.Contracts.Models
{
    public class Postavshik 
    {

        public string Postavhik { get; set; }

        public string Adress { get; set; }
        public int Telefon { get; set; }
        public Guid Id { get; set; }
    }
}
