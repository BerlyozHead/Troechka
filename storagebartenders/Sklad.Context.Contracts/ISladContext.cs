
using Microsoft.EntityFrameworkCore;
using Sklad.Context.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
namespace Sklad.Context
{

    public interface ISladContext
    {
         
        /// <summary>
        /// Ìàøèíû
        /// </summary>
        DbSet<Postavshik> Postavshiks { get; }

        /// <summary>
        /// çàêàç÷èê
        /// </summary>
        DbSet<Tovar> Tovars { get; }

        DbSet<Vedomost> Vedomosts { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        int SaveChanges();
    }
}