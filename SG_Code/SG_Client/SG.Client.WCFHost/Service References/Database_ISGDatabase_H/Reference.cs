﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.34014
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace SG.Client.WCFHost.Database_ISGDatabase_H {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="SG.Server.Host.Database", ConfigurationName="Database_ISGDatabase_H.SGDatabase_H")]
    public interface SGDatabase_H {
        
        [System.ServiceModel.OperationContractAttribute(Action="SG.Server.Host.Database/SGDatabase_H/AddCommonType", ReplyAction="SG.Server.Host.Database/SGDatabase_H/AddCommonTypeResponse")]
        bool AddCommonType(byte[] loginTicket, string sfid, string code, string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="SG.Server.Host.Database/SGDatabase_H/AddCommonType", ReplyAction="SG.Server.Host.Database/SGDatabase_H/AddCommonTypeResponse")]
        System.Threading.Tasks.Task<bool> AddCommonTypeAsync(byte[] loginTicket, string sfid, string code, string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="SG.Server.Host.Database/SGDatabase_H/SearchCommonType", ReplyAction="SG.Server.Host.Database/SGDatabase_H/SearchCommonTypeResponse")]
        byte[] SearchCommonType(byte[] loginTicket, string dataType);
        
        [System.ServiceModel.OperationContractAttribute(Action="SG.Server.Host.Database/SGDatabase_H/SearchCommonType", ReplyAction="SG.Server.Host.Database/SGDatabase_H/SearchCommonTypeResponse")]
        System.Threading.Tasks.Task<byte[]> SearchCommonTypeAsync(byte[] loginTicket, string dataType);
        
        [System.ServiceModel.OperationContractAttribute(Action="SG.Server.Host.Database/SGDatabase_H/DeleteCommonType", ReplyAction="SG.Server.Host.Database/SGDatabase_H/DeleteCommonTypeResponse")]
        bool DeleteCommonType(byte[] loginTicket, string code);
        
        [System.ServiceModel.OperationContractAttribute(Action="SG.Server.Host.Database/SGDatabase_H/DeleteCommonType", ReplyAction="SG.Server.Host.Database/SGDatabase_H/DeleteCommonTypeResponse")]
        System.Threading.Tasks.Task<bool> DeleteCommonTypeAsync(byte[] loginTicket, string code);
        
        [System.ServiceModel.OperationContractAttribute(Action="SG.Server.Host.Database/SGDatabase_H/IsExistsCommonType", ReplyAction="SG.Server.Host.Database/SGDatabase_H/IsExistsCommonTypeResponse")]
        bool IsExistsCommonType(byte[] loginTicket, string code);
        
        [System.ServiceModel.OperationContractAttribute(Action="SG.Server.Host.Database/SGDatabase_H/IsExistsCommonType", ReplyAction="SG.Server.Host.Database/SGDatabase_H/IsExistsCommonTypeResponse")]
        System.Threading.Tasks.Task<bool> IsExistsCommonTypeAsync(byte[] loginTicket, string code);
        
        [System.ServiceModel.OperationContractAttribute(Action="SG.Server.Host.Database/SGDatabase_H/GetItemClass", ReplyAction="SG.Server.Host.Database/SGDatabase_H/GetItemClassResponse")]
        byte[] GetItemClass(byte[] loginTicket, string FNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="SG.Server.Host.Database/SGDatabase_H/GetItemClass", ReplyAction="SG.Server.Host.Database/SGDatabase_H/GetItemClassResponse")]
        System.Threading.Tasks.Task<byte[]> GetItemClassAsync(byte[] loginTicket, string FNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="SG.Server.Host.Database/SGDatabase_H/DeleteItemClass", ReplyAction="SG.Server.Host.Database/SGDatabase_H/DeleteItemClassResponse")]
        bool DeleteItemClass(byte[] loginTicket, string FNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="SG.Server.Host.Database/SGDatabase_H/DeleteItemClass", ReplyAction="SG.Server.Host.Database/SGDatabase_H/DeleteItemClassResponse")]
        System.Threading.Tasks.Task<bool> DeleteItemClassAsync(byte[] loginTicket, string FNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="SG.Server.Host.Database/SGDatabase_H/IsExistsItemClass", ReplyAction="SG.Server.Host.Database/SGDatabase_H/IsExistsItemClassResponse")]
        bool IsExistsItemClass(byte[] loginTicket, string FNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="SG.Server.Host.Database/SGDatabase_H/IsExistsItemClass", ReplyAction="SG.Server.Host.Database/SGDatabase_H/IsExistsItemClassResponse")]
        System.Threading.Tasks.Task<bool> IsExistsItemClassAsync(byte[] loginTicket, string FNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="SG.Server.Host.Database/SGDatabase_H/GetItemDesc", ReplyAction="SG.Server.Host.Database/SGDatabase_H/GetItemDescResponse")]
        byte[] GetItemDesc(byte[] loginTicket, string FNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="SG.Server.Host.Database/SGDatabase_H/GetItemDesc", ReplyAction="SG.Server.Host.Database/SGDatabase_H/GetItemDescResponse")]
        System.Threading.Tasks.Task<byte[]> GetItemDescAsync(byte[] loginTicket, string FNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="SG.Server.Host.Database/SGDatabase_H/DeleteItemDesc", ReplyAction="SG.Server.Host.Database/SGDatabase_H/DeleteItemDescResponse")]
        bool DeleteItemDesc(byte[] loginTicket, string fid);
        
        [System.ServiceModel.OperationContractAttribute(Action="SG.Server.Host.Database/SGDatabase_H/DeleteItemDesc", ReplyAction="SG.Server.Host.Database/SGDatabase_H/DeleteItemDescResponse")]
        System.Threading.Tasks.Task<bool> DeleteItemDescAsync(byte[] loginTicket, string fid);
        
        [System.ServiceModel.OperationContractAttribute(Action="SG.Server.Host.Database/SGDatabase_H/SetOrder", ReplyAction="SG.Server.Host.Database/SGDatabase_H/SetOrderResponse")]
        bool SetOrder(byte[] loginTicket, string Upfid, string Downfid);
        
        [System.ServiceModel.OperationContractAttribute(Action="SG.Server.Host.Database/SGDatabase_H/SetOrder", ReplyAction="SG.Server.Host.Database/SGDatabase_H/SetOrderResponse")]
        System.Threading.Tasks.Task<bool> SetOrderAsync(byte[] loginTicket, string Upfid, string Downfid);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface SGDatabase_HChannel : SG.Client.WCFHost.Database_ISGDatabase_H.SGDatabase_H, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SGDatabase_HClient : System.ServiceModel.ClientBase<SG.Client.WCFHost.Database_ISGDatabase_H.SGDatabase_H>, SG.Client.WCFHost.Database_ISGDatabase_H.SGDatabase_H {
        
        public SGDatabase_HClient() {
        }
        
        public SGDatabase_HClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SGDatabase_HClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SGDatabase_HClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SGDatabase_HClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool AddCommonType(byte[] loginTicket, string sfid, string code, string name) {
            return base.Channel.AddCommonType(loginTicket, sfid, code, name);
        }
        
        public System.Threading.Tasks.Task<bool> AddCommonTypeAsync(byte[] loginTicket, string sfid, string code, string name) {
            return base.Channel.AddCommonTypeAsync(loginTicket, sfid, code, name);
        }
        
        public byte[] SearchCommonType(byte[] loginTicket, string dataType) {
            return base.Channel.SearchCommonType(loginTicket, dataType);
        }
        
        public System.Threading.Tasks.Task<byte[]> SearchCommonTypeAsync(byte[] loginTicket, string dataType) {
            return base.Channel.SearchCommonTypeAsync(loginTicket, dataType);
        }
        
        public bool DeleteCommonType(byte[] loginTicket, string code) {
            return base.Channel.DeleteCommonType(loginTicket, code);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteCommonTypeAsync(byte[] loginTicket, string code) {
            return base.Channel.DeleteCommonTypeAsync(loginTicket, code);
        }
        
        public bool IsExistsCommonType(byte[] loginTicket, string code) {
            return base.Channel.IsExistsCommonType(loginTicket, code);
        }
        
        public System.Threading.Tasks.Task<bool> IsExistsCommonTypeAsync(byte[] loginTicket, string code) {
            return base.Channel.IsExistsCommonTypeAsync(loginTicket, code);
        }
        
        public byte[] GetItemClass(byte[] loginTicket, string FNumber) {
            return base.Channel.GetItemClass(loginTicket, FNumber);
        }
        
        public System.Threading.Tasks.Task<byte[]> GetItemClassAsync(byte[] loginTicket, string FNumber) {
            return base.Channel.GetItemClassAsync(loginTicket, FNumber);
        }
        
        public bool DeleteItemClass(byte[] loginTicket, string FNumber) {
            return base.Channel.DeleteItemClass(loginTicket, FNumber);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteItemClassAsync(byte[] loginTicket, string FNumber) {
            return base.Channel.DeleteItemClassAsync(loginTicket, FNumber);
        }
        
        public bool IsExistsItemClass(byte[] loginTicket, string FNumber) {
            return base.Channel.IsExistsItemClass(loginTicket, FNumber);
        }
        
        public System.Threading.Tasks.Task<bool> IsExistsItemClassAsync(byte[] loginTicket, string FNumber) {
            return base.Channel.IsExistsItemClassAsync(loginTicket, FNumber);
        }
        
        public byte[] GetItemDesc(byte[] loginTicket, string FNumber) {
            return base.Channel.GetItemDesc(loginTicket, FNumber);
        }
        
        public System.Threading.Tasks.Task<byte[]> GetItemDescAsync(byte[] loginTicket, string FNumber) {
            return base.Channel.GetItemDescAsync(loginTicket, FNumber);
        }
        
        public bool DeleteItemDesc(byte[] loginTicket, string fid) {
            return base.Channel.DeleteItemDesc(loginTicket, fid);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteItemDescAsync(byte[] loginTicket, string fid) {
            return base.Channel.DeleteItemDescAsync(loginTicket, fid);
        }
        
        public bool SetOrder(byte[] loginTicket, string Upfid, string Downfid) {
            return base.Channel.SetOrder(loginTicket, Upfid, Downfid);
        }
        
        public System.Threading.Tasks.Task<bool> SetOrderAsync(byte[] loginTicket, string Upfid, string Downfid) {
            return base.Channel.SetOrderAsync(loginTicket, Upfid, Downfid);
        }
    }
}