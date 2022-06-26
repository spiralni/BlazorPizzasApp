using System.Text.Json;

namespace PizzaPlaceWebAssembly.Client
{
    public static class DebuggingExtensions
    {
        private static JsonSerializerOptions options = new JsonSerializerOptions();

        public static string ToJson(this object obj) => JsonSerializer.Serialize(obj, options);
    }
}
