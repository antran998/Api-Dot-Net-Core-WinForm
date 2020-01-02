using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StorageManager.Pages
{
    public partial class BillPage : UserControl
    {
        public BillPage()
        {
            InitializeComponent();
        }

        private void BillPage_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        private void GoToBillMng(object sender, EventArgs e)
        {
            this.Controls.Clear();
            BillManagerPage billManagerPage = new BillManagerPage("60018972-6dae-45d0-9426-3fe6dcb59363");
            this.Controls.Add(billManagerPage);
        }

        private void GoToBillOutMng(object sender, EventArgs e)
        {
            this.Controls.Clear();
            BillManagerPage billManagerPage = new BillManagerPage("2e8b5f82-3363-4a50-b47c-c75e76cbe937");
            this.Controls.Add(billManagerPage);
        }
    }
}
