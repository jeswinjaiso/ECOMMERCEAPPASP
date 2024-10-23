﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ECOMMERCEAPPASP2.BalanceCheck {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
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
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BalanceCheck.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/PaymentDone", ReplyAction="http://tempuri.org/IService/PaymentDoneResponse")]
        string PaymentDone(string ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/PaymentDone", ReplyAction="http://tempuri.org/IService/PaymentDoneResponse")]
        System.Threading.Tasks.Task<string> PaymentDoneAsync(string ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/InsertPayment", ReplyAction="http://tempuri.org/IService/InsertPaymentResponse")]
        string InsertPayment(string FrAcc, string ToAcc, string Amt, string PySts);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/InsertPayment", ReplyAction="http://tempuri.org/IService/InsertPaymentResponse")]
        System.Threading.Tasks.Task<string> InsertPaymentAsync(string FrAcc, string ToAcc, string Amt, string PySts);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService/GetDataUsingDataContractResponse")]
        ECOMMERCEAPPASP2.BalanceCheck.CompositeType GetDataUsingDataContract(ECOMMERCEAPPASP2.BalanceCheck.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<ECOMMERCEAPPASP2.BalanceCheck.CompositeType> GetDataUsingDataContractAsync(ECOMMERCEAPPASP2.BalanceCheck.CompositeType composite);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : ECOMMERCEAPPASP2.BalanceCheck.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<ECOMMERCEAPPASP2.BalanceCheck.IService>, ECOMMERCEAPPASP2.BalanceCheck.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string PaymentDone(string ID) {
            return base.Channel.PaymentDone(ID);
        }
        
        public System.Threading.Tasks.Task<string> PaymentDoneAsync(string ID) {
            return base.Channel.PaymentDoneAsync(ID);
        }
        
        public string InsertPayment(string FrAcc, string ToAcc, string Amt, string PySts) {
            return base.Channel.InsertPayment(FrAcc, ToAcc, Amt, PySts);
        }
        
        public System.Threading.Tasks.Task<string> InsertPaymentAsync(string FrAcc, string ToAcc, string Amt, string PySts) {
            return base.Channel.InsertPaymentAsync(FrAcc, ToAcc, Amt, PySts);
        }
        
        public ECOMMERCEAPPASP2.BalanceCheck.CompositeType GetDataUsingDataContract(ECOMMERCEAPPASP2.BalanceCheck.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<ECOMMERCEAPPASP2.BalanceCheck.CompositeType> GetDataUsingDataContractAsync(ECOMMERCEAPPASP2.BalanceCheck.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
    }
}