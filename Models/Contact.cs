using System.ComponentModel.DataAnnotations;
namespace ContactManager.Models
{
    public class Contact
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; }

        [Required, EmailAddress, RegularExpression(@"^[\w\.-]+@[\w\.-]+\.\w{2,4}$", ErrorMessage = "Please Enter Correct Email Address")]
        public string Email { get; set; }

        [Phone, MinLength(10, ErrorMessage = "Contact Number Must Be of 10 Digits")]
        public string Phone { get; set; }
    }
}
