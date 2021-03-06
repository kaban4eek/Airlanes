﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.18033
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFTestClient.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Flight", Namespace="http://schemas.datacontract.org/2004/07/WCFSoapServiceAirport.Model")]
    [System.SerializableAttribute()]
    public partial class Flight : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AirlineField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int FlightIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FlightNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FromField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ToField;
        
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
        public string Airline {
            get {
                return this.AirlineField;
            }
            set {
                if ((object.ReferenceEquals(this.AirlineField, value) != true)) {
                    this.AirlineField = value;
                    this.RaisePropertyChanged("Airline");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int FlightId {
            get {
                return this.FlightIdField;
            }
            set {
                if ((this.FlightIdField.Equals(value) != true)) {
                    this.FlightIdField = value;
                    this.RaisePropertyChanged("FlightId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FlightNumber {
            get {
                return this.FlightNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.FlightNumberField, value) != true)) {
                    this.FlightNumberField = value;
                    this.RaisePropertyChanged("FlightNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string From {
            get {
                return this.FromField;
            }
            set {
                if ((object.ReferenceEquals(this.FromField, value) != true)) {
                    this.FromField = value;
                    this.RaisePropertyChanged("From");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string To {
            get {
                return this.ToField;
            }
            set {
                if ((object.ReferenceEquals(this.ToField, value) != true)) {
                    this.ToField = value;
                    this.RaisePropertyChanged("To");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IFlightService")]
    public interface IFlightService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFlightService/GetAllFligths", ReplyAction="http://tempuri.org/IFlightService/GetAllFligthsResponse")]
        WCFTestClient.ServiceReference1.Flight[] GetAllFligths();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFlightService/AddFlight", ReplyAction="http://tempuri.org/IFlightService/AddFlightResponse")]
        void AddFlight(string n, string a, string f, string t, int p);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFlightService/DeleteFlight", ReplyAction="http://tempuri.org/IFlightService/DeleteFlightResponse")]
        void DeleteFlight(WCFTestClient.ServiceReference1.Flight f);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFlightService/FindFlights", ReplyAction="http://tempuri.org/IFlightService/FindFlightsResponse")]
        WCFTestClient.ServiceReference1.Flight[] FindFlights(string a);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFlightService/SortByPrice", ReplyAction="http://tempuri.org/IFlightService/SortByPriceResponse")]
        WCFTestClient.ServiceReference1.Flight[] SortByPrice();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IFlightServiceChannel : WCFTestClient.ServiceReference1.IFlightService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FlightServiceClient : System.ServiceModel.ClientBase<WCFTestClient.ServiceReference1.IFlightService>, WCFTestClient.ServiceReference1.IFlightService {
        
        public FlightServiceClient() {
        }
        
        public FlightServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FlightServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FlightServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FlightServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WCFTestClient.ServiceReference1.Flight[] GetAllFligths() {
            return base.Channel.GetAllFligths();
        }
        
        public void AddFlight(string n, string a, string f, string t, int p) {
            base.Channel.AddFlight(n, a, f, t, p);
        }
        
        public void DeleteFlight(WCFTestClient.ServiceReference1.Flight f) {
            base.Channel.DeleteFlight(f);
        }
        
        public WCFTestClient.ServiceReference1.Flight[] FindFlights(string a) {
            return base.Channel.FindFlights(a);
        }
        
        public WCFTestClient.ServiceReference1.Flight[] SortByPrice() {
            return base.Channel.SortByPrice();
        }
    }
}
