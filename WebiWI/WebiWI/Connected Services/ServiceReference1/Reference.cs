﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebiWI.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetCiudades", ReplyAction="http://tempuri.org/IService1/GetCiudadesResponse")]
        string[] GetCiudades();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetCiudades", ReplyAction="http://tempuri.org/IService1/GetCiudadesResponse")]
        System.Threading.Tasks.Task<string[]> GetCiudadesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GuardarDatosEnArchivo", ReplyAction="http://tempuri.org/IService1/GuardarDatosEnArchivoResponse")]
        void GuardarDatosEnArchivo(string nombre, string apellidos, string correo, string genero, int ciudad, string requerimientos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GuardarDatosEnArchivo", ReplyAction="http://tempuri.org/IService1/GuardarDatosEnArchivoResponse")]
        System.Threading.Tasks.Task GuardarDatosEnArchivoAsync(string nombre, string apellidos, string correo, string genero, int ciudad, string requerimientos);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WebiWI.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WebiWI.ServiceReference1.IService1>, WebiWI.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string[] GetCiudades() {
            return base.Channel.GetCiudades();
        }
        
        public System.Threading.Tasks.Task<string[]> GetCiudadesAsync() {
            return base.Channel.GetCiudadesAsync();
        }
        
        public void GuardarDatosEnArchivo(string nombre, string apellidos, string correo, string genero, int ciudad, string requerimientos) {
            base.Channel.GuardarDatosEnArchivo(nombre, apellidos, correo, genero, ciudad, requerimientos);
        }
        
        public System.Threading.Tasks.Task GuardarDatosEnArchivoAsync(string nombre, string apellidos, string correo, string genero, int ciudad, string requerimientos) {
            return base.Channel.GuardarDatosEnArchivoAsync(nombre, apellidos, correo, genero, ciudad, requerimientos);
        }
    }
}
