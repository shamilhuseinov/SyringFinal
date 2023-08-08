using System;
using Common.Entities;
using DataAccess.Repositories.Base;

namespace DataAccess.Repositories.Abstract
{
    public interface ISliderRepository : IRepository<Slider>
    {
        public Slider GetSlider();
    }
}

