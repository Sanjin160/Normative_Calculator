using NormativeCalculator.DTOs.Models;
using NormativeCalculator.DTOs.Request;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NormativeCalculator.Service.Interface
{
    public interface ICategoryService
    {
        Task<PaginationModel<List<GetCategoryDto>>> GetCategoryAsync(int skip);
        Task<GetCategoryDto> GetCategoryByIdAsync(int id);
        Task<GetCategoryDto> AddCategoryAsync(AddCategoryRequest request);
        Task<GetCategoryDto> UpdateCategoryAsync(int id, AddCategoryRequest request);
        Task<GetCategoryDto> DeleteCategoryAsync(int id);
    }
}
