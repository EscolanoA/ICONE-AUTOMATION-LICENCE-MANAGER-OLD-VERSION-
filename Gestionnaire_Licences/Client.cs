using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestionnaire_Licences
{
    class Client
    {
        //Definition de nos arguments pour la classe
        public int codeClient;
        public String nom;
        public DateTime dateUpdate;
        public String description;

        //Creation du constructeur permettant d'instancier avec toutes ses valeurs nécessaires
        public Client(int codeClient, String nom, DateTime dateUpdate, String description)
        {
            this.codeClient = codeClient;
            this.nom = nom;
            this.dateUpdate = dateUpdate;
            this.description = description;
        }
    }
}
