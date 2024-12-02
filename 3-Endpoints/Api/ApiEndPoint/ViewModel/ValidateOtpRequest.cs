using System.ComponentModel.DataAnnotations;

namespace ApiEndPoint.ViewModel
{
    public class ValidateOtpRequest
    {
        [Required]
        public string OtpCode { get; set; }
    }

}
