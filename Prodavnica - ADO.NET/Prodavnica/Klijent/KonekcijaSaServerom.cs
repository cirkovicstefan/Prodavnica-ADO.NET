using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace Klijent
{
    public sealed class KonekcijaSaServerom
    {
        static ChannelFactory<IProdavnica> channelFactory = 
            new ChannelFactory<IProdavnica>(new BasicHttpBinding(),
                    new EndpointAddress("http://localhost:9000"));
        static IProdavnica proxy = null;

        public static IProdavnica Proxy
        {
            get
            {
                if (proxy == null || channelFactory.State != CommunicationState.Opened)
                {
                    proxy = channelFactory.CreateChannel();
                }

                return proxy;
            }
        }
    }
}
