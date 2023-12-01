using ViewTask.Models;

namespace ViewTask.Services
{
    public interface IProductService
    {
        static Dictionary<string, int> GetProducts(List<Product> _products) {
            throw new Exception("Dictionary is empty");  
        }
    }
}
