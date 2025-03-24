using System.ComponentModel.DataAnnotations;

namespace TicketHub
{
    public class TicketOrder
    {
        public int ConcertId { get; set; }
        public string Email { get; set; } = string.Empty;

        [MaxLength(30)]
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public int? Quantity { get; set; }   
        public string CreditCard { get; set; } = string.Empty;
        public string ExpirationDate { get; set; } = string.Empty;
        public string SecurityCode { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Province { get; set; } = string.Empty;
        public string PostalCode { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
    }
}
