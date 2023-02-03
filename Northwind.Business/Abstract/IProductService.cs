using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.Abstract
{
	public interface IProductService
	{
		void Add(Product product);
		void Delete(Product product);
		List<Product> GetAll();
		List<Product> GetProductsByCategory(int categoryId);
		object GetProductsByProductName(string productName);
		void Update(Product product);
	}
}
