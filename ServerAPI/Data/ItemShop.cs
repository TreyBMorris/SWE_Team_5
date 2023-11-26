using System.Text.Json.Serialization;

namespace ServerAPI.Data
{
	public class ItemShop
	{
		[JsonPropertyName("name")]
		public string? Name { get; set; }
		[JsonPropertyName("_id")]
		public string? ID { get; set; }
		[JsonPropertyName("price")]
		public double? Price { get; set; }
        [JsonPropertyName("description")]
		public string? Description { get; set; }
        [JsonPropertyName("image")]
        public string? Image { get; set; }
    }
}
