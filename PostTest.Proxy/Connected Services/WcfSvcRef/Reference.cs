﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PosTest.Proxy.WcfSvcRef {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WcfSvcRef.IPosTestSvc")]
    public interface IPosTestSvc {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPosTestSvc/GetData", ReplyAction="http://tempuri.org/IPosTestSvc/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPosTestSvc/GetData", ReplyAction="http://tempuri.org/IPosTestSvc/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPosTestSvcChannel : PosTest.Proxy.WcfSvcRef.IPosTestSvc, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PosTestSvcClient : System.ServiceModel.ClientBase<PosTest.Proxy.WcfSvcRef.IPosTestSvc>, PosTest.Proxy.WcfSvcRef.IPosTestSvc {
        
        public PosTestSvcClient() {
        }
        
        public PosTestSvcClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PosTestSvcClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PosTestSvcClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PosTestSvcClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
    }
}