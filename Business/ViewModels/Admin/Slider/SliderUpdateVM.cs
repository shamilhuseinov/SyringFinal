using System;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Business.ViewModels.Admin.Slider
{
    public class SliderUpdateVM
    {
        [Required]
        public string Title { get; set; }

        [Required]
        public string Subtitle { get; set; }

        public IFormFile? NewPhoto { get; set; }

        public string? Photo { get; set; }

        public DateTime ModifiedAt { get; set; }
    }
}

