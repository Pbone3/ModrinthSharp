namespace ModrinthSharp.v2.DataStructures
{
    public class ModrinthLicenseV2
    {
        public readonly string Id;
        public readonly string Name;
        public readonly string Url;

        public ModrinthLicenseV2(string id, string name, string url)
        {
            Id = id;
            Name = name;
            Url = url;
        }
    }
}
