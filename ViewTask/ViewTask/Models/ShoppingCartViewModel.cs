namespace ViewTask.Models
{
	public class ShoppingCartViewModel
	{
		public IEnumerable<SuperMarket>? SupermarketsList { get; set; }
		public IEnumerable<string>? ShoppingList { get; set; }
		public string? Supermarket;
	}
}
