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
    public class InfoMetier
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public InfoType Type { get; set; }
        [DataMember]
        public string Nom { get; set; }

        /*public int getID()
        {
            return ID;
        }

        public void setID(int ID)
        {
            this.ID = ID;
        }

        public InfoType getType()
        {
            return Type;
        }

        public void setType(InfoType Type)
        {
            this.Type = Type;
        }

        public string getNom()
        {
            return Nom;
        }

        public void setNom(string Nom)
        {
            this.Nom = Nom;
        }*/

        public InfoMetier()
        {
        }

        public InfoMetier(TMetier m)
        {
            this.ID = m.Id_metier;
            this.Type = new InfoType(m.TypeMetier);
            this.Nom = m.Metier;
        }
    }
}
