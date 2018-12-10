using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Wcf_Projet_Cinema.Model;

namespace Wcf_Project_Cinema
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "ActorService" à la fois dans le code et le fichier de configuration.
    public class ActorService : IActorService
    {
        BDContext bd = new BDContext();
       
        public Actor Add(Actor a)
        {

            try
            {
                bd.Actors.Add(a);
                bd.SaveChanges();
                return a;
            }catch { return null; }

        }



        public Actor Modify(Actor a)
        {

            try
            {
                Actor req = bd.Actors.Find(a.ActorId);
                req.ActorFirstName = a.ActorFirstName;
                req.ActorLastName = a.ActorLastName;
                req.ActorLastUpdate = a.ActorLastUpdate;

                bd.SaveChanges();
                return a;
            }
            catch { return null; }
            

        }
    }
}
