using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
namespace ServerAPI.Data
{
	public class OurUsers
	{
		[JsonPropertyName("_id")]
		public string? ID { get; set; }
		[JsonPropertyName("name")]
		public string? name { get; set; }

		[JsonPropertyName("email")]
		public string? Email { get; set; }
		[JsonPropertyName("password")]
		public string? Password { get; set; }
		[JsonPropertyName("role")]
		public string? Role { get; set; }
	}
}
