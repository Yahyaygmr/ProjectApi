﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DtoLayer.RoomDto
{
    public class RoomAddDto
    {
        [Required(ErrorMessage = "Lütfen Oda Numarasını Giriniz")]
        public string RoomNumber { get; set; }
        public string? RoomCoverImage { get; set; }
        [Required(ErrorMessage = "Lütfen Fiyat Giriniz")]
        public double Price { get; set; }
        [Required(ErrorMessage = "Lütfen Oda Başlığı Giriniz")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Lütfen Yatak Sayısı Giriniz")]
        public string BadCount { get; set; }
        [Required(ErrorMessage = "Lütfen Banyo Sayısı Giriniz")]
        public string BathCount { get; set; }
        public string? Wifi { get; set; }
        public string? Description { get; set; }
    }
}
