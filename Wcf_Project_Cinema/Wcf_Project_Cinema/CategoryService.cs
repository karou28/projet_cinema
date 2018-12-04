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
            throw new NotImplementedException();
            bd.Categories.Add(c);
            bd.Categories.SaveChanges();
            return c;
        }

        public void DoWork()
        {
        }

        public Category Modify(Category c)
        {
            throw new NotImplementedException();
            var req = (from a in bd.Categories where a.CategoryId = c.CategoryId select a).First();
            req = c;
            bd.Categories.SaveChanges();
            return c;
        }
    }
}
