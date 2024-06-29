using api.DTOs.Stock;
using api.Models;

namespace api.Interfaces
{
    public interface IStockRepository
    {
        Task<List<Stock>> GetAllAsync();
        Task<Stock?> GetByIdAsync(int id);
        Task<Stock> CreateAsync(CreateStockDto createStockDto);
        Task<Stock?> UpdateAsync(int id, UpdateStockDto updateStockDto);
        Task<Stock?> DeleteAsync(int id);
    }
}