﻿using System.ComponentModel.DataAnnotations;

namespace SE310.P12_WebsiteMangXaHoiChiaSeLapTrinh.Models.DTO
{
    public class LoginRequestDto
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
