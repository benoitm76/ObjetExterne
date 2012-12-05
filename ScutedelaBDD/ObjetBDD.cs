using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScutedelaBDD
{
    public static class ObjetBDD
    {
        #region Conseiller

        public static Object TConseiller_All()
        {
            DataSQLDataContext db = new DataSQLDataContext();
            var q = from c in db.T_CONSEILLER
                    select c;
            return q;
        }

        public static Object TConseiller_byId(int aId)
        {
            DataSQLDataContext db = new DataSQLDataContext();
            var q = from c in db.T_CONSEILLER where c.ID_CONSEILLER == aId
                    select c;
            return q;
        }

        public static Object TConseiller_byNom(string aNom)
        {
            DataSQLDataContext db = new DataSQLDataContext();
            var q = from c in db.T_CONSEILLER
                    where c.NOM_CONSEILLER == aNom
                    select c;
            return q;
        }

        public static Object TConseiller_byPrenom(string aPrenom)
        {
            DataSQLDataContext db = new DataSQLDataContext();
            var q = from c in db.T_CONSEILLER
                    where c.PRENOM_CONSEILLER == aPrenom
                    select c;
            return q;
        }

        #endregion

        #region Personne

        public static Object TPersonne_All()
        {
            DataSQLDataContext db = new DataSQLDataContext();

            var q = from p in db.T_PERSONNE
                    select p;
            return q;
        }

        public static Object TPersonne_byId(int aId)
        {
            DataSQLDataContext db = new DataSQLDataContext();

            var q = from p in db.T_PERSONNE
                    where p.ID_PERSONNE == aId
                    select p;

            return q;
        }

        public static Object TPersonne_byIdConseiller(int aId)
        {
            DataSQLDataContext db = new DataSQLDataContext();

            var q = from p in db.T_PERSONNE
                    where p.ID_CONSEILLER == aId
                    select p;

            return q;
        }

        public static Object TPersonne_byNom(string aNom)
        {
            DataSQLDataContext db = new DataSQLDataContext();

            var q = from p in db.T_PERSONNE
                    where p.NOM == aNom
                    select p;

            return q;
        }

        public static Object TPersonne_byPrenom(string aPrenom)
        {
            DataSQLDataContext db = new DataSQLDataContext();

            var q = from p in db.T_PERSONNE
                    where p.PRENOM == aPrenom
                    select p;

            return q;
        }

        public static Object TPersonne_byNom(DateTime aDate)
        {
            DataSQLDataContext db = new DataSQLDataContext();

            var q = from p in db.T_PERSONNE
                    where p.DATE_DE_NAISSANCE == aDate
                    select p;

            return q;
        }

        public static Object TPersonne_byNom(bool aSexe)
        {
            DataSQLDataContext db = new DataSQLDataContext();

            var q = from p in db.T_PERSONNE
                    where p.SEXE == ((aSexe == false) ? '0' : '1')
                    select p;

            return q;
        }

        #endregion

        #region Emploi

        public static Object TEmploi_All()
        {
            DataSQLDataContext db = new DataSQLDataContext();

            var q = from e in db.T_EMPLOI
                    select e;
            return q;
        }

        public static Object TEmploi_byId(int aId)
        {
            DataSQLDataContext db = new DataSQLDataContext();

            var q = from e in db.T_EMPLOI
                    where e.ID_EMPLOI == aId
                    select e;
            return q;
        }

        public static Object TEmploi_byIdMetier(int aId)
        {
            DataSQLDataContext db = new DataSQLDataContext();

            var q = from e in db.T_EMPLOI
                    where e.ID_METIER == aId
                    select e;
            return q;
        }

        public static Object TEmploi_byIdPersonne(int aId)
        {
            DataSQLDataContext db = new DataSQLDataContext();

            var q = from e in db.T_EMPLOI
                    where e.ID_PERSONNE == aId
                    select e;
            return q;
        }

        public static Object TEmploi_byNom(string aNom)
        {
            DataSQLDataContext db = new DataSQLDataContext();

            var q = from e in db.T_EMPLOI
                    where e.NOM_EMPLOI == aNom
                    select e;
            return q;
        }

        #endregion

        #region Etudiant

        public static Object TEtudiant_All()
        {
            DataSQLDataContext db = new DataSQLDataContext();

            var q = from e in db.T_ETUDIANT
                    select e;
            return q;
        }

        public static Object TEtudiant_byId(int aId)
        {
            DataSQLDataContext db = new DataSQLDataContext();

            var q = from e in db.T_ETUDIANT
                    where e.ID_ETUDIANT == aId
                    select e;
            return q;
        }

        public static Object TEtudiant_byIdPersonne(int aId)
        {
            DataSQLDataContext db = new DataSQLDataContext();

            var q = from e in db.T_ETUDIANT
                    where e.ID_PERSONNE == aId
                    select e;
            return q;
        }

        public static Object TEtudiant_byNoCarte(int aNoCarte)
        {
            DataSQLDataContext db = new DataSQLDataContext();

            var q = from e in db.T_ETUDIANT
                    where e.N_CARTE == aNoCarte
                    select e;
            return q;
        }

        #endregion

        #region Metier

        public static Object TMetier_All()
        {
            DataSQLDataContext db = new DataSQLDataContext();

            var q = from m in db.T_METIER
                    select m;
            return q;
        }

        #endregion

    }
}
