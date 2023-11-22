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
		public string? Price { get; set; }


	}
}
