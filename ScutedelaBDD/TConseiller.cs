using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScutedelaBDD
{
    public class TConseiller
    {
        private int id_conseiller;
        private string nom_conseiller;
        private string prenom_conseiller;

        public int Id_conseiller
        {
            get { return id_conseiller; }
            set { id_conseiller = value; }
        }

        public string Nom_conseiller
        {
            get { return nom_conseiller; }
            set { nom_conseiller = value; }
        }

        public string Prenom_conseiller
        {
            get { return prenom_conseiller; }
            set { prenom_conseiller = value; }
        }

        public TConseiller()
        {
        }

        public TConseiller(int idConseiller)
        {
            this.id_conseiller = idConseiller;
        }

        public static List<TConseiller> findAll()
        {
            DataSQLDataContext db = new DataSQLDataContext();

            var q = from c in db.T_CONSEILLER
                    select c;
            List<TConseiller> mesConseiller = new List<TConseiller>();

            foreach (var c in q)
            {
                TConseiller mC = new TConseiller((int)c.ID_CONSEILLER);
                mC.nom_conseiller = c.NOM_CONSEILLER;
                mC.prenom_conseiller = c.PRENOM_CONSEILLER;
                mesConseiller.Add(mC);
            }
            return mesConseiller;
        }

        public static List<TConseiller> findById(int aId)
        {
            DataSQLDataContext db = new DataSQLDataContext();

            var q = from c in db.T_CONSEILLER
                    where c.ID_CONSEILLER == aId
                    select c;
            List<TConseiller> mesConseiller = new List<TConseiller>();

            foreach (var c in q)
            {
                TConseiller mC = new TConseiller();
                mC.id_conseiller = (int)c.ID_CONSEILLER;
                mC.nom_conseiller = c.NOM_CONSEILLER;
                mC.prenom_conseiller = c.PRENOM_CONSEILLER;
                mesConseiller.Add(mC);
            }
            return mesConseiller;
        }

        public static List<TConseiller> findByNom(string aNom)
        {
            DataSQLDataContext db = new DataSQLDataContext();

            var q = from c in db.T_CONSEILLER
                    where c.NOM_CONSEILLER == aNom
                    select c;
            List<TConseiller> mesConseiller = new List<TConseiller>();

            foreach (var c in q)
            {
                TConseiller mC = new TConseiller();
                mC.id_conseiller = (int)c.ID_CONSEILLER;
                mC.nom_conseiller = c.NOM_CONSEILLER;
                mC.prenom_conseiller = c.PRENOM_CONSEILLER;
                mesConseiller.Add(mC);
            }
            return mesConseiller;
        }

        public static List<TConseiller> findByPrenom(string aPrenom)
        {
            DataSQLDataContext db = new DataSQLDataContext();

            var q = from c in db.T_CONSEILLER
                    where c.PRENOM_CONSEILLER == aPrenom
                    select c;
            List<TConseiller> mesConseiller = new List<TConseiller>();

            foreach (var c in q)
            {
                TConseiller mC = new TConseiller();
                mC.id_conseiller = (int)c.ID_CONSEILLER;
                mC.nom_conseiller = c.NOM_CONSEILLER;
                mC.prenom_conseiller = c.PRENOM_CONSEILLER;
                mesConseiller.Add(mC);
            }
            return mesConseiller;
        }

    }
}
