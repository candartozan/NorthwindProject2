using Northwind.Business.Abstract;
using Northwind.Business.Concrete;
using Northwind.Business.DependencyResolves.Ninject;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.WinFormsUI
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			_productService = InstanceFactory.GetInstance<IProductService>();
			_categoryService = InstanceFactory.GetInstance<ICategoryService>();
		}

		IProductService _productService;
		ICategoryService _categoryService;

		private void Form1_Load(object sender, EventArgs e)
		{
			LoadProducts();
			LoadCategories();

		}

		private void LoadCategories()
		{
			cbxCategory.DataSource = _categoryService.GetAll();
			cbxCategory.DisplayMember = "CategoryName";
			cbxCategory.ValueMember = "CategoryId";

			cbxCategoryId.DataSource = _categoryService.GetAll();
			cbxCategoryId.DisplayMember = "CategoryName";
			cbxCategoryId.ValueMember = "CategoryId";
		}

		private void LoadProducts()
		{
			dgwProduct.DataSource = _productService.GetAll();
		}

		private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				dgwProduct.DataSource = _productService.GetProductsByCategory(Convert.ToInt32(cbxCategory.SelectedValue));
			}
			catch
			{

			}

		}

		private void tbxProductName_TextChanged(object sender, EventArgs e)
		{
			if (String.IsNullOrEmpty(tbxProductName.Text))
			{
				LoadProducts();
			}
			else
				dgwProduct.DataSource = _productService.GetProductsByProductName(tbxProductName.Text);
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			_productService.Add(new Product
			{
				CategoryId = Convert.ToInt32(cbxCategoryId.SelectedValue),
				ProductName = tbxProductName2.Text,
				QuantityPerUnit = tbxQuantityPerUnit.Text,
				UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),
				UnitsInStock = Convert.ToInt16(tbxStock.Text)
			});
			LoadProducts();
			MessageBox.Show("Product Added!");
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			_productService.Update(new Product
			{
				ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
				CategoryId = Convert.ToInt32(cbxCategoryId.SelectedValue),
				ProductName = tbxProductName2.Text,
				QuantityPerUnit = tbxQuantityPerUnit.Text,
				UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),
				UnitsInStock = Convert.ToInt16(tbxStock.Text)
			});
			LoadProducts();
			MessageBox.Show("Product Updated!");
		}

		private void dgwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			tbxProductName2.Text = dgwProduct.CurrentRow.Cells[1].Value.ToString();
			cbxCategoryId.SelectedValue = dgwProduct.CurrentRow.Cells[2].Value;
			tbxUnitPrice.Text = dgwProduct.CurrentRow.Cells[3].Value.ToString();
			tbxStock.Text = dgwProduct.CurrentRow.Cells[5].Value.ToString();
			tbxQuantityPerUnit.Text = dgwProduct.CurrentRow.Cells[4].Value.ToString();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (dgwProduct.CurrentRow != null)
			{
				try
				{
					_productService.Delete(new Product
					{
						ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value)
					});
					LoadProducts();
					MessageBox.Show("Product Deleted!");
				}
				catch (Exception exception)
				{
					MessageBox.Show(exception.Message);
				}
			}
		}
	}
}
