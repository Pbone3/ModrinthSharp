using System.Net.Http;
using System.Threading.Tasks;

namespace ModrinthSharp.Core.Base
{
    public class ModrinthRequest : IModrinthRequest
    {
        protected ModrinthClient _client;

        protected string _modrinthRequestRoute;
        public string Route { get => _modrinthRequestRoute; set => _modrinthRequestRoute = value; }

        protected HttpMethod _httpMethod;
        public HttpMethod HttpMethod { get => _httpMethod; set => _httpMethod = value; }

        public ModrinthRequest(ModrinthClient client, string route, HttpMethod httpMethod)
        {
            _client = client;
            _modrinthRequestRoute = route;
            _httpMethod = httpMethod;
        }

        public Task<IModrinthResponse> SendAsync() => _client.SendAsync(this);
    }
}
