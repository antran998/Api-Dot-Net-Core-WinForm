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

namespace StorageManager.CustomElement
{
    public partial class ChildrenDataTable : UserControl
    {
        private readonly string _billId;
        public ChildrenDataTable(string billId)
        {
            InitializeComponent();
            _billId = billId;
        }

        private async void ChildrenDataTable_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Top;

            var storageApi = RestService.For<IStorageApi>("https://localhost:5001", new RefitSettings
            {
                AuthorizationHeaderValueGetter = () => Task.FromResult(LoginForm.cachedToken)
            });

            var billDetails = await storageApi.GetBillDetailsByBillIdAsync(_billId, new PaginationQuery
            {
                PageNumber = 1,
                PageSize = 100
            });

            foreach (var item in billDetails.Content.Data)
            {
                string[] row = new string[] {item.ProductName,item.Price.ToString(),item.Quantity.ToString()};
                bunifuDataGridView1.Rows.Add(row);
            }
        }
    }
}
