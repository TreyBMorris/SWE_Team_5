using System.Text.Json.Serialization;

namespace ServerAPI.Data
{
    public class Sale
    {
        // ID Property
        [JsonPropertyName("_id")]
        public string? ID { get; set; }
        // Name Property
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        // Price Property
        [JsonPropertyName("price")]
        public double Price { get; set;}

        // Buyer Property
        [JsonPropertyName("buyer")]
        public string Buyer { get; set; }

        [JsonPropertyName("date")]
        public string purchase_Date { get; set; }




    }
}
