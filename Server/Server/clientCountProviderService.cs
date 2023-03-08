using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using GrpcClientCount;
using System.Threading.Tasks;

namespace Server
{
    public class clientCountProviderService:ClientCountProvider.ClientCountProviderBase
    {
        public override async Task GetClientCount(Empty request, IServerStreamWriter<ClientCount> responseStream, ServerCallContext context)
        {
            var count = 0;
            while(!context.CancellationToken.IsCancellationRequested)
            {
                await responseStream.WriteAsync(new ClientCount { Count = count });
                count++;
            }
        }
    }
}
