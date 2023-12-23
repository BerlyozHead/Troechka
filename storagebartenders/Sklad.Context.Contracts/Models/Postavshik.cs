using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklad.Context.Contracts.Models
{
    public class Postavshik : BaseAuditEntity
    {

        public string Postavhik { get; set; }

        public string Adress { get; set; }
        public string Telefon { get; set; }

    }
}
