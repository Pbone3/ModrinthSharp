using ModrinthSharp.Core.Enums;
using ModrinthSharp.Core.Models;
using ModrinthSharp.v2.DataStructures;
using System;

namespace ModrinthSharp.v2.Models
{
    public class ModrinthProjectV2 : ModrinthProject
    {
        public readonly string Id;
        public readonly string Slug;
        public readonly string ProjectType;
        public readonly string Team;
        public readonly string Title;
        public readonly string Description;
        public readonly string Body;
        public readonly DateTime Published;
        public readonly DateTime Updated;
        public readonly ModrinthProjectStatus Status;
        public readonly ModrinthSideRequirement ClientSide;
        public readonly ModrinthSideRequirement ServerSide;
        public readonly int Downloads;
        public readonly int Followers;
        public readonly string[] Categories;
        public readonly string[] Versions;

        public readonly string? ModeratorMessage;
        public readonly ModrinthLicenseV2? License;
        public readonly string? IconUrl;
        public readonly string? IssuesUrl;
        public readonly string? SourceUrl;
        public readonly string? WikiUrl;
        public readonly string? DiscordUrl;
        public readonly string[]? DonationUrls;
        public readonly ModrinthGalleryImageV2[]? Gallery;

        [Obsolete("Use the Body field instead.")]
        public readonly string? BodyUrl;

        public ModrinthProjectV2(string id, string slug, string projectType, string team,
            string title, string description, string body, DateTime published, DateTime updated,
            ModrinthProjectStatus status, ModrinthSideRequirement clientSide, ModrinthSideRequirement serverSide,
            int downloads, int followers, string[] categories, string[] versions,
            string? moderatorMessage, ModrinthLicenseV2? license,
            string? iconUrl, string? issuesUrl, string? sourceUrl, string? wikiUrl, string? discordUrl,
            string[]? donationUrls, ModrinthGalleryImageV2[]? gallery, string? bodyUrl = null)
        {
            Id = id;
            Slug = slug;
            ProjectType = projectType;
            Team = team;
            Title = title;
            Description = description;
            Body = body;
            Published = published;
            Updated = updated;
            Status = status;
            ClientSide = clientSide;
            ServerSide = serverSide;
            Downloads = downloads;
            Followers = followers;
            Categories = categories;
            Versions = versions;
            
            ModeratorMessage = moderatorMessage;
            License = license;
            IconUrl = iconUrl;
            IssuesUrl = issuesUrl;
            SourceUrl = sourceUrl;
            WikiUrl = wikiUrl;
            DiscordUrl = discordUrl;
            DonationUrls = donationUrls;
            Gallery = gallery;
            
#pragma warning disable CS0618 // Type or member is obsolete
            BodyUrl = bodyUrl;
#pragma warning restore CS0618 // Type or member is obsolete
        }
    }
}
