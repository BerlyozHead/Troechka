using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sklad.Context.Contracts.Models;
using Sklad.Context;

namespace storagebartenders.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VedomostController : ControllerBase
    {
        private readonly ISladContext context1;
        public VedomostController(ISladContext context1)
        {
            this.context1 = context1;
        }
        [HttpGet] //localhost:111224/group
        public IActionResult GetAllPlatelshik()
        {
            var vedomostlist = context1.Vedomosts.ToList();
            return Ok(vedomostlist);
        }
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var vedomostlist = context1.Vedomosts.FirstOrDefault(x => x.Id == id);
            return Ok(vedomostlist);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var group2 = context1.Vedomosts.FirstOrDefault(x => x.Id == id);
            if (group2 != null)
            {
                context1.Vedomosts.Remove(group2);
            }
            return Ok();
        }
        [HttpPost]
        public IActionResult Create(Vedomost model)
        {
            var item = new Vedomost
            {
                Id = Guid.NewGuid(),
                Kolic = model.Kolic,
                Summa = model.Summa,
                Postavhik = model.Postavhik,

            };
            context1.Vedomosts.Add(item);
            return Ok(item);
        }
        [HttpPut("{id}")]
        public IActionResult Edit(Guid Id, Vedomost model)
        {
            var group2 = context1.Vedomosts.FirstOrDefault(x => x.Id == Id);
            if (group2 != null)
            {
                return NotFound();
            }
            group2.Kolic = model.Kolic;
            group2.Summa = model.Summa;
            group2.Postavhik = model.Postavhik;

            return Ok(group2);
        }
    }
}