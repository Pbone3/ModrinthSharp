using System;

namespace ModrinthSharp.v2.DataStructures
{
    public class ModrinthGalleryImageV2
    {
        public readonly string Url;
        public readonly bool Featured;
        public readonly DateTime Created;

        public readonly string? Title;
        public readonly string? Description;

        public ModrinthGalleryImageV2(string url, bool featured, DateTime created, string? title, string? description)
        {
            Url = url;
            Featured = featured;
            Created = created;
            Title = title;
            Description = description;
        }
    }
}
