﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4952
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Desktop.Servico {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Servico.IServico")]
    public interface IServico {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServico/ObterUsuarioPorCodigo", ReplyAction="http://tempuri.org/IServico/ObterUsuarioPorCodigoResponse")]
        Entidades.Usuario ObterUsuarioPorCodigo(string codigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServico/InserirUsuario", ReplyAction="http://tempuri.org/IServico/InserirUsuarioResponse")]
        void InserirUsuario(ref Entidades.Usuario usuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServico/AlterarUsuario", ReplyAction="http://tempuri.org/IServico/AlterarUsuarioResponse")]
        void AlterarUsuario(ref Entidades.Usuario usuario);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface IServicoChannel : Desktop.Servico.IServico, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class ServicoClient : System.ServiceModel.ClientBase<Desktop.Servico.IServico>, Desktop.Servico.IServico {
        
        public ServicoClient() {
        }
        
        public ServicoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Entidades.Usuario ObterUsuarioPorCodigo(string codigo) {
            return base.Channel.ObterUsuarioPorCodigo(codigo);
        }
        
        public void InserirUsuario(ref Entidades.Usuario usuario) {
            base.Channel.InserirUsuario(ref usuario);
        }
        
        public void AlterarUsuario(ref Entidades.Usuario usuario) {
            base.Channel.AlterarUsuario(ref usuario);
        }
    }
}
