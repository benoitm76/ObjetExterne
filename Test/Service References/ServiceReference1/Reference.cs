﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.18010
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Test.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IWebServiceNet")]
    public interface IWebServiceNet {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWebServiceNet/rechercheExtrePersonne", ReplyAction="http://tempuri.org/IWebServiceNet/rechercheExtrePersonneResponse")]
        ObjetExterne.InfoPersonne[] rechercheExtrePersonne(ObjetExterne.InfoPersonne searchip);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWebServiceNet/rechercheExtrePersonne", ReplyAction="http://tempuri.org/IWebServiceNet/rechercheExtrePersonneResponse")]
        System.Threading.Tasks.Task<ObjetExterne.InfoPersonne[]> rechercheExtrePersonneAsync(ObjetExterne.InfoPersonne searchip);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWebServiceNet/recherchePersonnes", ReplyAction="http://tempuri.org/IWebServiceNet/recherchePersonnesResponse")]
        ObjetExterne.InfoPersonne[] recherchePersonnes(ObjetExterne.InfoPersonne ip);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWebServiceNet/recherchePersonnes", ReplyAction="http://tempuri.org/IWebServiceNet/recherchePersonnesResponse")]
        System.Threading.Tasks.Task<ObjetExterne.InfoPersonne[]> recherchePersonnesAsync(ObjetExterne.InfoPersonne ip);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWebServiceNetChannel : Test.ServiceReference1.IWebServiceNet, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceNetClient : System.ServiceModel.ClientBase<Test.ServiceReference1.IWebServiceNet>, Test.ServiceReference1.IWebServiceNet {
        
        public WebServiceNetClient() {
        }
        
        public WebServiceNetClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceNetClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceNetClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceNetClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ObjetExterne.InfoPersonne[] rechercheExtrePersonne(ObjetExterne.InfoPersonne searchip) {
            return base.Channel.rechercheExtrePersonne(searchip);
        }
        
        public System.Threading.Tasks.Task<ObjetExterne.InfoPersonne[]> rechercheExtrePersonneAsync(ObjetExterne.InfoPersonne searchip) {
            return base.Channel.rechercheExtrePersonneAsync(searchip);
        }
        
        public ObjetExterne.InfoPersonne[] recherchePersonnes(ObjetExterne.InfoPersonne ip) {
            return base.Channel.recherchePersonnes(ip);
        }
        
        public System.Threading.Tasks.Task<ObjetExterne.InfoPersonne[]> recherchePersonnesAsync(ObjetExterne.InfoPersonne ip) {
            return base.Channel.recherchePersonnesAsync(ip);
        }
    }
}
