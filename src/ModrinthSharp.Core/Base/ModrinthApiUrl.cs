namespace ModrinthSharp.Core.Base
{
    public abstract class ModrinthApiUrl
    {
        public abstract string Get();

        public string GetRouteUrl(string route) => $"{Get()}{route}";
    }
}
