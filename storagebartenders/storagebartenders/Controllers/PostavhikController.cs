using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sklad.Context;
using Sklad.Context.Contracts.Models;
using System.Text.RegularExpressions;

namespace storagebartenders.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class PostavshikController : ControllerBase
    {
        private readonly ISladContext context1;
        public PostavshikController(ISladContext context1)
        {
            this.context1 = context1;
        }
        [HttpGet] //localhost:111224/group
        public IActionResult GetAllPlatelshik()
        {
            var postavshiklist = context1.Postavshiks.ToList();
            return Ok(postavshiklist);
        }
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var postavshiklist = context1.Postavshiks.FirstOrDefault(x => x.Id == id);
            return Ok(postavshiklist);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var group2 = context1.Postavshiks.FirstOrDefault(x => x.Id == id);
            if (group2 != null)
            {
                context1.Postavshiks.Remove(group2);
            }
            return Ok();
        }
        [HttpPost]
        public IActionResult Create(Postavshik model)
        {
            var item = new Postavshik
            {
                Id = Guid.NewGuid(),
                Postavhik = model.Postavhik,
                Adress = model.Adress,
                Telefon = model.Telefon,

            };
            context1.Postavshiks.Add(item);
            return Ok(item);
        }
        [HttpPut("{id}")]
        public IActionResult Edit(Guid Id, Postavshik model)
        {
            var group2 = context1.Postavshiks.FirstOrDefault(x => x.Id == Id);
            if (group2 != null)
            {
                return NotFound();
            }
            group2.Postavhik = model.Postavhik;
            group2.Adress = model.Adress;
            group2.Telefon = model.Telefon;
            return Ok(group2);
        }
    }
}
