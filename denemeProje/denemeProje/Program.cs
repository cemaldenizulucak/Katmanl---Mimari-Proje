using BusinessLayer;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace denemeProje
{
    class Program
    {
        static void Main(string[] args)
        {
            CategoryManager cm = new CategoryManager();

            // --------- LİST ---------------

            foreach (var item in cm.GetAll())
            {
                Console.WriteLine("ID : " + item.CatID + " Category Name : " + item.CatName);
            }

            // ----------  ADD --------------

            /* Category c = new Category();
             c.CatName = "Aksesuar";
             cm.BLAdd(c);*/

            // ---------- DELETE ------------

            // cm.BLDel(7);


            // ----------- UPDATE -------------

            Category c = new Category();
            c.CatID = 3;
            c.CatName = "Mobilya";
            cm.BlUpdate(c);

            Console.ReadKey();
        }
    }
}
