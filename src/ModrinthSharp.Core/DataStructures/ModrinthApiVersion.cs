using System;

namespace ModrinthSharp.Core.DataStructures
{
    public struct ModrinthApiVersion : IEquatable<ModrinthApiVersion>
    {
        public int Major;
        public int Minor;
        public int Patch;

        public ModrinthApiVersion(int major, int minor, int patch)
        {
            Major = major;
            Minor = minor;
            Patch = patch;
        }

        public override string ToString() => $"v{Major}.{Minor}.{Patch}";
        public override int GetHashCode() => Major ^ Minor ^ Patch;

        public override bool Equals(object obj) => obj is ModrinthApiVersion version && Equals(version);
        public bool Equals(ModrinthApiVersion other) => Major == other.Major && Minor == other.Minor && Patch == other.Patch;
    }
}
