using System;
namespace Business.ViewModels.Admin.Slider
{
    public class SliderListItemVM
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Photo { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
    }
}

