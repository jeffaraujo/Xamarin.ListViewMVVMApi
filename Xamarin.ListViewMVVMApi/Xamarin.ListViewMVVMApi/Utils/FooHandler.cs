using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Xamarin.ListViewMVVMApi.Utils
{
    public class FooHandler: HttpMessageHandler
    {
        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}