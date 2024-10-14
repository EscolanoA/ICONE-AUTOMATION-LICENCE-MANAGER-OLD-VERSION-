using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Gestionnaire_Licences
{
    class Licence
    {
        //Definition de nos arguments pour la classe
        public int ID;
        public DateTime Date_creation;
        public DateTime Date_expiration;
        public int Nb_equipements;
        public int Nb_variables;
        public string Checksum;
        public int Code_integrateur;
        public int Code_client;
        public int Code_fonction1;
        public int Code_fonction2;
        public int Code_fonction3;
        public int Code_fonction4;
        public int Code_fonction5;
        public int Code_fonction6;
        public int Code_fonction7;
        public int Code_fonction8;
        public int Code_fonction9;
        public int Code_fonction10;
        public int Code_fonction11;
        public int Code_fonction12;
        public int Code_fonction13;
        public int Code_fonction14;
        public int Code_fonction15;
        public int Code_fonction16;
        public int Code_fonction17;
        public int Code_fonction18;
        public int Code_fonction19;
        public int Code_fonction20;


        //Creation du constructeur permettant d'instancier une avec toutes ses valeurs nécessaires
        public Licence(int ID, DateTime Date_creation, DateTime Date_expiration, int Nb_equipements, int Nb_variables, string Checksum, int Code_integrateur, int Code_client,
            int Code_fonction1, int Code_fonction2, int Code_fonction3, int Code_fonction4, int Code_fonction5, int Code_fonction6, int Code_fonction7, int Code_fonction8, int Code_fonction9, int Code_fonction10
            , int Code_fonction11, int Code_fonction12, int Code_fonction13, int Code_fonction14, int Code_fonction15, int Code_fonction16, int Code_fonction17, int Code_fonction18, int Code_fonction19, int Code_fonction20)
        {
            this.ID = ID;
            this.Date_creation = Date_creation;
            this.Date_expiration = Date_expiration;
            this.Nb_equipements = Nb_equipements;
            this.Nb_variables = Nb_variables;
            this.Checksum = Checksum;
            this.Code_integrateur = Code_integrateur;
            this.Code_client = Code_client;
            this.Code_fonction1 = Code_fonction1;
            this.Code_fonction2 = Code_fonction2;
            this.Code_fonction3 = Code_fonction3;
            this.Code_fonction4 = Code_fonction4;
            this.Code_fonction5 = Code_fonction5;
            this.Code_fonction6 = Code_fonction6;
            this.Code_fonction7 = Code_fonction7;
            this.Code_fonction8 = Code_fonction8;
            this.Code_fonction9 = Code_fonction9;
            this.Code_fonction10 = Code_fonction10;
            this.Code_fonction11 = Code_fonction11;
            this.Code_fonction12 = Code_fonction12;
            this.Code_fonction13 = Code_fonction13;
            this.Code_fonction14 = Code_fonction14;
            this.Code_fonction15 = Code_fonction15;
            this.Code_fonction16 = Code_fonction16;
            this.Code_fonction17 = Code_fonction17;
            this.Code_fonction18 = Code_fonction18;
            this.Code_fonction19 = Code_fonction19;
            this.Code_fonction20 = Code_fonction20;
        }
    }
}
