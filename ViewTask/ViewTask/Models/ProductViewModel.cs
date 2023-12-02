using System.Collections.Generic;

namespace ViewTask.Models
{
    public class ProductViewModel
    {
        public Dictionary<string, int> ProductsModel { get; set; }
        public  ProductViewModel(Dictionary<string, int> keyValuePairs) {
            ProductsModel = keyValuePairs;
        }  
    }
}
