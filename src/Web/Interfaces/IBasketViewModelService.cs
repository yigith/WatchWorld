using Web.Models;

namespace Web.Interfaces
{
    public interface IBasketViewModelService
    {
        Task<BasketViewModel> GetBasketViewModelAsync();

        Task<BasketViewModel> AddItemToBasketAsync(int productId, int quantity);

        Task EmptyBasketAsync();

        Task RemoveItemAsync(int procuctId);

        Task<BasketViewModel> SetQuantitiesAsync(Dictionary<int, int> quantities);

        Task TransferBasketAsync();
    }
}
