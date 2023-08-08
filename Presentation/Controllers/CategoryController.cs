using System;
using Business.Services.Abstract;
using Business.ViewModels.Category;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
	public class CategoryController:Controller
	{
		private readonly ICategoryService _categoryService;
		public CategoryController(ICategoryService categoryService)
		{
			_categoryService = categoryService;

        }
		public IActionResult Index()
		{
			return View();
		}

		[HttpGet]
        public IActionResult Create()
        {
            return View();
        }

		[HttpPost]
        public async Task<IActionResult> Create(CategoryCreateVM model)
		{
			var isSucceeded = await _categoryService.CreateAsync(model);
			if (isSucceeded) return RedirectToAction(nameof(Index));

			return View(model);
		}
	}
}

