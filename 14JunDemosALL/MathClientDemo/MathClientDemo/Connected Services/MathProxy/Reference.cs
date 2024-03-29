﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MathClientDemo.MathProxy {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MathProxy.IMath")]
    public interface IMath {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMath/Addition", ReplyAction="http://tempuri.org/IMath/AdditionResponse")]
        int Addition(int Num1, int Num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMath/Addition", ReplyAction="http://tempuri.org/IMath/AdditionResponse")]
        System.Threading.Tasks.Task<int> AdditionAsync(int Num1, int Num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMath/Multiply", ReplyAction="http://tempuri.org/IMath/MultiplyResponse")]
        int Multiply(int Num1, int Num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMath/Multiply", ReplyAction="http://tempuri.org/IMath/MultiplyResponse")]
        System.Threading.Tasks.Task<int> MultiplyAsync(int Num1, int Num2);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMathChannel : MathClientDemo.MathProxy.IMath, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MathClient : System.ServiceModel.ClientBase<MathClientDemo.MathProxy.IMath>, MathClientDemo.MathProxy.IMath {
        
        public MathClient() {
        }
        
        public MathClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MathClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MathClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MathClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Addition(int Num1, int Num2) {
            return base.Channel.Addition(Num1, Num2);
        }
        
        public System.Threading.Tasks.Task<int> AdditionAsync(int Num1, int Num2) {
            return base.Channel.AdditionAsync(Num1, Num2);
        }
        
        public int Multiply(int Num1, int Num2) {
            return base.Channel.Multiply(Num1, Num2);
        }
        
        public System.Threading.Tasks.Task<int> MultiplyAsync(int Num1, int Num2) {
            return base.Channel.MultiplyAsync(Num1, Num2);
        }
    }
}
