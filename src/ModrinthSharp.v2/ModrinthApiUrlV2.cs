using ModrinthSharp.Core.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModrinthSharp.v2
{
    public class ModrinthApiUrlV2 : ModrinthApiUrl
    {
        public readonly string? Branch;

        public ModrinthApiUrlV2(string? branch)
        {
            Branch = branch;
        }

        public override string Get()
        {
            if (Branch == null)
                return "api.modrinth.com/v2/";
            else
                return $"{Branch}-api.modrinth.com/v2/";
        }
    }
}
