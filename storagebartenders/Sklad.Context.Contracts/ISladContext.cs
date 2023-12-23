
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
        ICollection<Postavshik> Postavshiks { get; }

        /// <summary>
        /// çàêàç÷èê
        /// </summary>
        ICollection<Tovar> Tovars { get; }

        ICollection<Vedomost> Vedomosts { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        int SaveChanges();
    }

}
/// 1) dotnet tool install --global dotnet-ef
/// 2) dotnet tool update --global dotnet-ef
/// 3) dotnet ef migrations add [name] --project TimeTable207.Context\TimeTable207.Context.csproj
/// 4) dotnet ef database update --project TimeTable207.Context\TimeTable207.Context.csproj