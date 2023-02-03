namespace Northwind.WinFormsUI
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.dgwProduct = new System.Windows.Forms.DataGridView();
			this.gbxCategory = new System.Windows.Forms.GroupBox();
			this.gbxProductName = new System.Windows.Forms.GroupBox();
			this.lblCategory = new System.Windows.Forms.Label();
			this.lblProductName = new System.Windows.Forms.Label();
			this.cbxCategory = new System.Windows.Forms.ComboBox();
			this.tbxProductName = new System.Windows.Forms.TextBox();
			this.gbxProductAdd = new System.Windows.Forms.GroupBox();
			this.lblProductName2 = new System.Windows.Forms.Label();
			this.lblCategoryID = new System.Windows.Forms.Label();
			this.lblUnitPrice = new System.Windows.Forms.Label();
			this.lblStock = new System.Windows.Forms.Label();
			this.lblQuantityPerUnit = new System.Windows.Forms.Label();
			this.tbxProductName2 = new System.Windows.Forms.TextBox();
			this.cbxCategoryId = new System.Windows.Forms.ComboBox();
			this.tbxUnitPrice = new System.Windows.Forms.TextBox();
			this.tbxStock = new System.Windows.Forms.TextBox();
			this.tbxQuantityPerUnit = new System.Windows.Forms.TextBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
			this.gbxCategory.SuspendLayout();
			this.gbxProductName.SuspendLayout();
			this.gbxProductAdd.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgwProduct
			// 
			this.dgwProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgwProduct.Location = new System.Drawing.Point(12, 166);
			this.dgwProduct.Name = "dgwProduct";
			this.dgwProduct.Size = new System.Drawing.Size(776, 272);
			this.dgwProduct.StandardTab = true;
			this.dgwProduct.TabIndex = 0;
			this.dgwProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProduct_CellClick);
			// 
			// gbxCategory
			// 
			this.gbxCategory.Controls.Add(this.cbxCategory);
			this.gbxCategory.Controls.Add(this.lblCategory);
			this.gbxCategory.Location = new System.Drawing.Point(12, 12);
			this.gbxCategory.Name = "gbxCategory";
			this.gbxCategory.Size = new System.Drawing.Size(348, 71);
			this.gbxCategory.TabIndex = 1;
			this.gbxCategory.TabStop = false;
			this.gbxCategory.Text = "Search By Category";
			// 
			// gbxProductName
			// 
			this.gbxProductName.Controls.Add(this.tbxProductName);
			this.gbxProductName.Controls.Add(this.lblProductName);
			this.gbxProductName.Location = new System.Drawing.Point(12, 89);
			this.gbxProductName.Name = "gbxProductName";
			this.gbxProductName.Size = new System.Drawing.Size(348, 71);
			this.gbxProductName.TabIndex = 2;
			this.gbxProductName.TabStop = false;
			this.gbxProductName.Text = "Search By Name";
			// 
			// lblCategory
			// 
			this.lblCategory.AutoSize = true;
			this.lblCategory.Location = new System.Drawing.Point(20, 33);
			this.lblCategory.Name = "lblCategory";
			this.lblCategory.Size = new System.Drawing.Size(49, 13);
			this.lblCategory.TabIndex = 0;
			this.lblCategory.Text = "Category";
			// 
			// lblProductName
			// 
			this.lblProductName.AutoSize = true;
			this.lblProductName.Location = new System.Drawing.Point(20, 32);
			this.lblProductName.Name = "lblProductName";
			this.lblProductName.Size = new System.Drawing.Size(75, 13);
			this.lblProductName.TabIndex = 0;
			this.lblProductName.Text = "Product Name";
			// 
			// cbxCategory
			// 
			this.cbxCategory.FormattingEnabled = true;
			this.cbxCategory.Location = new System.Drawing.Point(111, 25);
			this.cbxCategory.Name = "cbxCategory";
			this.cbxCategory.Size = new System.Drawing.Size(219, 21);
			this.cbxCategory.TabIndex = 1;
			this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
			// 
			// tbxProductName
			// 
			this.tbxProductName.Location = new System.Drawing.Point(111, 29);
			this.tbxProductName.Name = "tbxProductName";
			this.tbxProductName.Size = new System.Drawing.Size(219, 20);
			this.tbxProductName.TabIndex = 1;
			this.tbxProductName.TextChanged += new System.EventHandler(this.tbxProductName_TextChanged);
			// 
			// gbxProductAdd
			// 
			this.gbxProductAdd.Controls.Add(this.btnDelete);
			this.gbxProductAdd.Controls.Add(this.btnUpdate);
			this.gbxProductAdd.Controls.Add(this.btnAdd);
			this.gbxProductAdd.Controls.Add(this.tbxQuantityPerUnit);
			this.gbxProductAdd.Controls.Add(this.tbxStock);
			this.gbxProductAdd.Controls.Add(this.tbxUnitPrice);
			this.gbxProductAdd.Controls.Add(this.cbxCategoryId);
			this.gbxProductAdd.Controls.Add(this.tbxProductName2);
			this.gbxProductAdd.Controls.Add(this.lblQuantityPerUnit);
			this.gbxProductAdd.Controls.Add(this.lblStock);
			this.gbxProductAdd.Controls.Add(this.lblUnitPrice);
			this.gbxProductAdd.Controls.Add(this.lblCategoryID);
			this.gbxProductAdd.Controls.Add(this.lblProductName2);
			this.gbxProductAdd.Location = new System.Drawing.Point(366, 12);
			this.gbxProductAdd.Name = "gbxProductAdd";
			this.gbxProductAdd.Size = new System.Drawing.Size(422, 148);
			this.gbxProductAdd.TabIndex = 3;
			this.gbxProductAdd.TabStop = false;
			this.gbxProductAdd.Text = "Add New Product";
			// 
			// lblProductName2
			// 
			this.lblProductName2.AutoSize = true;
			this.lblProductName2.Location = new System.Drawing.Point(6, 25);
			this.lblProductName2.Name = "lblProductName2";
			this.lblProductName2.Size = new System.Drawing.Size(75, 13);
			this.lblProductName2.TabIndex = 0;
			this.lblProductName2.Text = "Product Name";
			// 
			// lblCategoryID
			// 
			this.lblCategoryID.AutoSize = true;
			this.lblCategoryID.Location = new System.Drawing.Point(6, 49);
			this.lblCategoryID.Name = "lblCategoryID";
			this.lblCategoryID.Size = new System.Drawing.Size(49, 13);
			this.lblCategoryID.TabIndex = 1;
			this.lblCategoryID.Text = "Category";
			// 
			// lblUnitPrice
			// 
			this.lblUnitPrice.AutoSize = true;
			this.lblUnitPrice.Location = new System.Drawing.Point(6, 73);
			this.lblUnitPrice.Name = "lblUnitPrice";
			this.lblUnitPrice.Size = new System.Drawing.Size(31, 13);
			this.lblUnitPrice.TabIndex = 2;
			this.lblUnitPrice.Text = "Price";
			// 
			// lblStock
			// 
			this.lblStock.AutoSize = true;
			this.lblStock.Location = new System.Drawing.Point(6, 97);
			this.lblStock.Name = "lblStock";
			this.lblStock.Size = new System.Drawing.Size(35, 13);
			this.lblStock.TabIndex = 3;
			this.lblStock.Text = "Stock";
			// 
			// lblQuantityPerUnit
			// 
			this.lblQuantityPerUnit.AutoSize = true;
			this.lblQuantityPerUnit.Location = new System.Drawing.Point(6, 121);
			this.lblQuantityPerUnit.Name = "lblQuantityPerUnit";
			this.lblQuantityPerUnit.Size = new System.Drawing.Size(87, 13);
			this.lblQuantityPerUnit.TabIndex = 4;
			this.lblQuantityPerUnit.Text = "Quantity Per Unit";
			// 
			// tbxProductName2
			// 
			this.tbxProductName2.Location = new System.Drawing.Point(109, 22);
			this.tbxProductName2.Name = "tbxProductName2";
			this.tbxProductName2.Size = new System.Drawing.Size(146, 20);
			this.tbxProductName2.TabIndex = 5;
			// 
			// cbxCategoryId
			// 
			this.cbxCategoryId.FormattingEnabled = true;
			this.cbxCategoryId.Location = new System.Drawing.Point(109, 46);
			this.cbxCategoryId.Name = "cbxCategoryId";
			this.cbxCategoryId.Size = new System.Drawing.Size(146, 21);
			this.cbxCategoryId.TabIndex = 6;
			// 
			// tbxUnitPrice
			// 
			this.tbxUnitPrice.Location = new System.Drawing.Point(109, 70);
			this.tbxUnitPrice.Name = "tbxUnitPrice";
			this.tbxUnitPrice.Size = new System.Drawing.Size(146, 20);
			this.tbxUnitPrice.TabIndex = 7;
			// 
			// tbxStock
			// 
			this.tbxStock.Location = new System.Drawing.Point(109, 94);
			this.tbxStock.Name = "tbxStock";
			this.tbxStock.Size = new System.Drawing.Size(146, 20);
			this.tbxStock.TabIndex = 8;
			// 
			// tbxQuantityPerUnit
			// 
			this.tbxQuantityPerUnit.Location = new System.Drawing.Point(109, 118);
			this.tbxQuantityPerUnit.Name = "tbxQuantityPerUnit";
			this.tbxQuantityPerUnit.Size = new System.Drawing.Size(146, 20);
			this.tbxQuantityPerUnit.TabIndex = 9;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(300, 33);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(92, 23);
			this.btnAdd.TabIndex = 10;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(300, 68);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(92, 23);
			this.btnUpdate.TabIndex = 11;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(300, 104);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(92, 23);
			this.btnDelete.TabIndex = 12;
			this.btnDelete.Text = "Remove";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.gbxProductAdd);
			this.Controls.Add(this.gbxProductName);
			this.Controls.Add(this.gbxCategory);
			this.Controls.Add(this.dgwProduct);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(816, 489);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(816, 489);
			this.Name = "Form1";
			this.Text = "Products";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
			this.gbxCategory.ResumeLayout(false);
			this.gbxCategory.PerformLayout();
			this.gbxProductName.ResumeLayout(false);
			this.gbxProductName.PerformLayout();
			this.gbxProductAdd.ResumeLayout(false);
			this.gbxProductAdd.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgwProduct;
		private System.Windows.Forms.GroupBox gbxCategory;
		private System.Windows.Forms.ComboBox cbxCategory;
		private System.Windows.Forms.Label lblCategory;
		private System.Windows.Forms.GroupBox gbxProductName;
		private System.Windows.Forms.TextBox tbxProductName;
		private System.Windows.Forms.Label lblProductName;
		private System.Windows.Forms.GroupBox gbxProductAdd;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.TextBox tbxQuantityPerUnit;
		private System.Windows.Forms.TextBox tbxStock;
		private System.Windows.Forms.TextBox tbxUnitPrice;
		private System.Windows.Forms.ComboBox cbxCategoryId;
		private System.Windows.Forms.TextBox tbxProductName2;
		private System.Windows.Forms.Label lblQuantityPerUnit;
		private System.Windows.Forms.Label lblStock;
		private System.Windows.Forms.Label lblUnitPrice;
		private System.Windows.Forms.Label lblCategoryID;
		private System.Windows.Forms.Label lblProductName2;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnUpdate;
	}
}

