using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Wcf_Projet_Cinema.Model;

namespace Wcf_Project_Cinema
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "CategoryService" à la fois dans le code et le fichier de configuration.
    public class CategoryService : ICategoryService
    {
        BDContext bd = new BDContext();
        public Category Add(Category c)
        {
            try
            {
                bd.Categories.Add(c);
                bd.SaveChanges();
                return c;
            }catch { return null; }
        }

        public void DoWork()
        {
        }

        public Category Modify(Category c)
        {
            try
            {

                Category req=bd.Categories.Find(c.CategoryId);
                req.CategoryLastUpdate = c.CategoryLastUpdate;
                req.CategoryName = c.CategoryName;
                
                bd.SaveChanges();
                return c;
            }catch { return null; }
        }
    }
}
