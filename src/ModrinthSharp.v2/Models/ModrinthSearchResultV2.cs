using ModrinthSharp.Core.Enums;
using ModrinthSharp.Core.Models;
using ModrinthSharp.v2.DataStructures;
using System;

namespace ModrinthSharp.v2.Models
{
    public class ModrinthSearchResultV2 : ModrinthSearchResult
    {
        public readonly string ProjectType;
        public readonly int Downloads;
        public readonly string ProjectID;
        public readonly string Author;
        public readonly string[] Versions;
        public readonly int Follows;
        public readonly DateTime DateCreated;
        public readonly DateTime DateModified;
        public readonly ModrinthGalleryImageV2[] Gallery;

        public readonly string? Slug;
        public readonly string? Title;
        public readonly string? Description;
        public readonly string[]? Categories;
        public readonly ModrinthSideRequirement? ClientSide;
        public readonly ModrinthSideRequirement? ServerSide;
        public readonly string? IconUrl;
        public readonly string? LatestVersion;

        public ModrinthSearchResultV2(string projectType, int downloads, string projectID,
            string author, string[] versions, int follows,
            DateTime dateCreated, DateTime dateModified, ModrinthGalleryImageV2[] gallery,
            string? slug, string? title, string? description, string[]? categories,
            ModrinthSideRequirement? clientSide, ModrinthSideRequirement? serverSide,
            string? iconUrl, string? latestVersion)
        {
            ProjectType = projectType;
            Downloads = downloads;
            ProjectID = projectID;
            Author = author;
            Versions = versions;
            Follows = follows;
            DateCreated = dateCreated;
            DateModified = dateModified;
            Gallery = gallery;
            Slug = slug;
            Title = title;
            Description = description;
            Categories = categories;
            ClientSide = clientSide;
            ServerSide = serverSide;
            IconUrl = iconUrl;
            LatestVersion = latestVersion;
        }
    }
}
