﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleClientSOAPDistanceCalculator.ServiceReferenceDistanceCalculator {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Point", Namespace="http://schemas.datacontract.org/2004/07/")]
    [System.SerializableAttribute()]
    public partial class Point : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int XField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int YField;
        
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
        public int X {
            get {
                return this.XField;
            }
            set {
                if ((this.XField.Equals(value) != true)) {
                    this.XField = value;
                    this.RaisePropertyChanged("X");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Y {
            get {
                return this.YField;
            }
            set {
                if ((this.YField.Equals(value) != true)) {
                    this.YField = value;
                    this.RaisePropertyChanged("Y");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceDistanceCalculator.IDistanceService")]
    public interface IDistanceService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDistanceService/CalculateDistance", ReplyAction="http://tempuri.org/IDistanceService/CalculateDistanceResponse")]
        double CalculateDistance(ConsoleClientSOAPDistanceCalculator.ServiceReferenceDistanceCalculator.Point first, ConsoleClientSOAPDistanceCalculator.ServiceReferenceDistanceCalculator.Point second);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDistanceService/CalculateDistance", ReplyAction="http://tempuri.org/IDistanceService/CalculateDistanceResponse")]
        System.Threading.Tasks.Task<double> CalculateDistanceAsync(ConsoleClientSOAPDistanceCalculator.ServiceReferenceDistanceCalculator.Point first, ConsoleClientSOAPDistanceCalculator.ServiceReferenceDistanceCalculator.Point second);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDistanceServiceChannel : ConsoleClientSOAPDistanceCalculator.ServiceReferenceDistanceCalculator.IDistanceService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DistanceServiceClient : System.ServiceModel.ClientBase<ConsoleClientSOAPDistanceCalculator.ServiceReferenceDistanceCalculator.IDistanceService>, ConsoleClientSOAPDistanceCalculator.ServiceReferenceDistanceCalculator.IDistanceService {
        
        public DistanceServiceClient() {
        }
        
        public DistanceServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DistanceServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DistanceServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DistanceServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double CalculateDistance(ConsoleClientSOAPDistanceCalculator.ServiceReferenceDistanceCalculator.Point first, ConsoleClientSOAPDistanceCalculator.ServiceReferenceDistanceCalculator.Point second) {
            return base.Channel.CalculateDistance(first, second);
        }
        
        public System.Threading.Tasks.Task<double> CalculateDistanceAsync(ConsoleClientSOAPDistanceCalculator.ServiceReferenceDistanceCalculator.Point first, ConsoleClientSOAPDistanceCalculator.ServiceReferenceDistanceCalculator.Point second) {
            return base.Channel.CalculateDistanceAsync(first, second);
        }
    }
}