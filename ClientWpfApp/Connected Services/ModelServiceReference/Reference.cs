﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientWpfApp.ModelServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RTU", Namespace="http://schemas.datacontract.org/2004/07/ModelWcfServiceLibrary.Model.RTU")]
    [System.SerializableAttribute()]
    public partial class RTU : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.ObjectModel.ObservableCollection<ClientWpfApp.ModelServiceReference.AnalogSignal> AnalogSignalsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.ObjectModel.ObservableCollection<ClientWpfApp.ModelServiceReference.DiscreteSignal> DiscreteSignalsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ClientWpfApp.ModelServiceReference.RTUData RTUDataField;
        
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
        public System.Collections.ObjectModel.ObservableCollection<ClientWpfApp.ModelServiceReference.AnalogSignal> AnalogSignals {
            get {
                return this.AnalogSignalsField;
            }
            set {
                if ((object.ReferenceEquals(this.AnalogSignalsField, value) != true)) {
                    this.AnalogSignalsField = value;
                    this.RaisePropertyChanged("AnalogSignals");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.ObjectModel.ObservableCollection<ClientWpfApp.ModelServiceReference.DiscreteSignal> DiscreteSignals {
            get {
                return this.DiscreteSignalsField;
            }
            set {
                if ((object.ReferenceEquals(this.DiscreteSignalsField, value) != true)) {
                    this.DiscreteSignalsField = value;
                    this.RaisePropertyChanged("DiscreteSignals");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ClientWpfApp.ModelServiceReference.RTUData RTUData {
            get {
                return this.RTUDataField;
            }
            set {
                if ((object.ReferenceEquals(this.RTUDataField, value) != true)) {
                    this.RTUDataField = value;
                    this.RaisePropertyChanged("RTUData");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RTUData", Namespace="http://schemas.datacontract.org/2004/07/ModelWcfServiceLibrary")]
    [System.SerializableAttribute()]
    public partial class RTUData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IpAddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PortField;
        
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
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IpAddress {
            get {
                return this.IpAddressField;
            }
            set {
                if ((object.ReferenceEquals(this.IpAddressField, value) != true)) {
                    this.IpAddressField = value;
                    this.RaisePropertyChanged("IpAddress");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Port {
            get {
                return this.PortField;
            }
            set {
                if ((this.PortField.Equals(value) != true)) {
                    this.PortField = value;
                    this.RaisePropertyChanged("Port");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AnalogSignal", Namespace="http://schemas.datacontract.org/2004/07/ModelWcfServiceLibrary.Model.Signals")]
    [System.SerializableAttribute()]
    public partial class AnalogSignal : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MappingIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public int Address {
            get {
                return this.AddressField;
            }
            set {
                if ((this.AddressField.Equals(value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int MappingId {
            get {
                return this.MappingIdField;
            }
            set {
                if ((this.MappingIdField.Equals(value) != true)) {
                    this.MappingIdField = value;
                    this.RaisePropertyChanged("MappingId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DiscreteSignal", Namespace="http://schemas.datacontract.org/2004/07/ModelWcfServiceLibrary.Model.Signals")]
    [System.SerializableAttribute()]
    public partial class DiscreteSignal : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MappingIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ClientWpfApp.ModelServiceReference.DiscreteSignalType SignalTypeField;
        
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
        public int Address {
            get {
                return this.AddressField;
            }
            set {
                if ((this.AddressField.Equals(value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int MappingId {
            get {
                return this.MappingIdField;
            }
            set {
                if ((this.MappingIdField.Equals(value) != true)) {
                    this.MappingIdField = value;
                    this.RaisePropertyChanged("MappingId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ClientWpfApp.ModelServiceReference.DiscreteSignalType SignalType {
            get {
                return this.SignalTypeField;
            }
            set {
                if ((this.SignalTypeField.Equals(value) != true)) {
                    this.SignalTypeField = value;
                    this.RaisePropertyChanged("SignalType");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DiscreteSignalType", Namespace="http://schemas.datacontract.org/2004/07/ModelWcfServiceLibrary.Model.SignalMappin" +
        "g")]
    public enum DiscreteSignalType : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        OneBit = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        TwoBit = 1,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ModelServiceException", Namespace="http://schemas.datacontract.org/2004/07/ModelWcfServiceLibrary")]
    [System.SerializableAttribute()]
    public partial class ModelServiceException : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ClientWpfApp.ModelServiceReference.FaultCodes FaultCodeField;
        
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
        public ClientWpfApp.ModelServiceReference.FaultCodes FaultCode {
            get {
                return this.FaultCodeField;
            }
            set {
                if ((this.FaultCodeField.Equals(value) != true)) {
                    this.FaultCodeField = value;
                    this.RaisePropertyChanged("FaultCode");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FaultCodes", Namespace="http://schemas.datacontract.org/2004/07/ModelWcfServiceLibrary")]
    public enum FaultCodes : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        IdDoesNotExist = 0,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AnalogSignalMapping", Namespace="http://schemas.datacontract.org/2004/07/ModelWcfServiceLibrary.Model.SignalMappin" +
        "g")]
    [System.SerializableAttribute()]
    public partial class AnalogSignalMapping : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double KField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double NField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double K {
            get {
                return this.KField;
            }
            set {
                if ((this.KField.Equals(value) != true)) {
                    this.KField = value;
                    this.RaisePropertyChanged("K");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double N {
            get {
                return this.NField;
            }
            set {
                if ((this.NField.Equals(value) != true)) {
                    this.NField = value;
                    this.RaisePropertyChanged("N");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DiscreteSignalMapping", Namespace="http://schemas.datacontract.org/2004/07/ModelWcfServiceLibrary.Model.SignalMappin" +
        "g")]
    [System.SerializableAttribute()]
    public partial class DiscreteSignalMapping : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.Dictionary<string, string> DiscreteValueToStateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public System.Collections.Generic.Dictionary<string, string> DiscreteValueToState {
            get {
                return this.DiscreteValueToStateField;
            }
            set {
                if ((object.ReferenceEquals(this.DiscreteValueToStateField, value) != true)) {
                    this.DiscreteValueToStateField = value;
                    this.RaisePropertyChanged("DiscreteValueToState");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ModelServiceReference.IModelService")]
    public interface IModelService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IModelService/GetAllRTUs", ReplyAction="http://tempuri.org/IModelService/GetAllRTUsResponse")]
        System.Collections.ObjectModel.ObservableCollection<ClientWpfApp.ModelServiceReference.RTU> GetAllRTUs();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IModelService/GetAllRTUs", ReplyAction="http://tempuri.org/IModelService/GetAllRTUsResponse")]
        System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<ClientWpfApp.ModelServiceReference.RTU>> GetAllRTUsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IModelService/GetRTU", ReplyAction="http://tempuri.org/IModelService/GetRTUResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ClientWpfApp.ModelServiceReference.ModelServiceException), Action="http://tempuri.org/IModelService/GetRTUModelServiceExceptionFault", Name="ModelServiceException", Namespace="http://schemas.datacontract.org/2004/07/ModelWcfServiceLibrary")]
        ClientWpfApp.ModelServiceReference.RTU GetRTU(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IModelService/GetRTU", ReplyAction="http://tempuri.org/IModelService/GetRTUResponse")]
        System.Threading.Tasks.Task<ClientWpfApp.ModelServiceReference.RTU> GetRTUAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IModelService/GetDiscreteSignalsForRtu", ReplyAction="http://tempuri.org/IModelService/GetDiscreteSignalsForRtuResponse")]
        System.Collections.ObjectModel.ObservableCollection<ClientWpfApp.ModelServiceReference.DiscreteSignal> GetDiscreteSignalsForRtu(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IModelService/GetDiscreteSignalsForRtu", ReplyAction="http://tempuri.org/IModelService/GetDiscreteSignalsForRtuResponse")]
        System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<ClientWpfApp.ModelServiceReference.DiscreteSignal>> GetDiscreteSignalsForRtuAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IModelService/GetAnalogSignalsForRtu", ReplyAction="http://tempuri.org/IModelService/GetAnalogSignalsForRtuResponse")]
        System.Collections.ObjectModel.ObservableCollection<ClientWpfApp.ModelServiceReference.AnalogSignal> GetAnalogSignalsForRtu(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IModelService/GetAnalogSignalsForRtu", ReplyAction="http://tempuri.org/IModelService/GetAnalogSignalsForRtuResponse")]
        System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<ClientWpfApp.ModelServiceReference.AnalogSignal>> GetAnalogSignalsForRtuAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IModelService/GetRTUsEssentialData", ReplyAction="http://tempuri.org/IModelService/GetRTUsEssentialDataResponse")]
        System.Collections.ObjectModel.ObservableCollection<ClientWpfApp.ModelServiceReference.RTUData> GetRTUsEssentialData();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IModelService/GetRTUsEssentialData", ReplyAction="http://tempuri.org/IModelService/GetRTUsEssentialDataResponse")]
        System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<ClientWpfApp.ModelServiceReference.RTUData>> GetRTUsEssentialDataAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IModelService/GetAnalogSignalMappings", ReplyAction="http://tempuri.org/IModelService/GetAnalogSignalMappingsResponse")]
        System.Collections.ObjectModel.ObservableCollection<ClientWpfApp.ModelServiceReference.AnalogSignalMapping> GetAnalogSignalMappings();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IModelService/GetAnalogSignalMappings", ReplyAction="http://tempuri.org/IModelService/GetAnalogSignalMappingsResponse")]
        System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<ClientWpfApp.ModelServiceReference.AnalogSignalMapping>> GetAnalogSignalMappingsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IModelService/GetDiscreteSignalMappings", ReplyAction="http://tempuri.org/IModelService/GetDiscreteSignalMappingsResponse")]
        System.Collections.ObjectModel.ObservableCollection<ClientWpfApp.ModelServiceReference.DiscreteSignalMapping> GetDiscreteSignalMappings();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IModelService/GetDiscreteSignalMappings", ReplyAction="http://tempuri.org/IModelService/GetDiscreteSignalMappingsResponse")]
        System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<ClientWpfApp.ModelServiceReference.DiscreteSignalMapping>> GetDiscreteSignalMappingsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IModelService/GetDiscreteSignalPossibleStates", ReplyAction="http://tempuri.org/IModelService/GetDiscreteSignalPossibleStatesResponse")]
        System.Collections.ObjectModel.ObservableCollection<string> GetDiscreteSignalPossibleStates(int rtuId, int signalAddress);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IModelService/GetDiscreteSignalPossibleStates", ReplyAction="http://tempuri.org/IModelService/GetDiscreteSignalPossibleStatesResponse")]
        System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<string>> GetDiscreteSignalPossibleStatesAsync(int rtuId, int signalAddress);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IModelServiceChannel : ClientWpfApp.ModelServiceReference.IModelService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ModelServiceClient : System.ServiceModel.ClientBase<ClientWpfApp.ModelServiceReference.IModelService>, ClientWpfApp.ModelServiceReference.IModelService {
        
        public ModelServiceClient() {
        }
        
        public ModelServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ModelServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ModelServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ModelServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.ObjectModel.ObservableCollection<ClientWpfApp.ModelServiceReference.RTU> GetAllRTUs() {
            return base.Channel.GetAllRTUs();
        }
        
        public System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<ClientWpfApp.ModelServiceReference.RTU>> GetAllRTUsAsync() {
            return base.Channel.GetAllRTUsAsync();
        }
        
        public ClientWpfApp.ModelServiceReference.RTU GetRTU(int id) {
            return base.Channel.GetRTU(id);
        }
        
        public System.Threading.Tasks.Task<ClientWpfApp.ModelServiceReference.RTU> GetRTUAsync(int id) {
            return base.Channel.GetRTUAsync(id);
        }
        
        public System.Collections.ObjectModel.ObservableCollection<ClientWpfApp.ModelServiceReference.DiscreteSignal> GetDiscreteSignalsForRtu(int id) {
            return base.Channel.GetDiscreteSignalsForRtu(id);
        }
        
        public System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<ClientWpfApp.ModelServiceReference.DiscreteSignal>> GetDiscreteSignalsForRtuAsync(int id) {
            return base.Channel.GetDiscreteSignalsForRtuAsync(id);
        }
        
        public System.Collections.ObjectModel.ObservableCollection<ClientWpfApp.ModelServiceReference.AnalogSignal> GetAnalogSignalsForRtu(int id) {
            return base.Channel.GetAnalogSignalsForRtu(id);
        }
        
        public System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<ClientWpfApp.ModelServiceReference.AnalogSignal>> GetAnalogSignalsForRtuAsync(int id) {
            return base.Channel.GetAnalogSignalsForRtuAsync(id);
        }
        
        public System.Collections.ObjectModel.ObservableCollection<ClientWpfApp.ModelServiceReference.RTUData> GetRTUsEssentialData() {
            return base.Channel.GetRTUsEssentialData();
        }
        
        public System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<ClientWpfApp.ModelServiceReference.RTUData>> GetRTUsEssentialDataAsync() {
            return base.Channel.GetRTUsEssentialDataAsync();
        }
        
        public System.Collections.ObjectModel.ObservableCollection<ClientWpfApp.ModelServiceReference.AnalogSignalMapping> GetAnalogSignalMappings() {
            return base.Channel.GetAnalogSignalMappings();
        }
        
        public System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<ClientWpfApp.ModelServiceReference.AnalogSignalMapping>> GetAnalogSignalMappingsAsync() {
            return base.Channel.GetAnalogSignalMappingsAsync();
        }
        
        public System.Collections.ObjectModel.ObservableCollection<ClientWpfApp.ModelServiceReference.DiscreteSignalMapping> GetDiscreteSignalMappings() {
            return base.Channel.GetDiscreteSignalMappings();
        }
        
        public System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<ClientWpfApp.ModelServiceReference.DiscreteSignalMapping>> GetDiscreteSignalMappingsAsync() {
            return base.Channel.GetDiscreteSignalMappingsAsync();
        }
        
        public System.Collections.ObjectModel.ObservableCollection<string> GetDiscreteSignalPossibleStates(int rtuId, int signalAddress) {
            return base.Channel.GetDiscreteSignalPossibleStates(rtuId, signalAddress);
        }
        
        public System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<string>> GetDiscreteSignalPossibleStatesAsync(int rtuId, int signalAddress) {
            return base.Channel.GetDiscreteSignalPossibleStatesAsync(rtuId, signalAddress);
        }
    }
}
