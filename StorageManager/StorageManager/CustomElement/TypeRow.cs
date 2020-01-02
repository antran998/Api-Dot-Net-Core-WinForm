using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Refit;
using Storage.sdk;
using System.IO;
using StorageManager.Pages;
using Storage.Contracts.v1.Requests.Queries;
using Storage.Contracts.v1.Responses;

namespace StorageManager.CustomElement
{
    public partial class TypeRow : UserControl
    {        
        private readonly string _typeName;
        private readonly string _typeId;
        private readonly ProductTypePage _page;

        public TypeRow( string typeName, string typeId, ProductTypePage page)
        {            
            _typeName = typeName;
            _typeId = typeId;
            _page = page;
            InitializeComponent();
        }
        string prev, next;
        int pageIndex;
        private async void TypeRow_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Top;
            typeLabel.Text = _typeName;

            var storageApi = RestService.For<IStorageApi>("https://localhost:5001?pagenumber", new RefitSettings
            {
                AuthorizationHeaderValueGetter = () => Task.FromResult(LoginForm.cachedToken)
            });

            var products = await storageApi.GetAllProductByTypeAsync(_typeId,new PaginationQuery 
            { 
                PageNumber = 1,
                PageSize = 5
            });

            if (products.Content.NextPage == null)
            {
                next = "";
                nextBtn.Enabled = false;
            }
            else
            {
                next = products.Content.NextPage;
                nextBtn.Enabled = true;
            }

            if (products.Content.PreviousPage == null)
            {
                prev = "";
                prevBtn.Enabled = false;
            }
            else
            {
                prev = products.Content.PreviousPage;
                prevBtn.Enabled = true;
            }

            pageIndex = 1;
            currPage.Text = pageIndex.ToString();

            foreach (var item in products.Content.Data)
            {
                ProductLabel pl = new ProductLabel(item,_typeName,_page);
                tableLayoutPanel1.Controls.Add(pl);
            }
        }

        private async void deleteTypeBtn_Click(object sender, EventArgs e)
        {
            deleteTypeBtn.Enabled = false;
            var storageApi = RestService.For<IStorageApi>("https://localhost:5001", new RefitSettings
            {
                AuthorizationHeaderValueGetter = () => Task.FromResult(LoginForm.cachedToken)
            });
            
            string[] image = Directory.GetFiles(@"C:\Users\Admin\source\repos\StorageManager\StorageManager\Img", "fail.gif");
            Alert problem = new Alert("Are you sure you want to delete "+_typeName, image[0]);
            problem.ShowDialog();

            var deleteType = await storageApi.DeleteAsync(_typeId);
            //if(deleteType)
            //string[] image = Directory.GetFiles(@"C:\Users\Admin\source\repos\StorageManager\StorageManager\Img", "fail.gif");
            //Alert problem = new Alert("Only delete blank type", image[0]);
            //problem.ShowDialog();

            _page.Refresh();
        }

        private void addProductBtn_Click(object sender, EventArgs e)
        {
            AddProductForm addForm = new AddProductForm(_typeId,_typeName,_page);
            addForm.ShowDialog();
        }

        private async void findProductBtn_Click(object sender, EventArgs e)
        {
            if(findProductTB.Text != "")
            {
                findProductBtn.Enabled = false;
                var storageApi = RestService.For<IStorageApi>("https://localhost:5001", new RefitSettings
                {
                    AuthorizationHeaderValueGetter = () => Task.FromResult(LoginForm.cachedToken)
                });

                var product = await storageApi.GetProductAsync(findProductTB.Text);
                
                tableLayoutPanel1.Controls.Clear();
                ProductLabel pl = new ProductLabel(product.Content,_typeName,_page);
                tableLayoutPanel1.Controls.Add(pl);
                findProductTB.Enabled = true;
            }
        }

        private async void nextBtn_Click(object sender, EventArgs e)
        {
            pageIndex++;
            currPage.Text = pageIndex.ToString();
            tableLayoutPanel1.Controls.Clear();
            var storageApi = RestService.For<IStorageApi>("https://localhost:5001?pagenumber", new RefitSettings
            {
                AuthorizationHeaderValueGetter = () => Task.FromResult(LoginForm.cachedToken)
            });

            var products = await storageApi.GetAllProductByTypeAsync(_typeId, new PaginationQuery
            {
                PageNumber = pageIndex,
                PageSize = 5
            });

            if (products.Content.NextPage == null)
            {
                next = "";
                nextBtn.Enabled = false;
            }
            else
            {
                next = products.Content.NextPage;
                nextBtn.Enabled = true;
            }

            if (products.Content.PreviousPage == null)
            {
                prev = "";
                prevBtn.Enabled = false;
            }
            else
            {
                prev = products.Content.PreviousPage;
                prevBtn.Enabled = true;
            }
            
            foreach (var item in products.Content.Data)
            {
                ProductLabel pl = new ProductLabel(item, _typeName, _page);
                tableLayoutPanel1.Controls.Add(pl);
            }
        }

        private async void prevBtn_Click(object sender, EventArgs e)
        {
            pageIndex--;
            currPage.Text = pageIndex.ToString();
            tableLayoutPanel1.Controls.Clear();
            var storageApi = RestService.For<IStorageApi>("https://localhost:5001?pagenumber", new RefitSettings
            {
                AuthorizationHeaderValueGetter = () => Task.FromResult(LoginForm.cachedToken)
            });

            var products = await storageApi.GetAllProductByTypeAsync(_typeId, new PaginationQuery
            {
                PageNumber = pageIndex,
                PageSize = 5
            });

            if (products.Content.NextPage == null)
            {
                next = "";
                nextBtn.Enabled = false;
            }
            else
            {
                next = products.Content.NextPage;
                nextBtn.Enabled = true;
            }

            if (products.Content.PreviousPage == null)
            {
                prev = "";
                prevBtn.Enabled = false;
            }
            else
            {
                prev = products.Content.PreviousPage;
                prevBtn.Enabled = true;
            }

            foreach (var item in products.Content.Data)
            {
                ProductLabel pl = new ProductLabel(item, _typeName, _page);
                tableLayoutPanel1.Controls.Add(pl);
            }
        }
    }
}
