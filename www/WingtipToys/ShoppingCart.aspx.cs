using Navigation;
using System.Collections.Generic;
using System.Web.UI;
using WingtipToyx.Logic;
using WingtipToyx.Models;

namespace WingtipToyx
{
	public partial class ShoppingCart : Page
	{
		public List<CartItem> GetShoppingCartItems()
		{
			ShoppingCartActions actions = new ShoppingCartActions();
			StateContext.Bag.total = actions.GetTotal();
			return actions.GetCartItems();
		}

	}
}