using Navigation;
using System;
using System.Linq;
using System.Web.UI;
using WingtipToyx.Logic;
using WingtipToyx.Models;

namespace WingtipToyx
{
	public partial class Site : MasterPage
	{
		protected void Page_PreRender(object sender, EventArgs e)
		{
			ShoppingCartActions usersShoppingCart = new ShoppingCartActions();
			StateContext.Bag.count = usersShoppingCart.GetCount();
		}

		public IQueryable<Category> GetCategories()
		{
			var db = new WingtipToyx.Models.ProductContext();
			IQueryable<Category> query = db.Categories;
			return query;
		}
	}
}