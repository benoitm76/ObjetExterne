﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace ObjetExterne
{
    [DataContract]
    public class InfoEntreprise
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string nom { get; set; }

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
            return nom;
        }

        public void setNom(string nom)
        {
            this.nom = nom;
        }*/

        public InfoEntreprise()
        {
        }
    }
}
