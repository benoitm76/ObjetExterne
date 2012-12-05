using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScutedelaBDD
{
    public class TMetier
    {
        private int id_metier;
        private int id_type_metier;
        private string metier;
        private TTypeMetier typeMetier;

        public TTypeMetier TypeMetier
        {
            get { return typeMetier; }
            set { typeMetier = value; }
        }

        public int Id_metier
        {
            get { return id_metier; }
            set { id_metier = value; }
        }

        public int Id_type_metier
        {
            get { return id_type_metier; }
            set { id_type_metier = value; }
        }

        public string Metier
        {
            get { return metier; }
            set { metier = value; }
        }

        public TMetier()
        {
        }

        public TMetier(int aId)
        {
            this.Id_metier = aId;
        }

        public static List<TMetier> findAll()
        {
            DataSQLDataContext db = new DataSQLDataContext();

            var q = from m in db.T_METIER
                    select m;

            List<TMetier> mesMetiers = new List<TMetier>();

            foreach (var m in q)
            {
                TMetier mM = new TMetier((int)m.ID_METIER);
                mM.id_type_metier = (int)m.ID_TYPE_METIER;
                mM.metier = m.METIER;
                mM.typeMetier = TTypeMetier.findById((int)mM.id_type_metier)[0];
                mesMetiers.Add(mM);
            }
            return mesMetiers;
        }

        public static List<TMetier> findByIdMetier(int aId)
        {
            DataSQLDataContext db = new DataSQLDataContext();

            var q = from m in db.T_METIER
                    where m.ID_METIER == aId
                    select m;

            List<TMetier> mesMetiers = new List<TMetier>();

            foreach (var m in q)
            {
                TMetier mM = new TMetier((int)m.ID_METIER);
                mM.id_type_metier = (int)m.ID_TYPE_METIER;
                mM.metier = m.METIER;
                mM.typeMetier = TTypeMetier.findById((int)mM.id_type_metier)[0];
                mesMetiers.Add(mM);
            }
            return mesMetiers;
        }

        public static List<TMetier> findByIdTypeMetier(int aId)
        {
            DataSQLDataContext db = new DataSQLDataContext();

            var q = from m in db.T_METIER
                    where m.ID_TYPE_METIER == aId
                    select m;

            List<TMetier> mesMetiers = new List<TMetier>();

            foreach (var m in q)
            {
                TMetier mM = new TMetier((int)m.ID_METIER);
                mM.id_type_metier = (int)m.ID_TYPE_METIER;
                mM.metier = m.METIER;
                mM.typeMetier = TTypeMetier.findById((int)mM.id_type_metier)[0];
                mesMetiers.Add(mM);
            }
            return mesMetiers;
        }

        public static List<TMetier> findByMetier(string aNom)
        {
            DataSQLDataContext db = new DataSQLDataContext();

            var q = from m in db.T_METIER
                    where m.METIER == aNom
                    select m;

            List<TMetier> mesMetiers = new List<TMetier>();

            foreach (var m in q)
            {
                TMetier mM = new TMetier((int)m.ID_METIER);
                mM.id_type_metier = (int)m.ID_TYPE_METIER;
                mM.metier = m.METIER;
                mM.typeMetier = TTypeMetier.findById((int)mM.id_type_metier)[0];
                mesMetiers.Add(mM);
            }
            return mesMetiers;
        }
    }
}
