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
            WebService.WebServiceNetClient pxy = new WebService.WebServiceNetClient();
            InfoPersonne ipz = new InfoPersonne();
            ipz.Prenom = "Vincent";
            InfoPersonne[] lip = pxy.rechercheExtrePersonne(ipz);
            foreach (InfoPersonne ip in lip)
            {
                System.Console.Out.WriteLine(ip.Nom);
            }
            Console.In.Read();
        }
    }
}
