using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Wcf_Projet_Cinema.Model;

namespace Wcf_Project_Cinema
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "LanguageService" à la fois dans le code et le fichier de configuration.
    public class LanguageService : ILanguageService
    {
        BDContext bd = new BDContext();
        public Language Add(Language l)
        {
            
            bd.Languages.Add(l);
            bd.Languages.SaveChanges();
            return l;
        }

        public Language Modify(Language l)
        {
            
            var req = (from a in bd.Languages where a.LanguageId = l.LanguageId select a).First();
            req = l;
            bd.Languages.SaveChanges();
            return l;
        }
    }
}
