using BlazorECommerceWebsiteCourse.Server.Data;
using Microsoft.EntityFrameworkCore;

namespace BlazorECommerceWebsiteCourse.Server.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly DataContext _context;

        public CategoryService(DataContext _context)
        {
            this._context = _context;
        }

        public async Task<ServiceResponse<List<Category>>> GetCategories()
        {
            var categories = await _context.Categories.ToListAsync();
            return new ServiceResponse<List<Category>>
            {
                Data = categories
            };
        }
    }
}
