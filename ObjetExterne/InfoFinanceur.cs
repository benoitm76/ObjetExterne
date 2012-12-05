using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace ObjetExterne
{
    [DataContract]
    public class InfoFinanceur
    {
        [DataMember]
        public int ID { get; set; }
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

        public string getNom()
        {
            return Nom;
        }

        public void setNom(string Nom)
        {
            this.Nom = Nom;
        }*/

        public InfoFinanceur()
        {
        }
    }
}
