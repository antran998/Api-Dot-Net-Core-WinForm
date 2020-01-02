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

namespace StorageManager.CustomElement
{
    public partial class NestedDataTable : UserControl
    {
        private readonly BillResponse _bill;
        public NestedDataTable( BillResponse bill)
        {
            InitializeComponent();
            _bill = bill;
        }
        int check = 1;

        private void NestedDataTable_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Top;
            label1.Text = _bill.Id;
            label2.Text = _bill.Date;
            label3.Text = _bill.Price.ToString();
            label4.Text = _bill.Quantity.ToString();
        }

        private void tableLayoutPanel1_Click(object sender, EventArgs e)
        {
            if (check == 1)
            {
                ChildrenDataTable childData = new ChildrenDataTable(_bill.Id);
                panel1.Controls.Add(childData);
                check = 0;
            }            
        }
    }
}
