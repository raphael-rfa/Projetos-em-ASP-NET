using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Bblioteca.Models;

namespace Bblioteca.Data
{
    public class BbliotecaContext : DbContext
    {
        public BbliotecaContext (DbContextOptions<BbliotecaContext> options)
            : base(options)
        {
        }

        public DbSet<Bblioteca.Models.Livro> Livro { get; set; } = default!;
    }
}
