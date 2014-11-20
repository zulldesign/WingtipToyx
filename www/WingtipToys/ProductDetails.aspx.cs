using Navigation;
using System;
using System.Linq;
using System.Web.UI;
using WingtipToyx.Models;

namespace WingtipToyx
{
	public partial class ProductDetails : Page
	{
		public IQueryable<Product> GetProduct([NavigationData] string productName)
		{
			var _db = new WingtipToyx.Models.ProductContext();
			IQueryable<Product> query = _db.Products;
			if (!String.IsNullOrEmpty(productName))
			{
				query = query.Where(p =>
						  String.Compare(p.ProductName, productName) == 0);
			}
			else
			{
				query = null;
			}
			return query;
		}
	}
}