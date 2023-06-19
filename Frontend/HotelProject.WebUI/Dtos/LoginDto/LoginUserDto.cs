using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.LoginDto
{
    public class LoginUserDto
    {
        [Required(ErrorMessage = "Bu alan zorunludur !")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur !")]
        public string Password { get; set; }
    }
}
