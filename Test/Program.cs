using ScutedelaBDD;
using ObjetExterne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Intérogation C#
            /*
            ServiceReference1.WebServiceNetClient pxy = new ServiceReference1.WebServiceNetClient();
            InfoPersonne ipz = new InfoPersonne();
            ipz.Prenom = "V";
            InfoPersonne[] lip = pxy.recherchePersonnes(ipz);

            foreach (InfoPersonne ip in lip)
            {
                Console.WriteLine(ip.Nom + " - " + ip.Prenom);
            }
            */
            #endregion
            #region Intérogation Java
            WebService.WebServiceNetClient pxy = new WebService.WebServiceNetClient();
            InfoPersonne ipz = new InfoPersonne();
            ipz.Prenom = "Vincent";
            InfoPersonne[] lip = pxy.rechercheExtrePersonne(ipz);
            foreach (InfoPersonne ip in lip)
            {
                System.Console.Out.WriteLine(ip.Nom);
            }
            #endregion
            #region Osef
            /*
            DataSQLDataContext db = new DataSQLDataContext();
            var q = from p in db.T_PERSONNE
                    select p;

            q = q.Where(p => p.PRENOM.Contains("Vin"));
            

            foreach (var p in q)
            {
                Console.WriteLine(p.NOM + " - " + p.PRENOM);
            }*/
            #endregion
            Console.In.Read();
        }
    }
}
