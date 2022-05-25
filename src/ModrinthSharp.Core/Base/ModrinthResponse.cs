using ModrinthSharp.Core.Base;
using Newtonsoft.Json;
using System;

namespace ModrinthSharp.Core
{
    public class ModrinthResponse : IModrinthResponse
    {
        public readonly string Json;

        internal ModrinthResponse(string json)
        {
            Json = json;
        }

        public T GetAs<T>()
        {
            object? result = JsonConvert.DeserializeObject<T>(Json);
            
            if (result == null)
                throw new InvalidOperationException("Could not deserialize response to type " + typeof(T).Name);

            return (T)result;
        }

        public bool TryGetAs<T>(out T result)
        {
            try
            {
                result = GetAs<T>();
                return true;
            }
            catch
            {
#pragma warning disable CS8601 // Possible null reference assignment.
                result = default;
#pragma warning restore CS8601 // Possible null reference assignment.
                return false;
            }
        }
    }
}
