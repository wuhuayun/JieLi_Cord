﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.34014
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace SG.Client.WCFHost.ExtControl_ExtGridControl_H {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="SG.Server.Host.ExtControl", ConfigurationName="ExtControl_ExtGridControl_H.ExtGridControl_H")]
    public interface ExtGridControl_H {
        
        [System.ServiceModel.OperationContractAttribute(Action="SG.Server.Host.ExtControl/ExtGridControl_H/GetReportFiled", ReplyAction="SG.Server.Host.ExtControl/ExtGridControl_H/GetReportFiledResponse")]
        byte[] GetReportFiled(byte[] loginTicket, string sReportName);
        
        [System.ServiceModel.OperationContractAttribute(Action="SG.Server.Host.ExtControl/ExtGridControl_H/GetReportFiled", ReplyAction="SG.Server.Host.ExtControl/ExtGridControl_H/GetReportFiledResponse")]
        System.Threading.Tasks.Task<byte[]> GetReportFiledAsync(byte[] loginTicket, string sReportName);
        
        [System.ServiceModel.OperationContractAttribute(Action="SG.Server.Host.ExtControl/ExtGridControl_H/GetRportData", ReplyAction="SG.Server.Host.ExtControl/ExtGridControl_H/GetRportDataResponse")]
        byte[] GetRportData(byte[] loginTicket, string sReportName, string sFilter, bool bIsGetCount, int nPageIndex);
        
        [System.ServiceModel.OperationContractAttribute(Action="SG.Server.Host.ExtControl/ExtGridControl_H/GetRportData", ReplyAction="SG.Server.Host.ExtControl/ExtGridControl_H/GetRportDataResponse")]
        System.Threading.Tasks.Task<byte[]> GetRportDataAsync(byte[] loginTicket, string sReportName, string sFilter, bool bIsGetCount, int nPageIndex);
        
        [System.ServiceModel.OperationContractAttribute(Action="SG.Server.Host.ExtControl/ExtGridControl_H/GetDataTableBySQL", ReplyAction="SG.Server.Host.ExtControl/ExtGridControl_H/GetDataTableBySQLResponse")]
        byte[] GetDataTableBySQL(byte[] loginTicket, string sql);
        
        [System.ServiceModel.OperationContractAttribute(Action="SG.Server.Host.ExtControl/ExtGridControl_H/GetDataTableBySQL", ReplyAction="SG.Server.Host.ExtControl/ExtGridControl_H/GetDataTableBySQLResponse")]
        System.Threading.Tasks.Task<byte[]> GetDataTableBySQLAsync(byte[] loginTicket, string sql);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ExtGridControl_HChannel : SG.Client.WCFHost.ExtControl_ExtGridControl_H.ExtGridControl_H, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ExtGridControl_HClient : System.ServiceModel.ClientBase<SG.Client.WCFHost.ExtControl_ExtGridControl_H.ExtGridControl_H>, SG.Client.WCFHost.ExtControl_ExtGridControl_H.ExtGridControl_H {
        
        public ExtGridControl_HClient() {
        }
        
        public ExtGridControl_HClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ExtGridControl_HClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ExtGridControl_HClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ExtGridControl_HClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public byte[] GetReportFiled(byte[] loginTicket, string sReportName) {
            return base.Channel.GetReportFiled(loginTicket, sReportName);
        }
        
        public System.Threading.Tasks.Task<byte[]> GetReportFiledAsync(byte[] loginTicket, string sReportName) {
            return base.Channel.GetReportFiledAsync(loginTicket, sReportName);
        }
        
        public byte[] GetRportData(byte[] loginTicket, string sReportName, string sFilter, bool bIsGetCount, int nPageIndex) {
            return base.Channel.GetRportData(loginTicket, sReportName, sFilter, bIsGetCount, nPageIndex);
        }
        
        public System.Threading.Tasks.Task<byte[]> GetRportDataAsync(byte[] loginTicket, string sReportName, string sFilter, bool bIsGetCount, int nPageIndex) {
            return base.Channel.GetRportDataAsync(loginTicket, sReportName, sFilter, bIsGetCount, nPageIndex);
        }
        
        public byte[] GetDataTableBySQL(byte[] loginTicket, string sql) {
            return base.Channel.GetDataTableBySQL(loginTicket, sql);
        }
        
        public System.Threading.Tasks.Task<byte[]> GetDataTableBySQLAsync(byte[] loginTicket, string sql) {
            return base.Channel.GetDataTableBySQLAsync(loginTicket, sql);
        }
    }
}