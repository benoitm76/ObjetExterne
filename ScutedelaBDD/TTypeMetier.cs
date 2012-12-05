using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScutedelaBDD
{
    public class TTypeMetier
    {
        private string type_metier;
        private int id_type_metier;

        public string Type_metier
        {
            get { return type_metier; }
            set { type_metier = value; }
        }

        public int Id_type_metier
        {
            get { return id_type_metier; }
            set { id_type_metier = value; }
        }

        public TTypeMetier()
        {
        }

        public TTypeMetier(int aId)
        {
            this.id_type_metier = aId;
        }

        public static List<TTypeMetier> findAll()
        {
            DataSQLDataContext db = new DataSQLDataContext();

            var q = from t in db.T_TYPE_METIER
                    select t;

            List<TTypeMetier> mesTypes = new List<TTypeMetier>();

            foreach (var t in q)
            {
                TTypeMetier mT = new TTypeMetier((int)t.ID_TYPE_METIER);
                mT.type_metier = t.TYPE_METIER;
                mesTypes.Add(mT);
            }

            return mesTypes;
        }

        public static List<TTypeMetier> findById(int aId)
        {
            DataSQLDataContext db = new DataSQLDataContext();

            var q = from t in db.T_TYPE_METIER where t.ID_TYPE_METIER == aId
                    select t;

            List<TTypeMetier> mesTypes = new List<TTypeMetier>();

            foreach (var t in q)
            {
                TTypeMetier mT = new TTypeMetier((int)t.ID_TYPE_METIER);
                mT.type_metier = t.TYPE_METIER;
                mesTypes.Add(mT);
            }

            return mesTypes;
        }
    }
}
