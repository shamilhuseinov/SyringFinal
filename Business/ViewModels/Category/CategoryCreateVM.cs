using System;
using System.ComponentModel.DataAnnotations;

namespace Business.ViewModels.Category
{
	public class CategoryCreateVM
	{
		[Required]
		public string Title { get; set; }
	}
}

