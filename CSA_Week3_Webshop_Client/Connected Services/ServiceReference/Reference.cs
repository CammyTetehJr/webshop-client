﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CSA_Week3_Webshop_Client.ServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Product", Namespace="http://schemas.datacontract.org/2004/07/csa_week_3_webshop")]
    [System.SerializableAttribute()]
    public partial class Product : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int StockField;
        
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
        public decimal Price {
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
        public int Stock {
            get {
                return this.StockField;
            }
            set {
                if ((this.StockField.Equals(value) != true)) {
                    this.StockField = value;
                    this.RaisePropertyChanged("Stock");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Order", Namespace="http://schemas.datacontract.org/2004/07/csa_week_3_webshop")]
    [System.SerializableAttribute()]
    public partial class Order : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime MomentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int OrderIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProductIdField;
        
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
        public System.DateTime Moment {
            get {
                return this.MomentField;
            }
            set {
                if ((this.MomentField.Equals(value) != true)) {
                    this.MomentField = value;
                    this.RaisePropertyChanged("Moment");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int OrderId {
            get {
                return this.OrderIdField;
            }
            set {
                if ((this.OrderIdField.Equals(value) != true)) {
                    this.OrderIdField = value;
                    this.RaisePropertyChanged("OrderId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductId {
            get {
                return this.ProductIdField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductIdField, value) != true)) {
                    this.ProductIdField = value;
                    this.RaisePropertyChanged("ProductId");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="service", ConfigurationName="ServiceReference.IWebShop", CallbackContract=typeof(CSA_Week3_Webshop_Client.ServiceReference.IWebShopCallback))]
    public interface IWebShop {
        
        [System.ServiceModel.OperationContractAttribute(Action="service/IWebShop/GetWebShopName", ReplyAction="service/IWebShop/GetWebShopNameResponse")]
        string GetWebShopName();
        
        [System.ServiceModel.OperationContractAttribute(Action="service/IWebShop/GetWebShopName", ReplyAction="service/IWebShop/GetWebShopNameResponse")]
        System.Threading.Tasks.Task<string> GetWebShopNameAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="service/IWebShop/GetProductList", ReplyAction="service/IWebShop/GetProductListResponse")]
        CSA_Week3_Webshop_Client.ServiceReference.Product[] GetProductList();
        
        [System.ServiceModel.OperationContractAttribute(Action="service/IWebShop/GetProductList", ReplyAction="service/IWebShop/GetProductListResponse")]
        System.Threading.Tasks.Task<CSA_Week3_Webshop_Client.ServiceReference.Product[]> GetProductListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="service/IWebShop/GetProductInfo", ReplyAction="service/IWebShop/GetProductInfoResponse")]
        string GetProductInfo(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="service/IWebShop/GetProductInfo", ReplyAction="service/IWebShop/GetProductInfoResponse")]
        System.Threading.Tasks.Task<string> GetProductInfoAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="service/IWebShop/BuyProduct")]
        void BuyProduct(string name);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="service/IWebShop/BuyProduct")]
        System.Threading.Tasks.Task BuyProductAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="service/IWebShop/Subscribe")]
        void Subscribe();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="service/IWebShop/Subscribe")]
        System.Threading.Tasks.Task SubscribeAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="service/IWebShop/UnSubscribe", ReplyAction="service/IWebShop/UnSubscribeResponse")]
        void UnSubscribe();
        
        [System.ServiceModel.OperationContractAttribute(Action="service/IWebShop/UnSubscribe", ReplyAction="service/IWebShop/UnSubscribeResponse")]
        System.Threading.Tasks.Task UnSubscribeAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWebShopCallback {
        
        [System.ServiceModel.OperationContractAttribute(Action="service/IWebShop/NewClientConnected", ReplyAction="service/IWebShop/NewClientConnectedResponse")]
        void NewClientConnected(int numberOfConnectedClients);
        
        [System.ServiceModel.OperationContractAttribute(Action="service/IWebShop/ProductSold", ReplyAction="service/IWebShop/ProductSoldResponse")]
        void ProductSold(CSA_Week3_Webshop_Client.ServiceReference.Product product);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWebShopChannel : CSA_Week3_Webshop_Client.ServiceReference.IWebShop, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebShopClient : System.ServiceModel.DuplexClientBase<CSA_Week3_Webshop_Client.ServiceReference.IWebShop>, CSA_Week3_Webshop_Client.ServiceReference.IWebShop {
        
        public WebShopClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public WebShopClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public WebShopClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public WebShopClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public WebShopClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public string GetWebShopName() {
            return base.Channel.GetWebShopName();
        }
        
        public System.Threading.Tasks.Task<string> GetWebShopNameAsync() {
            return base.Channel.GetWebShopNameAsync();
        }
        
        public CSA_Week3_Webshop_Client.ServiceReference.Product[] GetProductList() {
            return base.Channel.GetProductList();
        }
        
        public System.Threading.Tasks.Task<CSA_Week3_Webshop_Client.ServiceReference.Product[]> GetProductListAsync() {
            return base.Channel.GetProductListAsync();
        }
        
        public string GetProductInfo(string name) {
            return base.Channel.GetProductInfo(name);
        }
        
        public System.Threading.Tasks.Task<string> GetProductInfoAsync(string name) {
            return base.Channel.GetProductInfoAsync(name);
        }
        
        public void BuyProduct(string name) {
            base.Channel.BuyProduct(name);
        }
        
        public System.Threading.Tasks.Task BuyProductAsync(string name) {
            return base.Channel.BuyProductAsync(name);
        }
        
        public void Subscribe() {
            base.Channel.Subscribe();
        }
        
        public System.Threading.Tasks.Task SubscribeAsync() {
            return base.Channel.SubscribeAsync();
        }
        
        public void UnSubscribe() {
            base.Channel.UnSubscribe();
        }
        
        public System.Threading.Tasks.Task UnSubscribeAsync() {
            return base.Channel.UnSubscribeAsync();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="service", ConfigurationName="ServiceReference.IShipping", CallbackContract=typeof(CSA_Week3_Webshop_Client.ServiceReference.IShippingCallback))]
    public interface IShipping {
        
        [System.ServiceModel.OperationContractAttribute(Action="service/IShipping/GetOrderList", ReplyAction="service/IShipping/GetOrderListResponse")]
        CSA_Week3_Webshop_Client.ServiceReference.Order[] GetOrderList();
        
        [System.ServiceModel.OperationContractAttribute(Action="service/IShipping/GetOrderList", ReplyAction="service/IShipping/GetOrderListResponse")]
        System.Threading.Tasks.Task<CSA_Week3_Webshop_Client.ServiceReference.Order[]> GetOrderListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="service/IShipping/ShipOrder", ReplyAction="service/IShipping/ShipOrderResponse")]
        bool ShipOrder(int OrderId);
        
        [System.ServiceModel.OperationContractAttribute(Action="service/IShipping/ShipOrder", ReplyAction="service/IShipping/ShipOrderResponse")]
        System.Threading.Tasks.Task<bool> ShipOrderAsync(int OrderId);
        
        [System.ServiceModel.OperationContractAttribute(Action="service/IShipping/SubscribeEvent", ReplyAction="service/IShipping/SubscribeEventResponse")]
        void SubscribeEvent();
        
        [System.ServiceModel.OperationContractAttribute(Action="service/IShipping/SubscribeEvent", ReplyAction="service/IShipping/SubscribeEventResponse")]
        System.Threading.Tasks.Task SubscribeEventAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="service/IShipping/UnSubscribeEvent", ReplyAction="service/IShipping/UnSubscribeEventResponse")]
        void UnSubscribeEvent();
        
        [System.ServiceModel.OperationContractAttribute(Action="service/IShipping/UnSubscribeEvent", ReplyAction="service/IShipping/UnSubscribeEventResponse")]
        System.Threading.Tasks.Task UnSubscribeEventAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IShippingCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="service/IShipping/OnProductBought")]
        void OnProductBought(CSA_Week3_Webshop_Client.ServiceReference.Order o);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IShippingChannel : CSA_Week3_Webshop_Client.ServiceReference.IShipping, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ShippingClient : System.ServiceModel.DuplexClientBase<CSA_Week3_Webshop_Client.ServiceReference.IShipping>, CSA_Week3_Webshop_Client.ServiceReference.IShipping {
        
        public ShippingClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public ShippingClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public ShippingClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public ShippingClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public ShippingClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public CSA_Week3_Webshop_Client.ServiceReference.Order[] GetOrderList() {
            return base.Channel.GetOrderList();
        }
        
        public System.Threading.Tasks.Task<CSA_Week3_Webshop_Client.ServiceReference.Order[]> GetOrderListAsync() {
            return base.Channel.GetOrderListAsync();
        }
        
        public bool ShipOrder(int OrderId) {
            return base.Channel.ShipOrder(OrderId);
        }
        
        public System.Threading.Tasks.Task<bool> ShipOrderAsync(int OrderId) {
            return base.Channel.ShipOrderAsync(OrderId);
        }
        
        public void SubscribeEvent() {
            base.Channel.SubscribeEvent();
        }
        
        public System.Threading.Tasks.Task SubscribeEventAsync() {
            return base.Channel.SubscribeEventAsync();
        }
        
        public void UnSubscribeEvent() {
            base.Channel.UnSubscribeEvent();
        }
        
        public System.Threading.Tasks.Task UnSubscribeEventAsync() {
            return base.Channel.UnSubscribeEventAsync();
        }
    }
}