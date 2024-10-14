﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestionnaire_Licences
{
    class Fonction
    {
        //Definition de nos arguments pour la classe
        public int codeFonction;
        public String nom;
        public DateTime dateUpdate;
        public String description;

        //Creation du constructeur permettant d'instancier avec toutes ses valeurs nécessaires
        public Fonction(int codeFonction, String nom, DateTime dateUpdate, String description)
        {
            this.codeFonction = codeFonction;
            this.nom = nom;
            this.dateUpdate = dateUpdate;
            this.description = description;
        }
    }
}