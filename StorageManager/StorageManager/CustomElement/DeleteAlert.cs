using Refit;
using Storage.Contracts.v1.Responses;
using Storage.sdk;
using StorageManager.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StorageManager.CustomElement
{
    public partial class DeleteAlert : Form
    {
        private readonly string _content;
        private readonly string _image;
        private readonly ProductTypePage _page;
        private readonly ProductResponse _product;
        public DeleteAlert(string content, string image, ProductTypePage page,ProductResponse product)
        {
            _content = content;
            _image = image;
            _page = page;
            _product = product;
            InitializeComponent();
        }
                
        private void DeleteAlert_Load(object sender, EventArgs e)
        {
            alertText.Text = _content;
            alertGif.Image = Image.FromFile(_image);
        }

        private void denyDe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void confirmDe_Click(object sender, EventArgs e)
        {
            confirmDe.Enabled = false;
            this.Close();
            if (_product!=null)
            {
                var storageApi = RestService.For<IStorageApi>("https://localhost:5001?pagenumber", new RefitSettings
                {
                    AuthorizationHeaderValueGetter = () => Task.FromResult(LoginForm.cachedToken)
                });

                var deleted = await storageApi.DeleteProductAsync(_product.Id);

                _page.Controls.Clear();
                ProductTypePage productTypePage = new ProductTypePage();
                _page.Controls.Add(productTypePage);
            }
        }
    }
}
