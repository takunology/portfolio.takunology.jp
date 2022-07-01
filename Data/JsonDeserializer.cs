using Microsoft.AspNetCore.Components;
using System.Runtime.Serialization.Json;
using System.Text;

namespace TakunologyPortfolio.Data
{
    public class JsonDeserializer : ComponentBase
    {
        public static async Task<T> Deserialize<T>(HttpClient client, string jsonPath)
            where T : class
        {
            var json = await client.GetStringAsync(jsonPath);
            var serializer = new DataContractJsonSerializer(typeof(T));
            var ms = new MemoryStream(Encoding.UTF8.GetBytes(json));
            ms.Seek(0, SeekOrigin.Begin);
            return serializer.ReadObject(ms) as T;
        }
    }
}
