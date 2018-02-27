using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
namespace WebAPIDEMO.Models
{
    public class IAmKajasContext : DbContext
    {
        public IAmKajasContext(DbContextOptions<IAmKajasContext> options) : base(options)
        {
        }
        public DbSet<IAmKajas> IAmKajas { get; set; }
       
    }
}