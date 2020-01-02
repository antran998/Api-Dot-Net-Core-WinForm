using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StorageManager.CustomElement;
using Storage.Contracts.v1.Responses;
using Refit;
using Storage.sdk;
using Storage.Contracts.v1.Requests.Queries;

namespace StorageManager.Pages
{
    public partial class BillManagerPage : UserControl
    {
        private readonly string _typeId;
        public BillManagerPage(string typeId)
        {
            InitializeComponent();
            _typeId = typeId;
        }

        private async void BillManagerPage_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            
            var storageApi = RestService.For<IStorageApi>("https://localhost:5001", new RefitSettings
            {
                AuthorizationHeaderValueGetter = () => Task.FromResult(LoginForm.cachedToken)
            });

            var bills = await storageApi.GetBillsByTypeAsync(_typeId, new PaginationQuery
            {
                PageNumber = 1,
                PageSize = 5
            }) ;

            foreach (var item in bills.Content.Data)
            {
                NestedDataTable row = new NestedDataTable(item);
                panel2.Controls.Add(row);
            }            
            
        }

        private async void findBillBtn_Click(object sender, EventArgs e)
        {
            if (findBillTb.Text != "")
            {
                panel2.Controls.Clear();
                var storageApi = RestService.For<IStorageApi>("https://localhost:5001", new RefitSettings
                {
                    AuthorizationHeaderValueGetter = () => Task.FromResult(LoginForm.cachedToken)
                });

                var bills = await storageApi.GetBillsByDateAsync(findBillTb.Text, new PaginationQuery
                {
                    PageNumber=1,
                    PageSize = 5
                });

                foreach (var item in bills.Content.Data)
                {
                    NestedDataTable row = new NestedDataTable(item);
                    panel2.Controls.Add(row);
                }
            }
        }
    }
}
