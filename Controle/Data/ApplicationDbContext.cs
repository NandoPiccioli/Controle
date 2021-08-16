
using Controle.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Controle.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }
        public DbSet<Veiculo> Veiculos{ get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Modelos> Modelos { get; set; }
        public DbSet<Anuncio> Anuncios { get; set; }


    }
}