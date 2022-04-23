using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Product
    {
        [Key]
        public int prID { get; set; }

        [StringLength (40)]
        public string prName { get; set; }

        public int CatID { get; set; }
        public virtual Category Category { get; set; }
    }
}
