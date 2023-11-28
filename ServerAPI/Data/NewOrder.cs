using System.Collections;

namespace ServerAPI.Data
{
    public class NewOrder
    {
        public string? Buyer { get; set; }
        public string? Items{ get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }
        public string? ShippingSpeed { get; set; }
        public string? CreatedDate { get; set;  }
        public Boolean? isConfirmed { get; set; }
        public double? Price { get; set; }
        
    }
}
