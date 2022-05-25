using System.Net.Http;
using System.Threading.Tasks;

namespace ModrinthSharp.Core.Base
{
    public interface IModrinthRequest
    {
        string Route { get; set; }
        HttpMethod HttpMethod { get; set; }

        Task<IModrinthResponse> SendAsync();
    }
}
