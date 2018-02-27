using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAPIDEMO.Models;



namespace WebAPIDEMO.Controllers
{


    [Route("api/[controller]")]
    public class IAmKajasController : Controller
    {
            private readonly IAmKajasContext _context;

            public IAmKajasController(IAmKajasContext context)
            {
                _context = context;

                if (_context.IAmKajas.Count() == 0)
                {
                    _context.IAmKajas.Add(new IAmKajas { Name = "laal" });
                _context.IAmKajas.Add(new IAmKajas {  Name = "dsfsd" });
                _context.SaveChanges();
                }
            }
        [HttpGet]
        public IEnumerable<IAmKajas> GetAll()
        {
            return _context.IAmKajas.ToList();
        }

        [HttpGet("{id}", Name = "IAmKajasList")]
        public IActionResult GetById(long id)
        {
            var item = _context.IAmKajas.FirstOrDefault(t => t.Id == id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }

      
    }
}
