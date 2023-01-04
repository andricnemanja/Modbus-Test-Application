﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientWpfApp.ModbusServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ModbusServiceReference.IModbusDuplex", CallbackContract=typeof(ClientWpfApp.ModbusServiceReference.IModbusDuplexCallback), SessionMode=System.ServiceModel.SessionMode.Required)]
    public interface IModbusDuplex {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IModbusDuplex/ReadAnalogSignal")]
        void ReadAnalogSignal(int rtuId, int signalAddress);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IModbusDuplex/ReadAnalogSignal")]
        System.Threading.Tasks.Task ReadAnalogSignalAsync(int rtuId, int signalAddress);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IModbusDuplex/ReadDiscreteSignal")]
        void ReadDiscreteSignal(int rtuId, int signalAddress);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IModbusDuplex/ReadDiscreteSignal")]
        System.Threading.Tasks.Task ReadDiscreteSignalAsync(int rtuId, int signalAddress);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IModbusDuplex/WriteAnalogSignal")]
        void WriteAnalogSignal(int rtuId, int signalAddress, double newValue);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IModbusDuplex/WriteAnalogSignal")]
        System.Threading.Tasks.Task WriteAnalogSignalAsync(int rtuId, int signalAddress, double newValue);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IModbusDuplex/WriteDiscreteSignal")]
        void WriteDiscreteSignal(int rtuId, int signalAddress, bool newValue);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IModbusDuplex/WriteDiscreteSignal")]
        System.Threading.Tasks.Task WriteDiscreteSignalAsync(int rtuId, int signalAddress, bool newValue);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IModbusDuplex/TryConnectToRtu", ReplyAction="http://tempuri.org/IModbusDuplex/TryConnectToRtuResponse")]
        bool TryConnectToRtu(int rtuId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IModbusDuplex/TryConnectToRtu", ReplyAction="http://tempuri.org/IModbusDuplex/TryConnectToRtuResponse")]
        System.Threading.Tasks.Task<bool> TryConnectToRtuAsync(int rtuId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IModbusDuplexCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IModbusDuplex/UpdateAnalogSignalValue")]
        void UpdateAnalogSignalValue(int rtuId, int signalAddress, double signalValue);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IModbusDuplex/UpdateDiscreteSignalValue")]
        void UpdateDiscreteSignalValue(int rtuId, int signalAddress, bool signalValue);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IModbusDuplex/ChangeConnectionStatusToFalse")]
        void ChangeConnectionStatusToFalse(int rtuId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IModbusDuplexChannel : ClientWpfApp.ModbusServiceReference.IModbusDuplex, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ModbusDuplexClient : System.ServiceModel.DuplexClientBase<ClientWpfApp.ModbusServiceReference.IModbusDuplex>, ClientWpfApp.ModbusServiceReference.IModbusDuplex {
        
        public ModbusDuplexClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public ModbusDuplexClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public ModbusDuplexClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public ModbusDuplexClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public ModbusDuplexClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void ReadAnalogSignal(int rtuId, int signalAddress) {
            base.Channel.ReadAnalogSignal(rtuId, signalAddress);
        }
        
        public System.Threading.Tasks.Task ReadAnalogSignalAsync(int rtuId, int signalAddress) {
            return base.Channel.ReadAnalogSignalAsync(rtuId, signalAddress);
        }
        
        public void ReadDiscreteSignal(int rtuId, int signalAddress) {
            base.Channel.ReadDiscreteSignal(rtuId, signalAddress);
        }
        
        public System.Threading.Tasks.Task ReadDiscreteSignalAsync(int rtuId, int signalAddress) {
            return base.Channel.ReadDiscreteSignalAsync(rtuId, signalAddress);
        }
        
        public void WriteAnalogSignal(int rtuId, int signalAddress, double newValue) {
            base.Channel.WriteAnalogSignal(rtuId, signalAddress, newValue);
        }
        
        public System.Threading.Tasks.Task WriteAnalogSignalAsync(int rtuId, int signalAddress, double newValue) {
            return base.Channel.WriteAnalogSignalAsync(rtuId, signalAddress, newValue);
        }
        
        public void WriteDiscreteSignal(int rtuId, int signalAddress, bool newValue) {
            base.Channel.WriteDiscreteSignal(rtuId, signalAddress, newValue);
        }
        
        public System.Threading.Tasks.Task WriteDiscreteSignalAsync(int rtuId, int signalAddress, bool newValue) {
            return base.Channel.WriteDiscreteSignalAsync(rtuId, signalAddress, newValue);
        }
        
        public bool TryConnectToRtu(int rtuId) {
            return base.Channel.TryConnectToRtu(rtuId);
        }
        
        public System.Threading.Tasks.Task<bool> TryConnectToRtuAsync(int rtuId) {
            return base.Channel.TryConnectToRtuAsync(rtuId);
        }
    }
}
