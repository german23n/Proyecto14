using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto14.models
{
    public class ApplicationDbcontext : DbContext
    {

        public ApplicationDbcontext(DbContextOptions<ApplicationDbcontext> options) : base(options)
        {

        }


        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<subCategoria> SubCategorias { get; set; }
        public DbSet<categoriaSubcategoria> CategoriaSubCategorias { get; set; }
    }


}
