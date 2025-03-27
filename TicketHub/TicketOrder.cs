using System.ComponentModel.DataAnnotations;

namespace TicketHub
{
    public class TicketOrder
    {
        //concert id
        [Required(ErrorMessage = "ConcertId is required")]
        public int? ConcertId { get; set; }

        //email
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address - Format: user@example.com")]
        public string Email { get; set; } = string.Empty;

        //name
        [Required(ErrorMessage = "Name is required")]
        [MaxLength(30, ErrorMessage = "Invalid Name: Maximum 30 Characters")]
        public string Name { get; set; } = string.Empty;

        //phone
        [Required(ErrorMessage = "Phone is required")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Invalid Phone Number: must be 10 digits long")]
        public string Phone { get; set; } = string.Empty;

        //quantity
        [Required(ErrorMessage = "Quantity is required")]
        [Range(1, int.MaxValue, ErrorMessage = "Invalid Quantity: must be at least 1")]
        public int Quantity { get; set; }

        //credit card
        [Required(ErrorMessage = "CreditCard is required")]
        [CreditCard(ErrorMessage = "Invalid Credit Card Number - Format: 1234 5678 9876 5432")]
        public string CreditCard { get; set; } = string.Empty;

        //expiration date
        [Required(ErrorMessage = "Expiration Date is required")]
        [RegularExpression(@"^(0[1-9]|1[0-2])\/([0-9]{4}|[0-9]{2})$", ErrorMessage = "Invalid Expiration Date - Fomat: MM/YY or MM/YYYY.")]
        //Format : MM/YYYY or MM/YY
        public string ExpirationDate { get; set; } = string.Empty;

        //security code
        [Required(ErrorMessage = "SecurityCode is required")]
        [RegularExpression(@"^[0-9]{3,4}$", ErrorMessage = "Invalid Security Code - Format: 3 or 4 digits")]
        public string SecurityCode { get; set; } = string.Empty;

        //address
        [Required(ErrorMessage = "Address is required")]
        [MaxLength(50, ErrorMessage = "Invalid Address: Maximum 50 Characters")]
        public string Address { get; set; } = string.Empty;

        //city
        [Required(ErrorMessage = "City is required")]
        [MaxLength(25, ErrorMessage = "Invalid City: Maximum 25 Characters")]
        public string City { get; set; } = string.Empty;

        //province
        [Required(ErrorMessage = "Province is required")]
        [MaxLength(25, ErrorMessage = "Invalid Province: Maximum 25 Characters")]
        public string Province { get; set; } = string.Empty;

        //postal code
        [Required(ErrorMessage = "PostalCode is required")]
        [MinLength(5, ErrorMessage = "Invalid Postal Code: minimum 5 characters long.")]
        [MaxLength(10, ErrorMessage = "Invalid Postal Code: Maximum 10 Characters")]
        public string PostalCode { get; set; } = string.Empty;

        //country
        [Required(ErrorMessage = "Country is required")]
        [MaxLength(25, ErrorMessage = "Invalid Country: Maximum 25 Characters")]
        public string Country { get; set; } = string.Empty;
    }
}
