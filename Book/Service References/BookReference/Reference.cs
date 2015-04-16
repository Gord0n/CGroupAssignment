﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookPages.BookReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Book", Namespace="http://schemas.datacontract.org/2004/07/BookService")]
    [System.SerializableAttribute()]
    public partial class Book : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BookNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ISBNField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime ReleaseDateField;
        
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
        public string BookName {
            get {
                return this.BookNameField;
            }
            set {
                if ((object.ReferenceEquals(this.BookNameField, value) != true)) {
                    this.BookNameField = value;
                    this.RaisePropertyChanged("BookName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ISBN {
            get {
                return this.ISBNField;
            }
            set {
                if ((this.ISBNField.Equals(value) != true)) {
                    this.ISBNField = value;
                    this.RaisePropertyChanged("ISBN");
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
        public System.DateTime ReleaseDate {
            get {
                return this.ReleaseDateField;
            }
            set {
                if ((this.ReleaseDateField.Equals(value) != true)) {
                    this.ReleaseDateField = value;
                    this.RaisePropertyChanged("ReleaseDate");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BookReference.BooksInterface")]
    public interface BooksInterface {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BooksInterface/AddBook", ReplyAction="http://tempuri.org/BooksInterface/AddBookResponse")]
        int AddBook(BookPages.BookReference.Book book);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BooksInterface/AddBook", ReplyAction="http://tempuri.org/BooksInterface/AddBookResponse")]
        System.Threading.Tasks.Task<int> AddBookAsync(BookPages.BookReference.Book book);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BooksInterface/GetBook", ReplyAction="http://tempuri.org/BooksInterface/GetBookResponse")]
        int GetBook(int bookId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BooksInterface/GetBook", ReplyAction="http://tempuri.org/BooksInterface/GetBookResponse")]
        System.Threading.Tasks.Task<int> GetBookAsync(int bookId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface BooksInterfaceChannel : BookPages.BookReference.BooksInterface, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BooksInterfaceClient : System.ServiceModel.ClientBase<BookPages.BookReference.BooksInterface>, BookPages.BookReference.BooksInterface {
        
        public BooksInterfaceClient() {
        }
        
        public BooksInterfaceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BooksInterfaceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BooksInterfaceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BooksInterfaceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int AddBook(BookPages.BookReference.Book book) {
            return base.Channel.AddBook(book);
        }
        
        public System.Threading.Tasks.Task<int> AddBookAsync(BookPages.BookReference.Book book) {
            return base.Channel.AddBookAsync(book);
        }
        
        public int GetBook(int bookId) {
            return base.Channel.GetBook(bookId);
        }
        
        public System.Threading.Tasks.Task<int> GetBookAsync(int bookId) {
            return base.Channel.GetBookAsync(bookId);
        }
    }
}