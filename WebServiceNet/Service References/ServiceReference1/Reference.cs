﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.18010
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://externe.webservices.com/", ConfigurationName="ServiceReference1.PersonneWebService")]
    public interface PersonneWebService {
        
        // CODEGEN : Le paramètre 'return' nécessite des informations de schéma supplémentaires qui ne peuvent pas être capturées en utilisant le mode du paramètre. L'attribut spécifique est 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://externe.webservices.com/PersonneWebService/helloRequest", ReplyAction="http://externe.webservices.com/PersonneWebService/helloResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ServiceReference1.helloResponse hello(ServiceReference1.helloRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://externe.webservices.com/PersonneWebService/helloRequest", ReplyAction="http://externe.webservices.com/PersonneWebService/helloResponse")]
        System.Threading.Tasks.Task<ServiceReference1.helloResponse> helloAsync(ServiceReference1.helloRequest request);
        
        // CODEGEN : Le paramètre 'return' nécessite des informations de schéma supplémentaires qui ne peuvent pas être capturées en utilisant le mode du paramètre. L'attribut spécifique est 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://externe.webservices.com/PersonneWebService/RecherchePersonneRequest", ReplyAction="http://externe.webservices.com/PersonneWebService/RecherchePersonneResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ServiceReference1.RecherchePersonneResponse RecherchePersonne(ServiceReference1.RecherchePersonneRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://externe.webservices.com/PersonneWebService/RecherchePersonneRequest", ReplyAction="http://externe.webservices.com/PersonneWebService/RecherchePersonneResponse")]
        System.Threading.Tasks.Task<ServiceReference1.RecherchePersonneResponse> RecherchePersonneAsync(ServiceReference1.RecherchePersonneRequest request);
        
        // CODEGEN : Le paramètre 'return' nécessite des informations de schéma supplémentaires qui ne peuvent pas être capturées en utilisant le mode du paramètre. L'attribut spécifique est 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://externe.webservices.com/PersonneWebService/GetPersonneRequest", ReplyAction="http://externe.webservices.com/PersonneWebService/GetPersonneResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ServiceReference1.GetPersonneResponse GetPersonne(ServiceReference1.GetPersonneRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://externe.webservices.com/PersonneWebService/GetPersonneRequest", ReplyAction="http://externe.webservices.com/PersonneWebService/GetPersonneResponse")]
        System.Threading.Tasks.Task<ServiceReference1.GetPersonneResponse> GetPersonneAsync(ServiceReference1.GetPersonneRequest request);
        
        // CODEGEN : Le paramètre 'return' nécessite des informations de schéma supplémentaires qui ne peuvent pas être capturées en utilisant le mode du paramètre. L'attribut spécifique est 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://externe.webservices.com/PersonneWebService/GetAllPersonnesRequest", ReplyAction="http://externe.webservices.com/PersonneWebService/GetAllPersonnesResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ServiceReference1.GetAllPersonnesResponse GetAllPersonnes(ServiceReference1.GetAllPersonnesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://externe.webservices.com/PersonneWebService/GetAllPersonnesRequest", ReplyAction="http://externe.webservices.com/PersonneWebService/GetAllPersonnesResponse")]
        System.Threading.Tasks.Task<ServiceReference1.GetAllPersonnesResponse> GetAllPersonnesAsync(ServiceReference1.GetAllPersonnesRequest request);
        
        // CODEGEN : Le paramètre 'return' nécessite des informations de schéma supplémentaires qui ne peuvent pas être capturées en utilisant le mode du paramètre. L'attribut spécifique est 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://externe.webservices.com/PersonneWebService/RecherchePersonnesRequest", ReplyAction="http://externe.webservices.com/PersonneWebService/RecherchePersonnesResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ServiceReference1.RecherchePersonnesResponse RecherchePersonnes(ServiceReference1.RecherchePersonnesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://externe.webservices.com/PersonneWebService/RecherchePersonnesRequest", ReplyAction="http://externe.webservices.com/PersonneWebService/RecherchePersonnesResponse")]
        System.Threading.Tasks.Task<ServiceReference1.RecherchePersonnesResponse> RecherchePersonnesAsync(ServiceReference1.RecherchePersonnesRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="hello", WrapperNamespace="http://externe.webservices.com/", IsWrapped=true)]
    public partial class helloRequest {
        
        public helloRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="helloResponse", WrapperNamespace="http://externe.webservices.com/", IsWrapped=true)]
    public partial class helloResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://externe.webservices.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string @return;
        
        public helloResponse() {
        }
        
        public helloResponse(string @return) {
            this.@return = @return;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://externe.webservices.com/")]
    public partial class infoPersonne : object, System.ComponentModel.INotifyPropertyChanged {
        
        private infoConseiller conseillerField;
        
        private string dateNaissanceField;
        
        private infoEmploi[] emploisField;
        
        private infoFinanceur financeurField;
        
        private int idField;
        
        private string nomField;
        
        private string prenomField;
        
        private bool sexeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public infoConseiller conseiller {
            get {
                return this.conseillerField;
            }
            set {
                this.conseillerField = value;
                this.RaisePropertyChanged("conseiller");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string dateNaissance {
            get {
                return this.dateNaissanceField;
            }
            set {
                this.dateNaissanceField = value;
                this.RaisePropertyChanged("dateNaissance");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("emplois", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=2)]
        public infoEmploi[] emplois {
            get {
                return this.emploisField;
            }
            set {
                this.emploisField = value;
                this.RaisePropertyChanged("emplois");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public infoFinanceur financeur {
            get {
                return this.financeurField;
            }
            set {
                this.financeurField = value;
                this.RaisePropertyChanged("financeur");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public int ID {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                this.RaisePropertyChanged("ID");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string nom {
            get {
                return this.nomField;
            }
            set {
                this.nomField = value;
                this.RaisePropertyChanged("nom");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string prenom {
            get {
                return this.prenomField;
            }
            set {
                this.prenomField = value;
                this.RaisePropertyChanged("prenom");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public bool sexe {
            get {
                return this.sexeField;
            }
            set {
                this.sexeField = value;
                this.RaisePropertyChanged("sexe");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://externe.webservices.com/")]
    public partial class infoConseiller : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int idField;
        
        private string nomField;
        
        private string prenomField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public int ID {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                this.RaisePropertyChanged("ID");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string nom {
            get {
                return this.nomField;
            }
            set {
                this.nomField = value;
                this.RaisePropertyChanged("nom");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string prenom {
            get {
                return this.prenomField;
            }
            set {
                this.prenomField = value;
                this.RaisePropertyChanged("prenom");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://externe.webservices.com/")]
    public partial class infoFinanceur : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int idField;
        
        private string nomField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public int ID {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                this.RaisePropertyChanged("ID");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string nom {
            get {
                return this.nomField;
            }
            set {
                this.nomField = value;
                this.RaisePropertyChanged("nom");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://externe.webservices.com/")]
    public partial class infoType : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int idField;
        
        private string intituleField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public int ID {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                this.RaisePropertyChanged("ID");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string intitule {
            get {
                return this.intituleField;
            }
            set {
                this.intituleField = value;
                this.RaisePropertyChanged("intitule");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://externe.webservices.com/")]
    public partial class infoEmploi : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string dateDebutField;
        
        private string dateFinField;
        
        private int idField;
        
        private string nom_emploiField;
        
        private infoType typeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string dateDebut {
            get {
                return this.dateDebutField;
            }
            set {
                this.dateDebutField = value;
                this.RaisePropertyChanged("dateDebut");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string dateFin {
            get {
                return this.dateFinField;
            }
            set {
                this.dateFinField = value;
                this.RaisePropertyChanged("dateFin");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public int ID {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                this.RaisePropertyChanged("ID");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string nom_emploi {
            get {
                return this.nom_emploiField;
            }
            set {
                this.nom_emploiField = value;
                this.RaisePropertyChanged("nom_emploi");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public infoType type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
                this.RaisePropertyChanged("type");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="RecherchePersonne", WrapperNamespace="http://externe.webservices.com/", IsWrapped=true)]
    public partial class RecherchePersonneRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://externe.webservices.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string arg0;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://externe.webservices.com/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string arg1;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://externe.webservices.com/", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool arg2;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://externe.webservices.com/", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string arg3;
        
        public RecherchePersonneRequest() {
        }
        
        public RecherchePersonneRequest(string arg0, string arg1, bool arg2, string arg3) {
            this.arg0 = arg0;
            this.arg1 = arg1;
            this.arg2 = arg2;
            this.arg3 = arg3;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="RecherchePersonneResponse", WrapperNamespace="http://externe.webservices.com/", IsWrapped=true)]
    public partial class RecherchePersonneResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://externe.webservices.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public ServiceReference1.infoPersonne[] @return;
        
        public RecherchePersonneResponse() {
        }
        
        public RecherchePersonneResponse(ServiceReference1.infoPersonne[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetPersonne", WrapperNamespace="http://externe.webservices.com/", IsWrapped=true)]
    public partial class GetPersonneRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://externe.webservices.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int arg0;
        
        public GetPersonneRequest() {
        }
        
        public GetPersonneRequest(int arg0) {
            this.arg0 = arg0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetPersonneResponse", WrapperNamespace="http://externe.webservices.com/", IsWrapped=true)]
    public partial class GetPersonneResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://externe.webservices.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ServiceReference1.infoPersonne @return;
        
        public GetPersonneResponse() {
        }
        
        public GetPersonneResponse(ServiceReference1.infoPersonne @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetAllPersonnes", WrapperNamespace="http://externe.webservices.com/", IsWrapped=true)]
    public partial class GetAllPersonnesRequest {
        
        public GetAllPersonnesRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetAllPersonnesResponse", WrapperNamespace="http://externe.webservices.com/", IsWrapped=true)]
    public partial class GetAllPersonnesResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://externe.webservices.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ServiceReference1.infoPersonne[] @return;
        
        public GetAllPersonnesResponse() {
        }
        
        public GetAllPersonnesResponse(ServiceReference1.infoPersonne[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="RecherchePersonnes", WrapperNamespace="http://externe.webservices.com/", IsWrapped=true)]
    public partial class RecherchePersonnesRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://externe.webservices.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ServiceReference1.infoPersonne arg0;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://externe.webservices.com/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool arg1;
        
        public RecherchePersonnesRequest() {
        }
        
        public RecherchePersonnesRequest(ServiceReference1.infoPersonne arg0, bool arg1) {
            this.arg0 = arg0;
            this.arg1 = arg1;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="RecherchePersonnesResponse", WrapperNamespace="http://externe.webservices.com/", IsWrapped=true)]
    public partial class RecherchePersonnesResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://externe.webservices.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ServiceReference1.infoPersonne[] @return;
        
        public RecherchePersonnesResponse() {
        }
        
        public RecherchePersonnesResponse(ServiceReference1.infoPersonne[] @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface PersonneWebServiceChannel : ServiceReference1.PersonneWebService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PersonneWebServiceClient : System.ServiceModel.ClientBase<ServiceReference1.PersonneWebService>, ServiceReference1.PersonneWebService {
        
        public PersonneWebServiceClient() {
        }
        
        public PersonneWebServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PersonneWebServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PersonneWebServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PersonneWebServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ServiceReference1.helloResponse ServiceReference1.PersonneWebService.hello(ServiceReference1.helloRequest request) {
            return base.Channel.hello(request);
        }
        
        public string hello() {
            ServiceReference1.helloRequest inValue = new ServiceReference1.helloRequest();
            ServiceReference1.helloResponse retVal = ((ServiceReference1.PersonneWebService)(this)).hello(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1.helloResponse> ServiceReference1.PersonneWebService.helloAsync(ServiceReference1.helloRequest request) {
            return base.Channel.helloAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.helloResponse> helloAsync() {
            ServiceReference1.helloRequest inValue = new ServiceReference1.helloRequest();
            return ((ServiceReference1.PersonneWebService)(this)).helloAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ServiceReference1.RecherchePersonneResponse ServiceReference1.PersonneWebService.RecherchePersonne(ServiceReference1.RecherchePersonneRequest request) {
            return base.Channel.RecherchePersonne(request);
        }
        
        public ServiceReference1.infoPersonne[] RecherchePersonne(string arg0, string arg1, bool arg2, string arg3) {
            ServiceReference1.RecherchePersonneRequest inValue = new ServiceReference1.RecherchePersonneRequest();
            inValue.arg0 = arg0;
            inValue.arg1 = arg1;
            inValue.arg2 = arg2;
            inValue.arg3 = arg3;
            ServiceReference1.RecherchePersonneResponse retVal = ((ServiceReference1.PersonneWebService)(this)).RecherchePersonne(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1.RecherchePersonneResponse> ServiceReference1.PersonneWebService.RecherchePersonneAsync(ServiceReference1.RecherchePersonneRequest request) {
            return base.Channel.RecherchePersonneAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.RecherchePersonneResponse> RecherchePersonneAsync(string arg0, string arg1, bool arg2, string arg3) {
            ServiceReference1.RecherchePersonneRequest inValue = new ServiceReference1.RecherchePersonneRequest();
            inValue.arg0 = arg0;
            inValue.arg1 = arg1;
            inValue.arg2 = arg2;
            inValue.arg3 = arg3;
            return ((ServiceReference1.PersonneWebService)(this)).RecherchePersonneAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ServiceReference1.GetPersonneResponse ServiceReference1.PersonneWebService.GetPersonne(ServiceReference1.GetPersonneRequest request) {
            return base.Channel.GetPersonne(request);
        }
        
        public ServiceReference1.infoPersonne GetPersonne(int arg0) {
            ServiceReference1.GetPersonneRequest inValue = new ServiceReference1.GetPersonneRequest();
            inValue.arg0 = arg0;
            ServiceReference1.GetPersonneResponse retVal = ((ServiceReference1.PersonneWebService)(this)).GetPersonne(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1.GetPersonneResponse> ServiceReference1.PersonneWebService.GetPersonneAsync(ServiceReference1.GetPersonneRequest request) {
            return base.Channel.GetPersonneAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.GetPersonneResponse> GetPersonneAsync(int arg0) {
            ServiceReference1.GetPersonneRequest inValue = new ServiceReference1.GetPersonneRequest();
            inValue.arg0 = arg0;
            return ((ServiceReference1.PersonneWebService)(this)).GetPersonneAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ServiceReference1.GetAllPersonnesResponse ServiceReference1.PersonneWebService.GetAllPersonnes(ServiceReference1.GetAllPersonnesRequest request) {
            return base.Channel.GetAllPersonnes(request);
        }
        
        public ServiceReference1.infoPersonne[] GetAllPersonnes() {
            ServiceReference1.GetAllPersonnesRequest inValue = new ServiceReference1.GetAllPersonnesRequest();
            ServiceReference1.GetAllPersonnesResponse retVal = ((ServiceReference1.PersonneWebService)(this)).GetAllPersonnes(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1.GetAllPersonnesResponse> ServiceReference1.PersonneWebService.GetAllPersonnesAsync(ServiceReference1.GetAllPersonnesRequest request) {
            return base.Channel.GetAllPersonnesAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.GetAllPersonnesResponse> GetAllPersonnesAsync() {
            ServiceReference1.GetAllPersonnesRequest inValue = new ServiceReference1.GetAllPersonnesRequest();
            return ((ServiceReference1.PersonneWebService)(this)).GetAllPersonnesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ServiceReference1.RecherchePersonnesResponse ServiceReference1.PersonneWebService.RecherchePersonnes(ServiceReference1.RecherchePersonnesRequest request) {
            return base.Channel.RecherchePersonnes(request);
        }
        
        public ServiceReference1.infoPersonne[] RecherchePersonnes(ServiceReference1.infoPersonne arg0, bool arg1) {
            ServiceReference1.RecherchePersonnesRequest inValue = new ServiceReference1.RecherchePersonnesRequest();
            inValue.arg0 = arg0;
            inValue.arg1 = arg1;
            ServiceReference1.RecherchePersonnesResponse retVal = ((ServiceReference1.PersonneWebService)(this)).RecherchePersonnes(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1.RecherchePersonnesResponse> ServiceReference1.PersonneWebService.RecherchePersonnesAsync(ServiceReference1.RecherchePersonnesRequest request) {
            return base.Channel.RecherchePersonnesAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.RecherchePersonnesResponse> RecherchePersonnesAsync(ServiceReference1.infoPersonne arg0, bool arg1) {
            ServiceReference1.RecherchePersonnesRequest inValue = new ServiceReference1.RecherchePersonnesRequest();
            inValue.arg0 = arg0;
            inValue.arg1 = arg1;
            return ((ServiceReference1.PersonneWebService)(this)).RecherchePersonnesAsync(inValue);
        }
    }
}
