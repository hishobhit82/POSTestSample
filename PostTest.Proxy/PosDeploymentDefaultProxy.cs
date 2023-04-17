using PosTest.Proxy.WcfSvcRef;
using System;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace PosTest.Proxy
{
    public class PosDeploymentDefaultProxy
    {
        public int ClientDataValue { get; set; }
        public string GetData
        {
            get
            {
                var binding = GetEndPointBinding();
                var address = new EndpointAddress(new Uri("net.tcp://mylenovo:18793/PostTest/DeploymentDefault"), EndpointIdentity.CreateSpnIdentity(""));
                IPosTestSvcChannel client = ChannelFactory<IPosTestSvcChannel>.CreateChannel(binding,address);
                return client.GetData(ClientDataValue);
            }
        }

        private static Binding GetEndPointBinding()
        {
            Binding binding = new NetTcpBinding();
            ((NetTcpBinding)binding).MaxReceivedMessageSize = 2147483647;
            ((NetTcpBinding)binding).MaxBufferSize = 2147483647;
            ((NetTcpBinding)binding).MaxBufferPoolSize = 2147483647;

            binding.SendTimeout = new TimeSpan(0, 120, 0);
            binding.ReceiveTimeout = new TimeSpan(0, 120, 0);
            return binding;
        }
    }
}
