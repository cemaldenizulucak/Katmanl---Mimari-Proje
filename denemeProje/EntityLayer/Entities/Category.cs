using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
   public class Category
    {
        [Key]
        public int CatID { get; set; }
        [StringLength (40)]
        public string CatName { get; set; }

        public ICollection<Product> products { get; set; }

    }
}
