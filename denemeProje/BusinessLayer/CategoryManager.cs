using DataAccessLayer;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
   public class CategoryManager
    {
        Repository<Category> Caterepo = new Repository<Category>();

        public List<Category> GetAll()
        {
            return Caterepo.List();
        }

        public int BLAdd(Category c)
        {
            if (c.CatName.Length<=4)
            {
                return -1;
            }
            return Caterepo.Insert(c);
        }

        public int BLDel(int p)
        {
            if (p!=0)
            {
                Category c = Caterepo.Find(x => x.CatID == p);
                return Caterepo.Delete(c);
            }
            return -1;
        }

        public int BlUpdate(Category c)
        {
            if (c.CatName =="" || c.CatName.Length <=3 || c.CatName.Length>=25)
            {
                return -1;
            }
            Category cat = Caterepo.Find(x => x.CatID == c.CatID);
            cat.CatName = c.CatName;
            return Caterepo.Update(cat);
        }
    }
}
