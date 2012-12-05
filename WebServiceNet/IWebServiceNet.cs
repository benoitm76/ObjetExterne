using ObjetExterne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebServiceNet
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IWebServiceNet" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IWebServiceNet
    {
        [OperationContract]
        List<InfoPersonne> rechercheExtrePersonne(InfoPersonne searchip);
    }
}
