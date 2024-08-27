using CodeFirstRadore.Data;
using CodeFirstRadore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstRadore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KitapController : ControllerBase
    {
        ApplicationDbContext context;

        public KitapController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        [Route("/kitap/getall")]
        public async Task<ActionResult<IEnumerable<Kitap>>> getAll()
        {
            List<Kitap> kitapListesi;
            //select * from Kitap
            kitapListesi = await context.Kitap.ToListAsync();
            return kitapListesi;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Kitap>> getById(int id)
        {
           var secilenKitap = await context.Kitap.FindAsync(id);
            if(secilenKitap == null)
            {
                return NotFound();
            }
            return secilenKitap;
        }

        [HttpPost]
        [Route("/kitap/add")]
        public async Task<ActionResult<IEnumerable<Kitap>>> addKitap(Kitap kitap)
        {
            try
            {
                context.Kitap.Add(kitap);
                await context.SaveChangesAsync();
                
            }
            catch (Exception ex)
            {

            }return Ok();
        }


        [HttpPut]
        [Route("/kitap/update/{id}")]
        public async Task<IActionResult> updateKitap(int id, Kitap kitap)
        {
            if (id != kitap.Id)
            {
                return BadRequest("Kitap ID eşleşmiyor.");
            }

            context.Entry(kitap).State = EntityState.Modified;

            try
            {
                await context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KitapExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }
        
        

        [HttpDelete]
        [Route("/kitap/delete/{id}")]
        public async Task<IActionResult> deleteKitap(int id)
        {
            var kitap = await context.Kitap.FindAsync(id);
            if (kitap == null)
            {
                return NotFound();
            }

            context.Kitap.Remove(kitap);
            await context.SaveChangesAsync();

            return NoContent();
        }
        

        private bool KitapExists(int id)
        {
            return context.Kitap.Any(e => e.Id == id);
        }
        

    }
}
