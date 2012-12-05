using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScutedelaBDD
{
    public class TPersonne
    {
        private int id_personne;
        private int id_conseiller;
        private string nom;
        private string prenom;
        private DateTime date_de_naissance;
        private bool sexe;
        private TConseiller conseillerLie;
        private List<TEtudiant> etudiantLies;

        public List<TEtudiant> EtudiantLies
        {
            get { return etudiantLies; }
            set { etudiantLies = value; }
        }

        public int Id_personne
        {
            get { return id_personne; }
            set { id_personne = value; }
        }

        public int Id_conseiller
        {
            get { return id_conseiller; }
            set { id_conseiller = value; }
        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }

        public DateTime Date_de_naissance
        {
            get { return date_de_naissance; }
            set { date_de_naissance = value; }
        }

        public bool Sexe
        {
            get { return sexe; }
            set { sexe = value; }
        }
        
        public TConseiller ConseillerLie
        {
            get { return conseillerLie; }
            set { conseillerLie = value; }
        }

        public TPersonne()
        {
        }

        public TPersonne(int aId)
        {
            this.id_personne = aId;
        }

        public static List<TPersonne> findAll()
        {
            DataSQLDataContext db = new DataSQLDataContext();

            var q = from p in db.T_PERSONNE
                    select p;

            List<TPersonne> mesPersonnes = new List<TPersonne>();

            foreach (var p in q)
            {
                TPersonne mP = new TPersonne((int)p.ID_PERSONNE);
                mP.id_conseiller = (int)p.ID_CONSEILLER;
                mP.nom = p.NOM;
                mP.prenom = p.PRENOM;
                mP.date_de_naissance = (DateTime)p.DATE_DE_NAISSANCE;
                mP.sexe = ((p.SEXE == '0') ? false : true);
                mP.conseillerLie = TConseiller.findById((int)p.ID_CONSEILLER)[0];
                mP.etudiantLies = TEtudiant.findByIdPersonne((int)mP.id_personne);
                mesPersonnes.Add(mP);
            }
            return mesPersonnes;
        }

        public static List<TPersonne> findByIdPersonne(int aId)
        {
            DataSQLDataContext db = new DataSQLDataContext();

            var q = from p in db.T_PERSONNE
                    where p.ID_PERSONNE == aId
                    select p;

            List<TPersonne> mesPersonnes = new List<TPersonne>();

            foreach (var p in q)
            {
                TPersonne mP = new TPersonne((int)p.ID_PERSONNE);
                mP.id_conseiller = (int)p.ID_CONSEILLER;
                mP.nom = p.NOM;
                mP.prenom = p.PRENOM;
                mP.date_de_naissance = (DateTime)p.DATE_DE_NAISSANCE;
                mP.sexe = ((p.SEXE == '0') ? false : true);
                mP.conseillerLie = TConseiller.findById((int)p.ID_CONSEILLER)[0];
                mP.etudiantLies = TEtudiant.findByIdPersonne((int)mP.id_personne);
                mesPersonnes.Add(mP);
            }
            return mesPersonnes;
        }

        public static List<TPersonne> findByIdConseiller(int aId)
        {
            DataSQLDataContext db = new DataSQLDataContext();

            var q = from p in db.T_PERSONNE
                    where p.ID_CONSEILLER == aId
                    select p;

            List<TPersonne> mesPersonnes = new List<TPersonne>();

            foreach (var p in q)
            {
                TPersonne mP = new TPersonne((int)p.ID_PERSONNE);
                mP.id_conseiller = (int)p.ID_CONSEILLER;
                mP.nom = p.NOM;
                mP.prenom = p.PRENOM;
                mP.date_de_naissance = (DateTime)p.DATE_DE_NAISSANCE;
                mP.sexe = ((p.SEXE == '0') ? false : true);
                mP.conseillerLie = TConseiller.findById((int)p.ID_CONSEILLER)[0];
                mP.etudiantLies = TEtudiant.findByIdPersonne((int)mP.id_personne);
                mesPersonnes.Add(mP);
            }
            return mesPersonnes;
        }

        public static List<TPersonne> findByNom(string aNom)
        {
            DataSQLDataContext db = new DataSQLDataContext();

            var q = from p in db.T_PERSONNE
                    where p.NOM == aNom
                    select p;

            List<TPersonne> mesPersonnes = new List<TPersonne>();

            foreach (var p in q)
            {
                TPersonne mP = new TPersonne((int)p.ID_PERSONNE);
                mP.id_conseiller = (int)p.ID_CONSEILLER;
                mP.nom = p.NOM;
                mP.prenom = p.PRENOM;
                mP.date_de_naissance = (DateTime)p.DATE_DE_NAISSANCE;
                mP.sexe = ((p.SEXE == '0') ? false : true);
                mP.conseillerLie = TConseiller.findById((int)p.ID_CONSEILLER)[0];
                mP.etudiantLies = TEtudiant.findByIdPersonne((int)mP.id_personne);
                mesPersonnes.Add(mP);
            }
            return mesPersonnes;
        }

        public static List<TPersonne> findByPrenom(string aPrenom)
        {
            DataSQLDataContext db = new DataSQLDataContext();

            var q = from p in db.T_PERSONNE
                    where p.PRENOM == aPrenom
                    select p;

            List<TPersonne> mesPersonnes = new List<TPersonne>();

            foreach (var p in q)
            {
                TPersonne mP = new TPersonne((int)p.ID_PERSONNE);
                mP.id_conseiller = (int)p.ID_CONSEILLER;
                mP.nom = p.NOM;
                mP.prenom = p.PRENOM;
                mP.date_de_naissance = (DateTime)p.DATE_DE_NAISSANCE;
                mP.sexe = ((p.SEXE == '0') ? false : true);
                mP.conseillerLie = TConseiller.findById((int)p.ID_CONSEILLER)[0];
                mP.etudiantLies = TEtudiant.findByIdPersonne((int)mP.id_personne);
                mesPersonnes.Add(mP);
            }
            return mesPersonnes;
        }

        public static List<TPersonne> findByDate(DateTime aDate)
        {
            DataSQLDataContext db = new DataSQLDataContext();

            var q = from p in db.T_PERSONNE
                    where p.DATE_DE_NAISSANCE == aDate
                    select p;

            List<TPersonne> mesPersonnes = new List<TPersonne>();

            foreach (var p in q)
            {
                TPersonne mP = new TPersonne((int)p.ID_PERSONNE);
                mP.id_conseiller = (int)p.ID_CONSEILLER;
                mP.nom = p.NOM;
                mP.prenom = p.PRENOM;
                mP.date_de_naissance = (DateTime)p.DATE_DE_NAISSANCE;
                mP.sexe = ((p.SEXE == '0') ? false : true);
                mP.conseillerLie = TConseiller.findById((int)p.ID_CONSEILLER)[0];
                mP.etudiantLies = TEtudiant.findByIdPersonne((int)mP.id_personne);
                mesPersonnes.Add(mP);
            }
            return mesPersonnes;
        }

        public static List<TPersonne> findBySexe(bool aSexe)
        {
            DataSQLDataContext db = new DataSQLDataContext();

            var q = from p in db.T_PERSONNE
                    where p.SEXE == ((aSexe == true) ? '1' : '0')
                    select p;

            List<TPersonne> mesPersonnes = new List<TPersonne>();

            foreach (var p in q)
            {
                TPersonne mP = new TPersonne((int)p.ID_PERSONNE);
                mP.id_conseiller = (int)p.ID_CONSEILLER;
                mP.nom = p.NOM;
                mP.prenom = p.PRENOM;
                mP.date_de_naissance = (DateTime)p.DATE_DE_NAISSANCE;
                mP.sexe = ((p.SEXE == '0') ? false : true);
                mP.conseillerLie = TConseiller.findById((int)p.ID_CONSEILLER)[0];
                mP.etudiantLies = TEtudiant.findByIdPersonne((int)mP.id_personne);
                mesPersonnes.Add(mP);
            }
            return mesPersonnes;
        }
    }
}
