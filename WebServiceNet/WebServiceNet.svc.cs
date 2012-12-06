using ObjetExterne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ScutedelaBDD;

namespace WebServiceNet
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "WebServiceNet" à la fois dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez WebServiceNet.svc ou WebServiceNet.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class WebServiceNet : IWebServiceNet
    {
        public List<InfoPersonne> rechercheExtrePersonne(InfoPersonne searchip)
        {
            ServiceReference1.PersonneWebServiceClient pxy = new ServiceReference1.PersonneWebServiceClient();
            ServiceReference1.infoPersonne[] jlip = pxy.RecherchePersonnes(convertToCSharpJavaPersonne(searchip), false);
            List<InfoPersonne> lip = new List<InfoPersonne>();            
            foreach (ServiceReference1.infoPersonne jip in jlip)
            {
                lip.Add(convertJavaPersonneToCSharp(jip));
            }
            return lip;
        }

        public List<InfoPersonne> recherchePersonnes(InfoPersonne ip) {

            List<InfoPersonne> liste = new List<InfoPersonne>();
            DataSQLDataContext db = new DataSQLDataContext();

            var q = from p in db.T_PERSONNE
                    select p;

            q = q.Where(p => p.NOM.Contains((ip.Nom != null) ? ip.Nom : ""));
            q = q.Where(p => p.PRENOM.Contains((ip.Prenom != null) ? ip.Prenom : ""));

            foreach(var p in q)
            {
                liste.Add(new InfoPersonne(TPersonne.findByIdPersonne((int)p.ID_PERSONNE)[0]));
            }

            return liste;
        }

        public InfoPersonne convertJavaPersonneToCSharp(ServiceReference1.infoPersonne jip)
        {
            InfoPersonne ip = new InfoPersonne();
            ip.Nom = jip.nom;
            ip.Prenom = jip.prenom;
            ip.Sexe = jip.sexe;
            ip.DateNaissance = jip.dateNaissance;
            return ip;
        }

        public ServiceReference1.infoPersonne convertToCSharpJavaPersonne(InfoPersonne ip)
        {
            ServiceReference1.infoPersonne jip = new ServiceReference1.infoPersonne();
            jip.nom = ip.Nom;
            jip.prenom = ip.Prenom;
            jip.sexe = ip.Sexe;
            jip.dateNaissance = ip.DateNaissance;
            return jip;
        }
    }
}
