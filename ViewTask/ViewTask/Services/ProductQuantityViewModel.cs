using ViewTask.Models;

namespace ViewTask.Services
{
    public class ProductService : IProductService
    {
        public static Dictionary<string, int> GetProducts(List<Product> _products)
        {
            Dictionary<string,int> keyValuePairs = new Dictionary<string,int>();
            for (int i = 0; i < _products.Count; i++)
            {
                keyValuePairs.Add(_products[i].Name, new Random().Next()*20);
            }
            return keyValuePairs;
        }
    }
}
