using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.ServiceDto
{
    public class CreateServiceDto
    {
        [Required(ErrorMessage = "Hizmet İkon Linki Giriniz")]
        public string ServiceIcon { get; set; }

        [Required(ErrorMessage = "Hizmet Başlığı Giriniz")]
        [StringLength(50, ErrorMessage ="Hizmet Başlığı 50 karakterden fazla olamaz.")]
        public string ServiceTitle { get; set; }

        [Required(ErrorMessage = "Hizmet Açıklaması Giriniz")]
        public string ServiceDescription { get; set; }
    }
}
