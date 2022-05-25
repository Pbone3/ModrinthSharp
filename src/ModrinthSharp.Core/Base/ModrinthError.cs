using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModrinthSharp.Core.Base
{
    public class ModrinthError : IModrinthResponse
    {
        public readonly string? Error;
        public readonly string? Description;

        public ModrinthError(string? error, string? description)
        {
            Error = error;
            Description = description;
        }

        public static ModrinthError FromJson(JObject json)
            => new ModrinthError(json["error"]?.Value<string>(), json["description"]?.Value<string>());
    }
}
