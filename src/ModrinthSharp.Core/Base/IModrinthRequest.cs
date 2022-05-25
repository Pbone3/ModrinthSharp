using ModrinthSharp.Core.Enums;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
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
