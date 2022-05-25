using ModrinthSharp.Core;
using ModrinthSharp.Core.Base;
using System.Net.Http;

namespace ModrinthSharp.v2
{
    public class ModrinthClientV2 : ModrinthClient
    {
        public ModrinthClientV2(string? apiBranch = null) : base(new ModrinthApiUrlV2(apiBranch))
        {
        }

        public override IModrinthRequest GetRequest(string route, HttpMethod method) => new ModrinthRequest(this, route, method);
    }
}
