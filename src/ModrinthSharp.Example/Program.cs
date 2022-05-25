using ModrinthSharp.Core;
using ModrinthSharp.Core.Base;
using ModrinthSharp.Core.DataStructures;
using ModrinthSharp.Core.Models;
using ModrinthSharp.v2;
using ModrinthSharp.v2.Models;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ModrinthSharp.Example
{
    public static class Program
    {
        public static async Task Main(string[] args)
        {
            using ModrinthClient modrinth = new ModrinthClientV2();

            Console.Write("Project slug to fetch information for: ");

            string slug = Console.ReadLine();
            Console.WriteLine();

            IModrinthResponse response = await modrinth.GetRequest($"project/{slug}", HttpMethod.Get).SendAsync();

            if (response is ModrinthError err)
                Console.WriteLine($"Error: {err.Error}\n{err.Description}");
            else if (response is ModrinthResponse mres)
            {
                ModrinthProjectV2 proj = mres.GetAs<ModrinthProjectV2>();

                Console.WriteLine($"== Recieved project {proj.Title} ({proj.Id}) ==");
                Console.WriteLine();    
                Console.WriteLine(proj.Body);
            }    
        }
    }
}
