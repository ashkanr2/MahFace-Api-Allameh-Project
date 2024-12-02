using System.ComponentModel.DataAnnotations;

namespace ApiEndPoint.ViewModel
{
    public class LoginRequest
    {
        [Required]
        public string UserNameOrEmailORPhoneNumber { get; set; }

        [Required]
        public string Password { get; set; }
    }

}
