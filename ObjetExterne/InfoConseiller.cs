using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScutedelaBDD;
using System.Runtime.Serialization;

namespace ObjetExterne
{
    [DataContract]
    public class InfoConseiller
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string Nom { get; set; }
        [DataMember]
        public string Prenom { get; set; }

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
        }*/

        public InfoConseiller()
        {
        }

        public InfoConseiller(TConseiller c)
        {
            this.ID = c.Id_conseiller;
            this.Nom = c.Nom_conseiller;
            this.Prenom = c.Prenom_conseiller;
        }
    }
}
