using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto14.models
{
    public class categoriaSubcategoria
    {
        [Key]
        public int Id { get; set; }
        public int IdCategoria { get; set; }
        public int IdSubCategoria { get; set; }
        public Categoria Categoria { get; set; }
        public subCategoria SubCategoria { get; set; }

    }
}
