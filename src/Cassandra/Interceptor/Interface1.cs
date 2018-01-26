using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cassandra.Interceptor
{
    public interface IInterceptor
    {
        void InterceptQueueWait(string host, long ticks);
    }
}
