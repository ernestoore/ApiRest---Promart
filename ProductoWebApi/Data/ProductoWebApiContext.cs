using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProductoWebApi.Models
{
    public class ProductoWebApiContext : DbContext
    {
        public ProductoWebApiContext (DbContextOptions<ProductoWebApiContext> options)
            : base(options)
        {
        }

        public DbSet<Producto> Producto { get; set; }
    }
}
