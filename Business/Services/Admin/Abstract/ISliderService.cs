using System;
using Business.ViewModels.Admin.Slider;

namespace Business.Services.Admin.Abstract
{
    public interface ISliderService
    {
        Task<List<SliderListItemVM>> GelAllASync();
        Task<bool> CreateAsync(SliderCreateVM model);
        Task<bool> DeleteAsync(int id);
        Task<SliderUpdateVM> UpdateAsync(int id);
        Task<bool> UpdateAsync(SliderUpdateVM model, int id);
    }
}

