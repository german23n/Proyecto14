using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto14.models
{
    public class subCategoria
    {
        [Key]
        public int IdSubCategoria { get; set; }
        public string Nombre { get; set; }
        public List<categoriaSubcategoria> CategoriaSubCategorias { get; set; }

    }
}
