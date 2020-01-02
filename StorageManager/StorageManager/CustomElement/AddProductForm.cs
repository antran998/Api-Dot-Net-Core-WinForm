using Refit;
using Storage.Contracts.v1.Requests;
using Storage.sdk;
using StorageManager.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StorageManager.CustomElement
{
    public partial class AddProductForm : Form
    {
        private readonly string _typeId;
        private readonly string _typeName;
        private readonly ProductTypePage _page;
        
        public AddProductForm(string typeId, string typeName, ProductTypePage page)
        {
            _typeId = typeId;
            _typeName = typeName;
            _page = page;
            InitializeComponent();
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {
            typeTb.Text = _typeName;
        }

        private async void addBtn_Click(object sender, EventArgs e)
        {            
            addBtn.Enabled = false;
            var storageApi = RestService.For<IStorageApi>("https://localhost:5001", new RefitSettings
            {
                AuthorizationHeaderValueGetter = () => Task.FromResult(LoginForm.cachedToken)
            });

            var newProduct = await storageApi.CreateProductAsync(new CreateProductRequest 
            {
                ProductName = nameTb.Text,
                Price = int.Parse(priceTb.Text),
                Quantity = 0,
                TypeId = _typeId
            });

            if(newProduct.Content != null)
            {
                string[] image = Directory.GetFiles(@"C:\Users\Admin\source\repos\StorageManager\StorageManager\Img", "success.gif");
                Alert problem = new Alert("Add success", image[0]);
                problem.ShowDialog();

                _page.Refresh();
                this.Close();
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
