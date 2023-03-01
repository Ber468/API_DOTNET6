using MP.ApiDotNet6.Application.DTOs;

namespace MP.ApiDotNet6.Application.Services.Interfaces
{
    public interface IPurchaseService
    {
        Task<ResultService<PurchaseDTO>> CreateAsync(PurchaseDTO purchaseDTO);
        Task<ResultService<PuchateDetailDTO>> GetByIdAsync(int id);
        Task<ResultService<ICollection<PuchateDetailDTO>>> GetAsync();
        Task<ResultService<PurchaseDTO>> UpdateAsync(PurchaseDTO purchaseDTO);
        Task<ResultService> RemoveAsync(int id);
    }
}
