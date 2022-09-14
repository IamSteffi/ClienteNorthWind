﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClienteNorthWind.NorthWindReferences1 {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="NorthWindReferences1.WSNorthwindSoap")]
    public interface WSNorthwindSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ListarCategorias", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet ListarCategorias();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ListarCategorias", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> ListarCategoriasAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgregarCategoria", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void AgregarCategoria();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgregarCategoria", ReplyAction="*")]
        System.Threading.Tasks.Task AgregarCategoriaAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ActualizarCategoria", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void ActualizarCategoria();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ActualizarCategoria", ReplyAction="*")]
        System.Threading.Tasks.Task ActualizarCategoriaAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/EliminarCategoria", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void EliminarCategoria();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/EliminarCategoria", ReplyAction="*")]
        System.Threading.Tasks.Task EliminarCategoriaAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ListarSuppliers", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet ListarSuppliers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ListarSuppliers", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> ListarSuppliersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgregarSuppliers", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string AgregarSuppliers(string CompanyName, string ContactName, string ContactTitle, string Address, string City, string Region, string PostalCode, string Country, string Phone, string Fax, string HomePage);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgregarSuppliers", ReplyAction="*")]
        System.Threading.Tasks.Task<string> AgregarSuppliersAsync(string CompanyName, string ContactName, string ContactTitle, string Address, string City, string Region, string PostalCode, string Country, string Phone, string Fax, string HomePage);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ActualizarSuppliers", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string ActualizarSuppliers(string SupplierID, string CompanyName, string ContactName, string ContactTitle, string Address, string City, string Region, string Country, string PostalCode, string Phone, string Fax, string HomePage);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ActualizarSuppliers", ReplyAction="*")]
        System.Threading.Tasks.Task<string> ActualizarSuppliersAsync(string SupplierID, string CompanyName, string ContactName, string ContactTitle, string Address, string City, string Region, string Country, string PostalCode, string Phone, string Fax, string HomePage);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/EliminarSuppliers", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string EliminarSuppliers(string SupplierID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/EliminarSuppliers", ReplyAction="*")]
        System.Threading.Tasks.Task<string> EliminarSuppliersAsync(string SupplierID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ListarProducts", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet ListarProducts();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ListarProducts", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> ListarProductsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgregarProducts", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string AgregarProducts(string ProductName, string SupplierID, string CategoryID, string QuantityPerUnit, string UnitPrice, string UnitsInStock, string UnitsOnOrder, string ReorderLevel, string Discontinued);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgregarProducts", ReplyAction="*")]
        System.Threading.Tasks.Task<string> AgregarProductsAsync(string ProductName, string SupplierID, string CategoryID, string QuantityPerUnit, string UnitPrice, string UnitsInStock, string UnitsOnOrder, string ReorderLevel, string Discontinued);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ActualizarProducts", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string ActualizarProducts(string ProductID, string ProductName, string SupplierID, string CategoryID, string QuantityPerUnit, string UnitPrice, string UnitsInStock, string UnitsOnOrder, string ReorderLevel, string Discontinued);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ActualizarProducts", ReplyAction="*")]
        System.Threading.Tasks.Task<string> ActualizarProductsAsync(string ProductID, string ProductName, string SupplierID, string CategoryID, string QuantityPerUnit, string UnitPrice, string UnitsInStock, string UnitsOnOrder, string ReorderLevel, string Discontinued);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/EliminarProducts", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string EliminarProducts(string ProductID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/EliminarProducts", ReplyAction="*")]
        System.Threading.Tasks.Task<string> EliminarProductsAsync(string ProductID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ListarShippers", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet ListarShippers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ListarShippers", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> ListarShippersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgregarShippers", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string AgregarShippers(string CompanyName, string Phone);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgregarShippers", ReplyAction="*")]
        System.Threading.Tasks.Task<string> AgregarShippersAsync(string CompanyName, string Phone);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ActualizarShippers", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string ActualizarShippers(string ShipperID, string CompanyName, string Phone);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ActualizarShippers", ReplyAction="*")]
        System.Threading.Tasks.Task<string> ActualizarShippersAsync(string ShipperID, string CompanyName, string Phone);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/EliminarShippers", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string EliminarShippers(string ShipperID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/EliminarShippers", ReplyAction="*")]
        System.Threading.Tasks.Task<string> EliminarShippersAsync(string ShipperID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WSNorthwindSoapChannel : ClienteNorthWind.NorthWindReferences1.WSNorthwindSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WSNorthwindSoapClient : System.ServiceModel.ClientBase<ClienteNorthWind.NorthWindReferences1.WSNorthwindSoap>, ClienteNorthWind.NorthWindReferences1.WSNorthwindSoap {
        
        public WSNorthwindSoapClient() {
        }
        
        public WSNorthwindSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WSNorthwindSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSNorthwindSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSNorthwindSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet ListarCategorias() {
            return base.Channel.ListarCategorias();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> ListarCategoriasAsync() {
            return base.Channel.ListarCategoriasAsync();
        }
        
        public void AgregarCategoria() {
            base.Channel.AgregarCategoria();
        }
        
        public System.Threading.Tasks.Task AgregarCategoriaAsync() {
            return base.Channel.AgregarCategoriaAsync();
        }
        
        public void ActualizarCategoria() {
            base.Channel.ActualizarCategoria();
        }
        
        public System.Threading.Tasks.Task ActualizarCategoriaAsync() {
            return base.Channel.ActualizarCategoriaAsync();
        }
        
        public void EliminarCategoria() {
            base.Channel.EliminarCategoria();
        }
        
        public System.Threading.Tasks.Task EliminarCategoriaAsync() {
            return base.Channel.EliminarCategoriaAsync();
        }
        
        public System.Data.DataSet ListarSuppliers() {
            return base.Channel.ListarSuppliers();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> ListarSuppliersAsync() {
            return base.Channel.ListarSuppliersAsync();
        }
        
        public string AgregarSuppliers(string CompanyName, string ContactName, string ContactTitle, string Address, string City, string Region, string PostalCode, string Country, string Phone, string Fax, string HomePage) {
            return base.Channel.AgregarSuppliers(CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax, HomePage);
        }
        
        public System.Threading.Tasks.Task<string> AgregarSuppliersAsync(string CompanyName, string ContactName, string ContactTitle, string Address, string City, string Region, string PostalCode, string Country, string Phone, string Fax, string HomePage) {
            return base.Channel.AgregarSuppliersAsync(CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax, HomePage);
        }
        
        public string ActualizarSuppliers(string SupplierID, string CompanyName, string ContactName, string ContactTitle, string Address, string City, string Region, string Country, string PostalCode, string Phone, string Fax, string HomePage) {
            return base.Channel.ActualizarSuppliers(SupplierID, CompanyName, ContactName, ContactTitle, Address, City, Region, Country, PostalCode, Phone, Fax, HomePage);
        }
        
        public System.Threading.Tasks.Task<string> ActualizarSuppliersAsync(string SupplierID, string CompanyName, string ContactName, string ContactTitle, string Address, string City, string Region, string Country, string PostalCode, string Phone, string Fax, string HomePage) {
            return base.Channel.ActualizarSuppliersAsync(SupplierID, CompanyName, ContactName, ContactTitle, Address, City, Region, Country, PostalCode, Phone, Fax, HomePage);
        }
        
        public string EliminarSuppliers(string SupplierID) {
            return base.Channel.EliminarSuppliers(SupplierID);
        }
        
        public System.Threading.Tasks.Task<string> EliminarSuppliersAsync(string SupplierID) {
            return base.Channel.EliminarSuppliersAsync(SupplierID);
        }
        
        public System.Data.DataSet ListarProducts() {
            return base.Channel.ListarProducts();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> ListarProductsAsync() {
            return base.Channel.ListarProductsAsync();
        }
        
        public string AgregarProducts(string ProductName, string SupplierID, string CategoryID, string QuantityPerUnit, string UnitPrice, string UnitsInStock, string UnitsOnOrder, string ReorderLevel, string Discontinued) {
            return base.Channel.AgregarProducts(ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued);
        }
        
        public System.Threading.Tasks.Task<string> AgregarProductsAsync(string ProductName, string SupplierID, string CategoryID, string QuantityPerUnit, string UnitPrice, string UnitsInStock, string UnitsOnOrder, string ReorderLevel, string Discontinued) {
            return base.Channel.AgregarProductsAsync(ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued);
        }
        
        public string ActualizarProducts(string ProductID, string ProductName, string SupplierID, string CategoryID, string QuantityPerUnit, string UnitPrice, string UnitsInStock, string UnitsOnOrder, string ReorderLevel, string Discontinued) {
            return base.Channel.ActualizarProducts(ProductID, ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued);
        }
        
        public System.Threading.Tasks.Task<string> ActualizarProductsAsync(string ProductID, string ProductName, string SupplierID, string CategoryID, string QuantityPerUnit, string UnitPrice, string UnitsInStock, string UnitsOnOrder, string ReorderLevel, string Discontinued) {
            return base.Channel.ActualizarProductsAsync(ProductID, ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued);
        }
        
        public string EliminarProducts(string ProductID) {
            return base.Channel.EliminarProducts(ProductID);
        }
        
        public System.Threading.Tasks.Task<string> EliminarProductsAsync(string ProductID) {
            return base.Channel.EliminarProductsAsync(ProductID);
        }
        
        public System.Data.DataSet ListarShippers() {
            return base.Channel.ListarShippers();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> ListarShippersAsync() {
            return base.Channel.ListarShippersAsync();
        }
        
        public string AgregarShippers(string CompanyName, string Phone) {
            return base.Channel.AgregarShippers(CompanyName, Phone);
        }
        
        public System.Threading.Tasks.Task<string> AgregarShippersAsync(string CompanyName, string Phone) {
            return base.Channel.AgregarShippersAsync(CompanyName, Phone);
        }
        
        public string ActualizarShippers(string ShipperID, string CompanyName, string Phone) {
            return base.Channel.ActualizarShippers(ShipperID, CompanyName, Phone);
        }
        
        public System.Threading.Tasks.Task<string> ActualizarShippersAsync(string ShipperID, string CompanyName, string Phone) {
            return base.Channel.ActualizarShippersAsync(ShipperID, CompanyName, Phone);
        }
        
        public string EliminarShippers(string ShipperID) {
            return base.Channel.EliminarShippers(ShipperID);
        }
        
        public System.Threading.Tasks.Task<string> EliminarShippersAsync(string ShipperID) {
            return base.Channel.EliminarShippersAsync(ShipperID);
        }
    }
}