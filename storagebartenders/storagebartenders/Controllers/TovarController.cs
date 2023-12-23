using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sklad.Context.Contracts.Models;
using Sklad.Context;

namespace storagebartenders.Controllers
{
        [ApiController]
        [Route("[controller]")]
        public class TovarController : ControllerBase
        {
            private readonly ISladContext context1;
            public TovarController(ISladContext context1)
            {
                this.context1 = context1;
            }
            [HttpGet] 
            public IActionResult GetAllPlatelshik()
            {
                var tovarlist = context1.Tovars.ToList();
                return Ok(tovarlist);
            }
            [HttpGet("{id}")]
            public IActionResult Get(Guid id)
            {
                var tovarlist = context1.Tovars.FirstOrDefault(x => x.Id == id);
                return Ok(tovarlist);
            }
            [HttpDelete("{id}")]
            public IActionResult Delete(Guid id)
            {
                var group2 = context1.Tovars.FirstOrDefault(x => x.Id == id);
                if (group2 != null)
                {
                    context1.Tovars.Remove(group2);
                }
                return Ok();
            }
            [HttpPost]
            public IActionResult Create(Tovar model)
            {
                var item = new Tovar
                {
                    Id = Guid.NewGuid(),
                    Data = model.Data,
                    Tovari = model.Tovari,
                    cena = model.cena,

                };
                context1.Tovars.Add(item);
                return Ok(item);
            }
            [HttpPut("{id}")]
            public IActionResult Edit(Guid Id, Tovar model)
            {
                var group2 = context1.Tovars.FirstOrDefault(x => x.Id == Id);
                if (group2 != null)
                {
                    return NotFound();
                }
                group2.Data = model.Data;
                group2.Tovari = model.Tovari;
                group2.cena = model.cena;

                return Ok(group2);
            }
        } 
}
