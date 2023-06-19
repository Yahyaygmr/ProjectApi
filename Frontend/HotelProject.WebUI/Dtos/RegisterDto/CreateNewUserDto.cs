using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.RegisterDto
{
    public class CreateNewUserDto
    {
        [Required(ErrorMessage = "Bu Alan Zoruludur")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Bu Alan Zoruludur")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Bu Alan Zoruludur")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Bu Alan Zoruludur")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Bu Alan Zoruludur")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Bu Alan Zoruludur")]
        [Compare("Password", ErrorMessage = "Şifreler Aynı Olmalı")]
        public string ConfirmPassword { get; set; }
    }
}
