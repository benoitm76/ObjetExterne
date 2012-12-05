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
    public class InfoEmploi
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string Nom_emploi { get; set; }
        [DataMember]
        public InfoType Type { get; set; }
        [DataMember]
        public InfoPersonne Personne { get; set; }

        /*public int getID()
        {
            return ID;
        }

        public void setID(int ID)
        {
            this.ID = ID;
        }

        public string getNom_emploi()
        {
            return Nom_emploi;
        }

        public void setNom_emploi(string Nom_emploi)
        {
            this.Nom_emploi = Nom_emploi;
        }

        public InfoType getType()
        {
            return Type;
        }

        public void setType(InfoType Type)
        {
            this.Type = Type;
        }

        public InfoPersonne getPersonne()
        {
            return Personne;
        }

        public void setPersonne(InfoPersonne Personne)
        {
            this.Personne = Personne;
        }*/

        public InfoEmploi(TEmploi e)
        {
            this.ID = e.Id_emploi;
            this.Nom_emploi = e.Nom_emploi;
            this.Type = new InfoType(TTypeMetier.findById((int)TMetier.findByIdMetier((int)e.Id_metier)[0].Id_type_metier)[0]);
            this.Personne = new InfoPersonne(TPersonne.findByIdPersonne((int)e.Id_personne)[0]);
        }

        public InfoEmploi()
        {
        }
    }
}
