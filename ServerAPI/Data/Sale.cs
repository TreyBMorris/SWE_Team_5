using System.Collections;
using System.Text.Json.Serialization;

namespace ServerAPI.Data
{
    public class Sale
    {
        // ID Property
        [JsonPropertyName("_id")]
        public string? ID { get; set; }
		//Buyer Property
        [JsonPropertyName("Buyer")]
        public string? Buyer { get; set; }
		
        [JsonPropertyName("Items")]
        public string? Items { get; set; }

		[JsonPropertyName("Email")]
        public string? Email { get; set; }
		[JsonPropertyName("Address")]
        public string? Address { get; set; }
		[JsonPropertyName("PhoneNumber")]
        public string? PhoneNumber { get; set; }
        [JsonPropertyName("ShippingSpeed")]
        public string? ShippingSpeed { get; set; }
		[JsonPropertyName("CreatedDate")]
        public string? OrderDate { get; set; }
		[JsonPropertyName("isConfirmed")]
        public Boolean? isConfirmed { get; set; }
		[JsonPropertyName("Price")]
		public double? Price { get; set; }


	}
}
