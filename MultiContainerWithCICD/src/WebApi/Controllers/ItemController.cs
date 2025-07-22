using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemsController : ControllerBase
    {
        private readonly AppDbContext _db;

        public ItemsController(AppDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult Get() => Ok(_db.Items.ToList());

        [HttpPost]
        public IActionResult Post(Item item)
        {
            _db.Items.Add(item);
            _db.SaveChanges();
            return CreatedAtAction(nameof(Get), new { id = item.Id }, item);
        }
    }
}