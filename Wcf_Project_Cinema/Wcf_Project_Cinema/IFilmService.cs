﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Wcf_Projet_Cinema.Model;

namespace Wcf_Project_Cinema
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IFilmService" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IFilmService
    {
        

        [OperationContract]
        Film Add(Film f);

        [OperationContract]
        Film Modify(Film f);

        [OperationContract]
        Film getOneFilm(int id);

        [OperationContract]
        List<Film> getFilms(int[] tabId);
    }
}
