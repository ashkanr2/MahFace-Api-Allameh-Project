using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ApiEndPoint.ViewModel
{
    public class UserVm
    {

        public string Email { get; set; }
        public string Password { get; set; }

        public bool RememberMe { get; set; }


    }
}
