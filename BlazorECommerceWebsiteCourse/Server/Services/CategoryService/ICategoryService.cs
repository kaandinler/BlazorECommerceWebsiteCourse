﻿namespace BlazorECommerceWebsiteCourse.Server.Services.CategoryService
{
    public interface ICategoryService
    {
        Task <ServiceResponse<List<Category>>> GetCategories();
    }
}
