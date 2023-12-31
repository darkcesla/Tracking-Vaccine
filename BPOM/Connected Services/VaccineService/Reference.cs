﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BPOM.VaccineService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="daftar_vaksin", Namespace="http://schemas.datacontract.org/2004/07/VaccineService")]
    [System.SerializableAttribute()]
    public partial class daftar_vaksin : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string id_registrasiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int id_vaksinField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string jenis_vaksinField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string jumlahField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nama_vaksinField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string status_vaksinField;
        
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
        public string id_registrasi {
            get {
                return this.id_registrasiField;
            }
            set {
                if ((object.ReferenceEquals(this.id_registrasiField, value) != true)) {
                    this.id_registrasiField = value;
                    this.RaisePropertyChanged("id_registrasi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id_vaksin {
            get {
                return this.id_vaksinField;
            }
            set {
                if ((this.id_vaksinField.Equals(value) != true)) {
                    this.id_vaksinField = value;
                    this.RaisePropertyChanged("id_vaksin");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string jenis_vaksin {
            get {
                return this.jenis_vaksinField;
            }
            set {
                if ((object.ReferenceEquals(this.jenis_vaksinField, value) != true)) {
                    this.jenis_vaksinField = value;
                    this.RaisePropertyChanged("jenis_vaksin");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string jumlah {
            get {
                return this.jumlahField;
            }
            set {
                if ((object.ReferenceEquals(this.jumlahField, value) != true)) {
                    this.jumlahField = value;
                    this.RaisePropertyChanged("jumlah");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string nama_vaksin {
            get {
                return this.nama_vaksinField;
            }
            set {
                if ((object.ReferenceEquals(this.nama_vaksinField, value) != true)) {
                    this.nama_vaksinField = value;
                    this.RaisePropertyChanged("nama_vaksin");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string status_vaksin {
            get {
                return this.status_vaksinField;
            }
            set {
                if ((object.ReferenceEquals(this.status_vaksinField, value) != true)) {
                    this.status_vaksinField = value;
                    this.RaisePropertyChanged("status_vaksin");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="VaccineService.IVaccineService")]
    public interface IVaccineService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVaccineService/findAll", ReplyAction="http://tempuri.org/IVaccineService/findAllResponse")]
        BPOM.VaccineService.daftar_vaksin[] findAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVaccineService/findAll", ReplyAction="http://tempuri.org/IVaccineService/findAllResponse")]
        System.Threading.Tasks.Task<BPOM.VaccineService.daftar_vaksin[]> findAllAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IVaccineServiceChannel : BPOM.VaccineService.IVaccineService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class VaccineServiceClient : System.ServiceModel.ClientBase<BPOM.VaccineService.IVaccineService>, BPOM.VaccineService.IVaccineService {
        
        public VaccineServiceClient() {
        }
        
        public VaccineServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public VaccineServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public VaccineServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public VaccineServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public BPOM.VaccineService.daftar_vaksin[] findAll() {
            return base.Channel.findAll();
        }
        
        public System.Threading.Tasks.Task<BPOM.VaccineService.daftar_vaksin[]> findAllAsync() {
            return base.Channel.findAllAsync();
        }
    }
}
