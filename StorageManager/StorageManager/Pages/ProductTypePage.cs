using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Refit;
using Storage.sdk;
using Storage.Contracts.v1.Requests.Queries;
using StorageManager.CustomElement;
using StrorageRestApi.Contracts.v1.Requests;
using System.IO;

namespace StorageManager.Pages
{
    public partial class ProductTypePage : UserControl
    {
        public ProductTypePage()
        {            
            InitializeComponent();            
        }

        private void ProductTypePage_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            loadProductTypePage();
        }
        string next,prev;
        int pageIndex;
        async void loadProductTypePage()
        {
            var storageApi = RestService.For<IStorageApi>("https://localhost:5001", new RefitSettings
            {
                AuthorizationHeaderValueGetter = () => Task.FromResult(LoginForm.cachedToken)
            });
            var productTypes = await storageApi.GetAllAsync(new PaginationQuery
            {
                PageNumber = 1,
                PageSize = 3
            });

            if (productTypes.Content.NextPage == null)
            {
                next = "";
                nextBtn.Enabled = false;
            }
            else 
            {
                next = productTypes.Content.NextPage;
                nextBtn.Enabled = true;
            }

            if (productTypes.Content.PreviousPage == null)
            {
                prev = "";
                prevBtn.Enabled = false;
            }
            else
            {
                prev = productTypes.Content.PreviousPage;
                prevBtn.Enabled = true;
            }

            pageIndex = 1;
            currPage.Text = pageIndex.ToString();

            foreach (var item in productTypes.Content.Data)
            {
                TypeRow tr = new TypeRow(item.Type,item.Id,this);
                tr.Dock = DockStyle.Top;
                typePanel.Controls.Add(tr);
            }
        }

        // Start handle type
        private async void addTypeBtn_Click(object sender, EventArgs e)
        {
            if (addTypeTb.Text != "")
            {
                addTypeBtn.Enabled = false;
                var storageApi = RestService.For<IStorageApi>("https://localhost:5001", new RefitSettings
                {
                    AuthorizationHeaderValueGetter = () => Task.FromResult(LoginForm.cachedToken)
                });

                var newType = await storageApi.CreateAsync(new CreateProductTypeRequest
                {
                    TypeName = addTypeTb.Text
                });

                if (newType.Content != null)
                {
                    string[] image = Directory.GetFiles(@"C:\Users\Admin\source\repos\StorageManager\StorageManager\Img", "success.gif");

                    Alert problem = new Alert("Add success", image[0]);
                    problem.ShowDialog();
                    addTypeBtn.Enabled = true;
                }
            }
        }
        private async void findTypeBtn_Click(object sender, EventArgs e)
        {
            if (findTypeTB.Text != "")
            {
                findTypeBtn.Enabled = false;
                var storageApi = RestService.For<IStorageApi>("https://localhost:5001", new RefitSettings
                {
                    AuthorizationHeaderValueGetter = () => Task.FromResult(LoginForm.cachedToken)
                });

                var findType = await storageApi.GetAsync(findTypeTB.Text);

                if (findType.Content != null)
                {
                    typePanel.Controls.Clear();

                    TypeRow tr = new TypeRow(findType.Content.Type, findType.Content.Id,this);
                    tr.Dock = DockStyle.Top;
                    typePanel.Controls.Add(tr);

                    findTypeBtn.Enabled = true;
                }
                else
                {
                    string[] image = Directory.GetFiles(@"C:\Users\Admin\source\repos\StorageManager\StorageManager\Img", "fail.gif");

                    Alert problem = new Alert("Not found", image[0]);
                    problem.ShowDialog();
                    findTypeBtn.Enabled = true;
                }
            }
        }

        // End handle type

        //Start static function
        public void Refresh()
        {
            typePanel.Controls.Clear();
            loadProductTypePage();
        }

        private async void prevBtn_Click(object sender, EventArgs e)
        {
            pageIndex--;
            currPage.Text = pageIndex.ToString();
            typePanel.Controls.Clear();
            var storageApi = RestService.For<IStorageApi>("https://localhost:5001", new RefitSettings
            {
                AuthorizationHeaderValueGetter = () => Task.FromResult(LoginForm.cachedToken)
            });
            var productTypes = await storageApi.GetAllAsync(new PaginationQuery
            {            
                PageNumber=pageIndex,
                PageSize = 3
            });

            if (productTypes.Content.NextPage == null)
            {
                next = "";
                nextBtn.Enabled = false;
            }
            else
            {
                next = productTypes.Content.NextPage;
                nextBtn.Enabled = true;
            }

            if (productTypes.Content.PreviousPage == null)
            {
                prev = "";
                prevBtn.Enabled = false;
            }
            else
            {
                prev = productTypes.Content.PreviousPage;
                prevBtn.Enabled = true;
            }            

            foreach (var item in productTypes.Content.Data)
            {
                TypeRow tr = new TypeRow(item.Type, item.Id, this);
                tr.Dock = DockStyle.Top;
                typePanel.Controls.Add(tr);
            }
        }

        private async void nextBtn_Click(object sender, EventArgs e)
        {
            pageIndex++;
            currPage.Text = pageIndex.ToString();
            typePanel.Controls.Clear();
            var storageApi = RestService.For<IStorageApi>("https://localhost:5001", new RefitSettings
            {
                AuthorizationHeaderValueGetter = () => Task.FromResult(LoginForm.cachedToken)
            });
            var productTypes = await storageApi.GetAllAsync(new PaginationQuery
            {
                PageNumber = pageIndex,
                PageSize = 3
            });

            if (productTypes.Content.NextPage == null)
            {
                next = "";
                nextBtn.Enabled = false;
            }
            else
            {
                next = productTypes.Content.NextPage;
                nextBtn.Enabled = true;
            }

            if (productTypes.Content.PreviousPage == null)
            {
                prev = "";
                prevBtn.Enabled = false;
            }
            else
            {
                prev = productTypes.Content.PreviousPage;
                prevBtn.Enabled = true;
            }

            foreach (var item in productTypes.Content.Data)
            {
                TypeRow tr = new TypeRow(item.Type, item.Id, this);
                tr.Dock = DockStyle.Top;
                typePanel.Controls.Add(tr);
            }
        }
        //End static function
    }
}
