using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StorageManager.Pages;
using Storage.Contracts.v1.Responses;

namespace StorageManager.CustomElement
{
    public partial class ProductLabel : UserControl
    {
        private readonly ProductResponse _product;
        private readonly string _typeName;
        private readonly ProductTypePage _page;

        public ProductLabel(ProductResponse product,string typeName, ProductTypePage page)
        {
            _product = product;
            _typeName = typeName;
            _page = page;
            InitializeComponent();
        }

        private void ProductLabel_Load(object sender, EventArgs e)
        {
            bunifuLabel1.Text = _product.ProductName;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            _page.Controls.Clear();
            ProductInfoPage productInfoPage = new ProductInfoPage(_product,_typeName,_page);
            _page.Controls.Add(productInfoPage);
        }
    }
}
