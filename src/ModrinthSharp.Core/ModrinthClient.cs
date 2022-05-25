using ModrinthSharp.Core.Base;
using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ModrinthSharp.Core
{
    public abstract class ModrinthClient : IDisposable
    {
        protected HttpClient _httpClient;

        public ModrinthClient(ModrinthApiUrl apiUrl)
        {
            _httpClient = new HttpClient {
                BaseAddress = new Uri("https://" + apiUrl.Get())
            };
        }

        public abstract IModrinthRequest GetRequest(string route, HttpMethod method);
        
        public HttpRequestMessage CreateRequestHttpMessage(IModrinthRequest request)
            => new HttpRequestMessage(request.HttpMethod, new Uri(_httpClient.BaseAddress, request.Route));

        public Task<IModrinthResponse> SendAsync(IModrinthRequest request) => Task.Run<IModrinthResponse>(async () => {
            HttpResponseMessage httpResponse = await _httpClient.SendAsync(CreateRequestHttpMessage(request));

            if (!httpResponse.IsSuccessStatusCode)
                return ModrinthError.FromJson(JObject.Parse(await httpResponse.Content.ReadAsStringAsync()));

            return new ModrinthResponse(await httpResponse.Content.ReadAsStringAsync());
        });

        public void Dispose()
        {
            GC.SuppressFinalize(this);
            _httpClient.Dispose();
        }
    }
}
