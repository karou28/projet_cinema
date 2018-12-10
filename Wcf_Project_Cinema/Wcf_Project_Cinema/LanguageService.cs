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
            
           
            try
            {
                bd.Languages.Add(l);
                bd.SaveChanges();

                return l;
            }
            catch{
                
                return null; }
        }

        

        public Language Modify(Language l)
        {

            try
            {
                Language req = bd.Languages.Find(l.LanguageId);
                req.LanguageName=l.LanguageName;
                req.LanguageLastUpdate = l.LanguageLastUpdate;
                
                bd.SaveChanges();
                return l;
            }
            catch(Exception e)
            {
                return null;
            }
        }
    }
}
