﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LINQMusicBathClient.ProductServiceRef {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Product", Namespace="http://schemas.datacontract.org/2004/07/LINQMusicBathService")]
    [System.SerializableAttribute()]
    public partial class Product : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool DiscontinuedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ProductIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProductNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string QuantityPerUnitField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] RowVersionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal UnitPriceField;
        
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
        public bool Discontinued {
            get {
                return this.DiscontinuedField;
            }
            set {
                if ((this.DiscontinuedField.Equals(value) != true)) {
                    this.DiscontinuedField = value;
                    this.RaisePropertyChanged("Discontinued");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ProductID {
            get {
                return this.ProductIDField;
            }
            set {
                if ((this.ProductIDField.Equals(value) != true)) {
                    this.ProductIDField = value;
                    this.RaisePropertyChanged("ProductID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductName {
            get {
                return this.ProductNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductNameField, value) != true)) {
                    this.ProductNameField = value;
                    this.RaisePropertyChanged("ProductName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string QuantityPerUnit {
            get {
                return this.QuantityPerUnitField;
            }
            set {
                if ((object.ReferenceEquals(this.QuantityPerUnitField, value) != true)) {
                    this.QuantityPerUnitField = value;
                    this.RaisePropertyChanged("QuantityPerUnit");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] RowVersion {
            get {
                return this.RowVersionField;
            }
            set {
                if ((object.ReferenceEquals(this.RowVersionField, value) != true)) {
                    this.RowVersionField = value;
                    this.RaisePropertyChanged("RowVersion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal UnitPrice {
            get {
                return this.UnitPriceField;
            }
            set {
                if ((this.UnitPriceField.Equals(value) != true)) {
                    this.UnitPriceField = value;
                    this.RaisePropertyChanged("UnitPrice");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ProductFault", Namespace="http://schemas.datacontract.org/2004/07/LINQMusicBathService")]
    [System.SerializableAttribute()]
    public partial class ProductFault : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FaultMessageField;
        
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
        public string FaultMessage {
            get {
                return this.FaultMessageField;
            }
            set {
                if ((object.ReferenceEquals(this.FaultMessageField, value) != true)) {
                    this.FaultMessageField = value;
                    this.RaisePropertyChanged("FaultMessage");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProductServiceRef.ProductService")]
    public interface ProductService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ProductService/GetProduct", ReplyAction="http://tempuri.org/ProductService/GetProductResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(LINQMusicBathClient.ProductServiceRef.ProductFault), Action="http://tempuri.org/ProductService/GetProductProductFaultFault", Name="ProductFault", Namespace="http://schemas.datacontract.org/2004/07/LINQMusicBathService")]
        LINQMusicBathClient.ProductServiceRef.Product GetProduct(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ProductService/GetProduct", ReplyAction="http://tempuri.org/ProductService/GetProductResponse")]
        System.Threading.Tasks.Task<LINQMusicBathClient.ProductServiceRef.Product> GetProductAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ProductService/UpdateProduct", ReplyAction="http://tempuri.org/ProductService/UpdateProductResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(LINQMusicBathClient.ProductServiceRef.ProductFault), Action="http://tempuri.org/ProductService/UpdateProductProductFaultFault", Name="ProductFault", Namespace="http://schemas.datacontract.org/2004/07/LINQMusicBathService")]
        LINQMusicBathClient.ProductServiceRef.UpdateProductResponse UpdateProduct(LINQMusicBathClient.ProductServiceRef.UpdateProductRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ProductService/UpdateProduct", ReplyAction="http://tempuri.org/ProductService/UpdateProductResponse")]
        System.Threading.Tasks.Task<LINQMusicBathClient.ProductServiceRef.UpdateProductResponse> UpdateProductAsync(LINQMusicBathClient.ProductServiceRef.UpdateProductRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="UpdateProduct", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class UpdateProductRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public LINQMusicBathClient.ProductServiceRef.Product product;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string message;
        
        public UpdateProductRequest() {
        }
        
        public UpdateProductRequest(LINQMusicBathClient.ProductServiceRef.Product product, string message) {
            this.product = product;
            this.message = message;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="UpdateProductResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class UpdateProductResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public bool UpdateProductResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public LINQMusicBathClient.ProductServiceRef.Product product;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public string message;
        
        public UpdateProductResponse() {
        }
        
        public UpdateProductResponse(bool UpdateProductResult, LINQMusicBathClient.ProductServiceRef.Product product, string message) {
            this.UpdateProductResult = UpdateProductResult;
            this.product = product;
            this.message = message;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ProductServiceChannel : LINQMusicBathClient.ProductServiceRef.ProductService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProductServiceClient : System.ServiceModel.ClientBase<LINQMusicBathClient.ProductServiceRef.ProductService>, LINQMusicBathClient.ProductServiceRef.ProductService {
        
        public ProductServiceClient() {
        }
        
        public ProductServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProductServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public LINQMusicBathClient.ProductServiceRef.Product GetProduct(int id) {
            return base.Channel.GetProduct(id);
        }
        
        public System.Threading.Tasks.Task<LINQMusicBathClient.ProductServiceRef.Product> GetProductAsync(int id) {
            return base.Channel.GetProductAsync(id);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        LINQMusicBathClient.ProductServiceRef.UpdateProductResponse LINQMusicBathClient.ProductServiceRef.ProductService.UpdateProduct(LINQMusicBathClient.ProductServiceRef.UpdateProductRequest request) {
            return base.Channel.UpdateProduct(request);
        }
        
        public bool UpdateProduct(ref LINQMusicBathClient.ProductServiceRef.Product product, ref string message) {
            LINQMusicBathClient.ProductServiceRef.UpdateProductRequest inValue = new LINQMusicBathClient.ProductServiceRef.UpdateProductRequest();
            inValue.product = product;
            inValue.message = message;
            LINQMusicBathClient.ProductServiceRef.UpdateProductResponse retVal = ((LINQMusicBathClient.ProductServiceRef.ProductService)(this)).UpdateProduct(inValue);
            product = retVal.product;
            message = retVal.message;
            return retVal.UpdateProductResult;
        }
        
        public System.Threading.Tasks.Task<LINQMusicBathClient.ProductServiceRef.UpdateProductResponse> UpdateProductAsync(LINQMusicBathClient.ProductServiceRef.UpdateProductRequest request) {
            return base.Channel.UpdateProductAsync(request);
        }
    }
}
