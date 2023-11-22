using System.Text.Json.Serialization;

namespace ServerAPI.Data
{
    public class Sale
    {
        //ID Property
        [JsonPropertyName("_id")]
        public string? ID { get; set; }
        // Name Property
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("price")]
        public double Price { get; set;}

        [JsonPropertyName("buyer")]
        public string Buyer { get; set; }

        [JsonPropertyName("date")]
        public string purchase_Date { get; set; }




    }
}
