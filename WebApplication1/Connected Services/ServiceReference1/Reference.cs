//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IHelloService")]
    public interface IHelloService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHelloService/getMessage", ReplyAction="http://tempuri.org/IHelloService/getMessageResponse")]
        string getMessage();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHelloService/getMessage", ReplyAction="http://tempuri.org/IHelloService/getMessageResponse")]
        System.Threading.Tasks.Task<string> getMessageAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IHelloServiceChannel : WebApplication1.ServiceReference1.IHelloService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class HelloServiceClient : System.ServiceModel.ClientBase<WebApplication1.ServiceReference1.IHelloService>, WebApplication1.ServiceReference1.IHelloService {
        
        public HelloServiceClient() {
        }
        
        public HelloServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public HelloServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HelloServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HelloServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string getMessage() {
            return base.Channel.getMessage();
        }
        
        public System.Threading.Tasks.Task<string> getMessageAsync() {
            return base.Channel.getMessageAsync();
        }
    }
}
