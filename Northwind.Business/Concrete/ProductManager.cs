using Northwind.Business.Abstract;
using Northwind.Business.ValidationRules.FluentValidation;
using Northwind.DataAccess.Abstract;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Northwind.Business.Utilities;

namespace Northwind.Business.Concrete
{
	public class ProductManager : IProductService
	{
		IProductDal _productDal;

		public ProductManager(IProductDal productDal)
		{
			_productDal = productDal;
		}

		public void Add(Product product)
		{
			ValidationTool.Validate(new ProductValidator(), product);
			_productDal.Add(product);
		}

		public void Delete(Product product)
		{
			try
			{
				_productDal.Delete(product);
			}
			catch (DbUpdateException e)
			{
				throw new Exception("Error (Delete) !");
			}
		}

		public List<Product> GetAll()
		{
			return _productDal.GetAll();
		}

		public List<Product> GetProductsByCategory(int categoryId)
		{
			return _productDal.GetAll(p => p.CategoryId == categoryId).ToList();
		}

		public object GetProductsByProductName(string productName)
		{
			return _productDal.GetAll(p => p.ProductName.ToLower().Contains(productName.ToLower())).ToList();
		}

		public void Update(Product product)
		{
			ValidationTool.Validate(new ProductValidator(), product);
			_productDal.Update(product);
		}
	}
}
