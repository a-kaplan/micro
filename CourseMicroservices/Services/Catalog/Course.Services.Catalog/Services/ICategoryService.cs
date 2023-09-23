using Course.Services.Catalog.Dtos;
using Course.Services.Catalog.Model;
using Course.Shared.Dtos;

namespace Course.Services.Catalog.Services
{
    interface ICategoryService
    {
        Task<Response<CategoryDto>> GetByIdAsync(string id);
        Task<Response<CategoryDto>> CreateCategory(Category category);
        Task<Response<List<CategoryDto>>> GetAllAsync();
    }
}
