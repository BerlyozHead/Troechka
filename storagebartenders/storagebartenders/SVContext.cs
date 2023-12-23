using Microsoft.EntityFrameworkCore;
using Sklad.Context.Contracts.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Sklad.Context
{
    public class SVContext : ISladContext
    {
        private ICollection<Postavshik> postavshiks;
        private ICollection<Tovar> tovars;
        private ICollection<Vedomost> vedoms;

        public SVContext()
        {
            postavshiks = new HashSet<Postavshik>();
            tovars = new HashSet<Tovar>();
            vedoms = new HashSet<Vedomost>();
            Seed();
        }

        public ICollection<Postavshik> Postavshiks => postavshiks;

        public ICollection<Tovar> Tovars => tovars;

        public ICollection<Vedomost> Vedomosts => vedoms;

      

        public int SaveChanges()
        {
            throw new NotImplementedException();
        }

        private void Seed()
        {
            Postavshiks.Add(new Postavshik
            {
                Id = Guid.NewGuid(),
                Postavhik = "Илья",
                Adress = "Санкт-Петербург, ул. Тореза 47",
                Telefon = 147318,
            });
            Tovars.Add(new Tovar
            {
                Id = Guid.NewGuid(),
                Data = "26.02.04",
                Tovari = "Пиво",
                cena = 20000,
            });
            Vedomosts.Add(new Vedomost
            {
                Id = Guid.NewGuid(),
                Kolic = 15,
                Summa = 20000000,
                Postavhik = "ООН <Генга>",
            });
            Vedomosts.Add(new Vedomost
            {
                Id = Guid.NewGuid()
            });
        }
    }
}

