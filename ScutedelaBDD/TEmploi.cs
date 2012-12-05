using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScutedelaBDD;

namespace ScutedelaBDD
{
    public class TEmploi
    {
        private int id_emploi;
        private int id_metier;
        private int id_personne;
        private string nom_emploi;
        private List<TPersonne> personnesLiees;

        public List<TPersonne> PersonnesLiees
        {
            get { return personnesLiees; }
            set { personnesLiees = value; }
        }
        private List<TMetier> metierLiees;

        public List<TMetier> MetierLiees
        {
            get { return metierLiees; }
            set { metierLiees = value; }
        }

        public int Id_emploi
        {
            get { return id_emploi; }
            set { id_emploi = value; }
        }

        public int Id_metier
        {
            get { return id_metier; }
            set { id_metier = value; }
        }

        public int Id_personne
        {
            get { return id_personne; }
            set { id_personne = value; }
        }

        public string Nom_emploi
        {
            get { return nom_emploi; }
            set { nom_emploi = value; }
        }

        public TEmploi()
        {
        }

        public TEmploi(int aIdEmploi)
        {
            this.id_emploi = aIdEmploi;
        }

        public static List<TEmploi> findAll()
        {
            DataSQLDataContext db = new DataSQLDataContext();

            var q = from e in db.T_EMPLOI
                    select e;

            List<TEmploi> mesEmplois = new List<TEmploi>();

            foreach (var e in q)
            {
                TEmploi mE = new TEmploi((int)e.ID_EMPLOI);
                mE.id_metier = (int)e.ID_METIER;
                mE.id_personne = (int)e.ID_PERSONNE;
                mE.nom_emploi = e.NOM_EMPLOI;
                mE.personnesLiees = TPersonne.findByIdPersonne((int)mE.id_personne);
                mE.metierLiees = TMetier.findByIdMetier(mE.id_metier);
                mesEmplois.Add(mE);
            }

            return mesEmplois;
        }

        public static List<TEmploi> findByIdEmploi(int aId)
        {
            DataSQLDataContext db = new DataSQLDataContext();

            var q = from e in db.T_EMPLOI where e.ID_EMPLOI == aId
                    select e;

            List<TEmploi> mesEmplois = new List<TEmploi>();

            foreach (var e in q)
            {
                TEmploi mE = new TEmploi((int)e.ID_EMPLOI);
                mE.id_metier = (int)e.ID_METIER;
                mE.id_personne = (int)e.ID_PERSONNE;
                mE.nom_emploi = e.NOM_EMPLOI;
                mE.personnesLiees = TPersonne.findByIdPersonne((int)mE.id_personne);
                mE.metierLiees = TMetier.findByIdMetier(mE.id_metier);
                mesEmplois.Add(mE);
            }

            return mesEmplois;
        }

        public static List<TEmploi> findByIdMetier(int aId)
        {
            DataSQLDataContext db = new DataSQLDataContext();

            var q = from e in db.T_EMPLOI where e.ID_METIER == aId
                    select e;

            List<TEmploi> mesEmplois = new List<TEmploi>();

            foreach (var e in q)
            {
                TEmploi mE = new TEmploi((int)e.ID_EMPLOI);
                mE.id_metier = (int)e.ID_METIER;
                mE.id_personne = (int)e.ID_PERSONNE;
                mE.nom_emploi = e.NOM_EMPLOI;
                mE.personnesLiees = TPersonne.findByIdPersonne((int)mE.id_personne);
                mE.metierLiees = TMetier.findByIdMetier(mE.id_metier);
                mesEmplois.Add(mE);
            }

            return mesEmplois;
        }

        public static List<TEmploi> findByIdPersonne(int aId)
        {
            DataSQLDataContext db = new DataSQLDataContext();

            var q = from e in db.T_EMPLOI where e.ID_PERSONNE == aId
                    select e;

            List<TEmploi> mesEmplois = new List<TEmploi>();

            foreach (var e in q)
            {
                TEmploi mE = new TEmploi((int)e.ID_EMPLOI);
                mE.id_metier = (int)e.ID_METIER;
                mE.id_personne = (int)e.ID_PERSONNE;
                mE.nom_emploi = e.NOM_EMPLOI;
                mE.personnesLiees = TPersonne.findByIdPersonne((int)mE.id_personne);
                mE.metierLiees = TMetier.findByIdMetier(mE.id_metier);
                mesEmplois.Add(mE);
            }

            return mesEmplois;
        }

        public static List<TEmploi> findByNomEmploi(string aNom)
        {
            DataSQLDataContext db = new DataSQLDataContext();

            var q = from e in db.T_EMPLOI
                    where e.NOM_EMPLOI == aNom
                    select e;

            List<TEmploi> mesEmplois = new List<TEmploi>();

            foreach (var e in q)
            {
                TEmploi mE = new TEmploi((int)e.ID_EMPLOI);
                mE.id_metier = (int)e.ID_METIER;
                mE.id_personne = (int)e.ID_PERSONNE;
                mE.nom_emploi = e.NOM_EMPLOI;
                mE.personnesLiees = TPersonne.findByIdPersonne((int)mE.id_personne);
                mE.metierLiees = TMetier.findByIdMetier(mE.id_metier);
                mesEmplois.Add(mE);
            }

            return mesEmplois;
        }
    }
}
