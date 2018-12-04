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
            throw new NotImplementedException();
            bd.Actors.Add(a);
            bd.Actors.SaveChanges();
            return a;

        }



        public Actor Modify(Actor a)
        {
            throw new NotImplementedException();
            var req = (from b in bd.Actors where b.ActorId = a.ActorId select b).First();
            req = a;
            bd.Actors.SaveChanges();
            return a;

        }
    }
}
