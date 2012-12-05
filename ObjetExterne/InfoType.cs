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
    public class InfoType
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string intitule { get; set;}

        /*public int getID()
        {
            return ID;
        }

        public void setID(int ID)
        {
            this.ID = ID;
        }

        public string getIntitule()
        {
            return intitule;
        }

        public void setIntitule(string intitule)
        {
            this.intitule = intitule;
        }*/

        public InfoType()
        {
        }

        public InfoType(TTypeMetier t)
        {
            this.ID = t.Id_type_metier;
            this.intitule = t.Type_metier;
        }
    }
}
