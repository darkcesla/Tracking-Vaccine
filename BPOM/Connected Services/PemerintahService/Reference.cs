﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BPOM.PemerintahService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="akun_pasien", Namespace="http://schemas.datacontract.org/2004/07/PemerintahService")]
    [System.SerializableAttribute()]
    public partial class akun_pasien : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int id_akunField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string namaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nikField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string passwordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int roleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string usernameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id_akun {
            get {
                return this.id_akunField;
            }
            set {
                if ((this.id_akunField.Equals(value) != true)) {
                    this.id_akunField = value;
                    this.RaisePropertyChanged("id_akun");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string nama {
            get {
                return this.namaField;
            }
            set {
                if ((object.ReferenceEquals(this.namaField, value) != true)) {
                    this.namaField = value;
                    this.RaisePropertyChanged("nama");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string nik {
            get {
                return this.nikField;
            }
            set {
                if ((object.ReferenceEquals(this.nikField, value) != true)) {
                    this.nikField = value;
                    this.RaisePropertyChanged("nik");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string password {
            get {
                return this.passwordField;
            }
            set {
                if ((object.ReferenceEquals(this.passwordField, value) != true)) {
                    this.passwordField = value;
                    this.RaisePropertyChanged("password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int role {
            get {
                return this.roleField;
            }
            set {
                if ((this.roleField.Equals(value) != true)) {
                    this.roleField = value;
                    this.RaisePropertyChanged("role");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string username {
            get {
                return this.usernameField;
            }
            set {
                if ((object.ReferenceEquals(this.usernameField, value) != true)) {
                    this.usernameField = value;
                    this.RaisePropertyChanged("username");
                }
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PemerintahService.IPemerintahService")]
    public interface IPemerintahService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPemerintahService/findAll", ReplyAction="http://tempuri.org/IPemerintahService/findAllResponse")]
        BPOM.PemerintahService.akun_pasien[] findAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPemerintahService/findAll", ReplyAction="http://tempuri.org/IPemerintahService/findAllResponse")]
        System.Threading.Tasks.Task<BPOM.PemerintahService.akun_pasien[]> findAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPemerintahService/findById", ReplyAction="http://tempuri.org/IPemerintahService/findByIdResponse")]
        BPOM.PemerintahService.akun_pasien[] findById(int id_akun);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPemerintahService/findById", ReplyAction="http://tempuri.org/IPemerintahService/findByIdResponse")]
        System.Threading.Tasks.Task<BPOM.PemerintahService.akun_pasien[]> findByIdAsync(int id_akun);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPemerintahService/findByNik", ReplyAction="http://tempuri.org/IPemerintahService/findByNikResponse")]
        BPOM.PemerintahService.akun_pasien[] findByNik(string nik);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPemerintahService/findByNik", ReplyAction="http://tempuri.org/IPemerintahService/findByNikResponse")]
        System.Threading.Tasks.Task<BPOM.PemerintahService.akun_pasien[]> findByNikAsync(string nik);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPemerintahService/findByNama", ReplyAction="http://tempuri.org/IPemerintahService/findByNamaResponse")]
        BPOM.PemerintahService.akun_pasien[] findByNama(string nama);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPemerintahService/findByNama", ReplyAction="http://tempuri.org/IPemerintahService/findByNamaResponse")]
        System.Threading.Tasks.Task<BPOM.PemerintahService.akun_pasien[]> findByNamaAsync(string nama);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPemerintahServiceChannel : BPOM.PemerintahService.IPemerintahService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PemerintahServiceClient : System.ServiceModel.ClientBase<BPOM.PemerintahService.IPemerintahService>, BPOM.PemerintahService.IPemerintahService {
        
        public PemerintahServiceClient() {
        }
        
        public PemerintahServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PemerintahServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PemerintahServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PemerintahServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public BPOM.PemerintahService.akun_pasien[] findAll() {
            return base.Channel.findAll();
        }
        
        public System.Threading.Tasks.Task<BPOM.PemerintahService.akun_pasien[]> findAllAsync() {
            return base.Channel.findAllAsync();
        }
        
        public BPOM.PemerintahService.akun_pasien[] findById(int id_akun) {
            return base.Channel.findById(id_akun);
        }
        
        public System.Threading.Tasks.Task<BPOM.PemerintahService.akun_pasien[]> findByIdAsync(int id_akun) {
            return base.Channel.findByIdAsync(id_akun);
        }
        
        public BPOM.PemerintahService.akun_pasien[] findByNik(string nik) {
            return base.Channel.findByNik(nik);
        }
        
        public System.Threading.Tasks.Task<BPOM.PemerintahService.akun_pasien[]> findByNikAsync(string nik) {
            return base.Channel.findByNikAsync(nik);
        }
        
        public BPOM.PemerintahService.akun_pasien[] findByNama(string nama) {
            return base.Channel.findByNama(nama);
        }
        
        public System.Threading.Tasks.Task<BPOM.PemerintahService.akun_pasien[]> findByNamaAsync(string nama) {
            return base.Channel.findByNamaAsync(nama);
        }
    }
}
