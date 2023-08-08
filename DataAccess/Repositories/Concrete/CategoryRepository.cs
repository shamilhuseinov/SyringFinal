using System;
using Common.Entities;
using DataAccess.Contexts;
using DataAccess.Repositories.Abstract;
using DataAccess.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories.Concrete
{
	public class CategoryRepository:Repository<Category>, ICategoryRepository
	{
        private readonly AppDbContext _context;
		public CategoryRepository(AppDbContext context):base(context)
		{
            _context = context;
		}

        public async Task<Category> GetByTitleAsync(string title)
        {
            return await _context.Categories.FirstOrDefaultAsync(c => c.Title.ToLower().Trim() == title.ToLower().Trim());
        }
    }
}

