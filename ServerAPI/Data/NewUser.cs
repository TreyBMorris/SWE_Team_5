using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace ServerAPI.Data
{
    public class NewUser
    {
        public string Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Role { get; set; }
    }
}

   
