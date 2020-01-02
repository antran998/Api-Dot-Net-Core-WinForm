using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Storage.Contracts.v1.Responses;
using Refit;
using Storage.sdk;
using Storage.Contracts.v1.Requests;
using System.IO;
using StorageManager.CustomElement;

namespace StorageManager.Pages
{
    public partial class ProductInfoPage : UserControl
    {
        private readonly ProductResponse _product;
        private readonly string _typeName;
        private readonly ProductTypePage _page;

        public ProductInfoPage(ProductResponse product, string typeName, ProductTypePage page)
        {
            _product = product;
            _typeName = typeName;
            _page = page;
            InitializeComponent();
        }

        private void ProductInfoPage_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            nameShow.Text = _product.ProductName;
            priceShow.Text = _product.Price.ToString();
            quantityShow.Text = _product.Quantity.ToString();
            typeNameShow.Text = _typeName;
        }

        private async void update_Click(object sender, EventArgs e)
        {
            update.Enabled = false;
            var storageApi = RestService.For<IStorageApi>("https://localhost:5001", new RefitSettings
            {
                AuthorizationHeaderValueGetter = () => Task.FromResult(LoginForm.cachedToken)
            });

            var updated = await storageApi.UpdateProductAsync(_product.Id,new UpdateProductRequest
            {
                ProductName = nameFix.Text,
                Price = int.Parse(priceFix.Text),
                Quantity = int.Parse(quantityFix.Text),
                TypeId = _product.TypeId         
            });

            if(updated.Content != null)
            {
                string[] image = Directory.GetFiles(@"C:\Users\Admin\source\repos\StorageManager\StorageManager\Img", "success.gif");
                Alert problem = new Alert("Update successfully", image[0]);
                problem.ShowDialog();

                nameFix.Text = "";
                priceFix.Text = "";
                quantityFix.Text = "";

                nameShow.Text = updated.Content.ProductName;
                priceShow.Text = updated.Content.Price.ToString();
                quantityShow.Text = updated.Content.Quantity.ToString();
                update.Enabled = true;
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            _page.Controls.Clear();
            ProductTypePage productTypePage = new ProductTypePage();
            _page.Controls.Add(productTypePage);
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string[] image = Directory.GetFiles(@"C:\Users\Admin\source\repos\StorageManager\StorageManager\Img", "fail.gif");
            DeleteAlert problem = new DeleteAlert("Are you sure, you want to delete " +_product.ProductName, image[0],_page,_product);
            problem.ShowDialog();            
        }
    }
}
