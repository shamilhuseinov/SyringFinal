using System;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Business.ViewModels.Admin.Slider
{
    public class SliderCreateVM
    {

        [Required]
        public string Title { get; set; }

        [Required]
        public string Subtitle { get; set; }

        [Required]
        public IFormFile Photo { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}

