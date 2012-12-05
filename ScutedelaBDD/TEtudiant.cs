using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScutedelaBDD
{
    public class TEtudiant
    {
        private int id_etudiant;
        private int id_personne;
        private int n_carte;

        public int Id_etudiant
        {
            get { return id_etudiant; }
            set { id_etudiant = value; }
        }

        public int Id_personne
        {
            get { return id_personne; }
            set { id_personne = value; }
        }

        public int N_carte
        {
            get { return n_carte; }
            set { n_carte = value; }
        }

        public TEtudiant()
        {
        }

        public TEtudiant(int aId)
        {
            this.id_etudiant = aId;
        }

        public static List<TEtudiant> findAll()
        {
            DataSQLDataContext db = new DataSQLDataContext();

            var q = from e in db.T_ETUDIANT
                    select e;

            List<TEtudiant> mesEtudiants = new List<TEtudiant>();

            foreach (var e in q)
            {
                TEtudiant mE = new TEtudiant((int)e.ID_ETUDIANT);
                mE.id_personne = (int)e.ID_PERSONNE;
                mE.n_carte = (int)e.N_CARTE;
            }

            return mesEtudiants;
        }

        public static List<TEtudiant> findByIdEtudiant(int aId)
        {
            DataSQLDataContext db = new DataSQLDataContext();

            var q = from e in db.T_ETUDIANT
                    where e.ID_ETUDIANT == aId
                    select e;

            List<TEtudiant> mesEtudiants = new List<TEtudiant>();

            foreach (var e in q)
            {
                TEtudiant mE = new TEtudiant((int)e.ID_ETUDIANT);
                mE.id_personne = (int)e.ID_PERSONNE;
                mE.n_carte = (int)e.N_CARTE;
            }

            return mesEtudiants;
        }

        public static List<TEtudiant> findByIdPersonne(int aId)
        {
            DataSQLDataContext db = new DataSQLDataContext();

            var q = from e in db.T_ETUDIANT
                    where e.ID_PERSONNE == aId
                    select e;

            List<TEtudiant> mesEtudiants = new List<TEtudiant>();

            foreach (var e in q)
            {
                TEtudiant mE = new TEtudiant((int)e.ID_ETUDIANT);
                mE.id_personne = (int)e.ID_PERSONNE;
                mE.n_carte = (int)e.N_CARTE;
            }

            return mesEtudiants;
        }

        public static List<TEtudiant> findByNoCarte(int aId)
        {
            DataSQLDataContext db = new DataSQLDataContext();

            var q = from e in db.T_ETUDIANT
                    where e.N_CARTE == aId
                    select e;

            List<TEtudiant> mesEtudiants = new List<TEtudiant>();

            foreach (var e in q)
            {
                TEtudiant mE = new TEtudiant((int)e.ID_ETUDIANT);
                mE.id_personne = (int)e.ID_PERSONNE;
                mE.n_carte = (int)e.N_CARTE;
            }

            return mesEtudiants;
        }
    }
}
