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

namespace StorageManager.Pages
{
    public partial class InfoPage : UserControl
    {
        public InfoPage()
        {
            InitializeComponent();
        }

        private async void InfoPage_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;

            var identityApi = RestService.For<IIdentityApi>("https://localhost:5001");

            var user = await identityApi.GetUserInfoAsync(LoginForm.refreshToken);

            nameTb.Text = user.Content.Name;
            emailTb.Text = user.Content.Email;
            phoneTb.Text = user.Content.Phone;
            idTb.Text = user.Content.Id;
        }
    }
}
