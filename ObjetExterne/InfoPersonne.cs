using ScutedelaBDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace ObjetExterne
{
    [DataContract]
    public class InfoPersonne
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string Nom { get; set; }
        [DataMember]
        public string Prenom { get; set; }
        [DataMember]
        public bool Sexe { get; set; }
        [DataMember]
        public string DateNaissance { get; set; }
        [DataMember]
        public InfoFinanceur Financeur { get; set; }
        [DataMember]
        public InfoConseiller Conseiller { get; set; }

        /*public int getID()
        {
            return ID;
        }

        public void setID(int ID)
        {
            this.ID = ID;
        }

        public string getNom()
        {
            return Nom;
        }

        public void setNom(string Nom)
        {
            this.Nom = Nom;
        }

        public string getPrenom()
        {
            return Prenom;
        }

        public void setPrenom(string Prenom)
        {
            this.Prenom = Prenom;
        }

        public string getDateNaissance()
        {
            return DateNaissance;
        }

        public void setDateNaissance(string DateNaissance)
        {
            this.DateNaissance = DateNaissance;
        }

        public bool isSexe()
        {
            return Sexe;
        }

        public void setSexe(bool Sexe)
        {
            this.Sexe = Sexe;
        }*/

        public InfoPersonne()
        {
        }

        public InfoPersonne(TPersonne p)
        {
            this.ID = p.Id_personne;
            this.Nom = p.Nom;
            this.Prenom = p.Prenom;
            this.Sexe = p.Sexe;
            this.DateNaissance = p.Date_de_naissance.ToString("dd/MM/yyyy");
            this.Financeur = null;
            this.Conseiller = new InfoConseiller(p.ConseillerLie);
        }
    }
}
