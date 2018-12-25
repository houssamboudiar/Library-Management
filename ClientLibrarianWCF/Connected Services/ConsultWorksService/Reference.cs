﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientLibrarianWCF.ConsultWorksService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ConsultWorksService.IConsultWorks")]
    public interface IConsultWorks {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IConsultWorks/getAllWorks", ReplyAction="http://tempuri.org/IConsultWorks/getAllWorksResponse")]
        System.Collections.Generic.List<IRemoteWCF.Models.Work> getAllWorks();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IConsultWorks/getAllWorks", ReplyAction="http://tempuri.org/IConsultWorks/getAllWorksResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<IRemoteWCF.Models.Work>> getAllWorksAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IConsultWorks/getById", ReplyAction="http://tempuri.org/IConsultWorks/getByIdResponse")]
        IRemoteWCF.Models.Work getById(int idWork);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IConsultWorks/getById", ReplyAction="http://tempuri.org/IConsultWorks/getByIdResponse")]
        System.Threading.Tasks.Task<IRemoteWCF.Models.Work> getByIdAsync(int idWork);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IConsultWorks/getByTitle", ReplyAction="http://tempuri.org/IConsultWorks/getByTitleResponse")]
        System.Collections.Generic.List<IRemoteWCF.Models.Work> getByTitle(string titre);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IConsultWorks/getByTitle", ReplyAction="http://tempuri.org/IConsultWorks/getByTitleResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<IRemoteWCF.Models.Work>> getByTitleAsync(string titre);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IConsultWorks/getByWriter", ReplyAction="http://tempuri.org/IConsultWorks/getByWriterResponse")]
        System.Collections.Generic.List<IRemoteWCF.Models.Work> getByWriter(string writer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IConsultWorks/getByWriter", ReplyAction="http://tempuri.org/IConsultWorks/getByWriterResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<IRemoteWCF.Models.Work>> getByWriterAsync(string writer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IConsultWorks/getByTags", ReplyAction="http://tempuri.org/IConsultWorks/getByTagsResponse")]
        System.Collections.Generic.List<IRemoteWCF.Models.Work> getByTags(string mot_cle);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IConsultWorks/getByTags", ReplyAction="http://tempuri.org/IConsultWorks/getByTagsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<IRemoteWCF.Models.Work>> getByTagsAsync(string mot_cle);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IConsultWorks/getByTheme", ReplyAction="http://tempuri.org/IConsultWorks/getByThemeResponse")]
        System.Collections.Generic.List<IRemoteWCF.Models.Work> getByTheme(string theme);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IConsultWorks/getByTheme", ReplyAction="http://tempuri.org/IConsultWorks/getByThemeResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<IRemoteWCF.Models.Work>> getByThemeAsync(string theme);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IConsultWorksChannel : ClientLibrarianWCF.ConsultWorksService.IConsultWorks, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ConsultWorksClient : System.ServiceModel.ClientBase<ClientLibrarianWCF.ConsultWorksService.IConsultWorks>, ClientLibrarianWCF.ConsultWorksService.IConsultWorks {
        
        public ConsultWorksClient() {
        }
        
        public ConsultWorksClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ConsultWorksClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ConsultWorksClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ConsultWorksClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<IRemoteWCF.Models.Work> getAllWorks() {
            return base.Channel.getAllWorks();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<IRemoteWCF.Models.Work>> getAllWorksAsync() {
            return base.Channel.getAllWorksAsync();
        }
        
        public IRemoteWCF.Models.Work getById(int idWork) {
            return base.Channel.getById(idWork);
        }
        
        public System.Threading.Tasks.Task<IRemoteWCF.Models.Work> getByIdAsync(int idWork) {
            return base.Channel.getByIdAsync(idWork);
        }
        
        public System.Collections.Generic.List<IRemoteWCF.Models.Work> getByTitle(string titre) {
            return base.Channel.getByTitle(titre);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<IRemoteWCF.Models.Work>> getByTitleAsync(string titre) {
            return base.Channel.getByTitleAsync(titre);
        }
        
        public System.Collections.Generic.List<IRemoteWCF.Models.Work> getByWriter(string writer) {
            return base.Channel.getByWriter(writer);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<IRemoteWCF.Models.Work>> getByWriterAsync(string writer) {
            return base.Channel.getByWriterAsync(writer);
        }
        
        public System.Collections.Generic.List<IRemoteWCF.Models.Work> getByTags(string mot_cle) {
            return base.Channel.getByTags(mot_cle);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<IRemoteWCF.Models.Work>> getByTagsAsync(string mot_cle) {
            return base.Channel.getByTagsAsync(mot_cle);
        }
        
        public System.Collections.Generic.List<IRemoteWCF.Models.Work> getByTheme(string theme) {
            return base.Channel.getByTheme(theme);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<IRemoteWCF.Models.Work>> getByThemeAsync(string theme) {
            return base.Channel.getByThemeAsync(theme);
        }
    }
}
