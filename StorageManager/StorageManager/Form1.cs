using Bunifu.Framework.UI;
using StorageManager.CustomElement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Refit;
using Storage.sdk;
using Newtonsoft.Json;
using StrorageRestApi.Contracts.v1.Responses;
using Storage.Contracts.v1.Requests.Queries;
using Storage.Contracts.v1.Responses;
using StrorageRestApi.Contracts.v1.Requests;
using System.IO;
using StorageManager.Pages;

namespace StorageManager
{
    public partial class Form1 : Form
    {        
        public Form1()
        {
            InitializeComponent();
        }        
        
        // Start loading needed controls        
        int lastIndex;
        BunifuFlatButton[] optionBtn = new BunifuFlatButton[4];

        DashboardPage dasboardTemplate;
        ProductTypePage productTypeTemplate;
        BillPage billTemplate;
        StatisticPage statisticTemplate;

        private void Form1_Load(object sender, EventArgs e)
        {
            loadControls();
            bunifuPages1.SetPage("Dashboard");
            dasboardTemplate = new DashboardPage();
            DashboardPg.Controls.Add(dasboardTemplate);

            InfoPage infoTemplate = new InfoPage();
            UserInfo.Controls.Add(infoTemplate);
        }

        void loadControls()
        {
            // load option buttons
            List<string> btnName = new List<string>
            {
                "Dashboard",
                "Product Manager",
                "Bill Manager",
                "Statistic"
            };

            for (int i = 3; i >= 0; i--)
            {
                optionBtn[i] = new BunifuFlatButton();
                optionBtn[i].Dock = DockStyle.Top;
                optionBtn[i].Normalcolor = Color.FromArgb(11, 7, 17);
                optionBtn[i].Activecolor = Color.FromArgb(65, 62, 83);
                optionBtn[i].Height = 48;
                optionBtn[i].OnHovercolor = Color.FromArgb(65, 62, 83);
                optionBtn[i].Text = btnName[i];
                optionBtn[i].Tag = i;
                optionBtn[i].Click += (sender, e) =>
                {
                    BunifuFlatButton thisBtn = sender as BunifuFlatButton;
                    int thisIndex = int.Parse(thisBtn.Tag.ToString());
                    BtnRedirectEvent(thisIndex,lastIndex);
                    lastIndex = thisIndex;
                };               
                
                panel5.Controls.Add(optionBtn[i]);
            }
            lastIndex = 0;
        }

        void BtnRedirectEvent(int thisIndex,int lastIndex)
        {
            if(optionBtn[thisIndex].Normalcolor != Color.FromArgb(65, 62, 83))
            {
                List<string> pageName = new List<string>
                {
                    "DashboardPg",
                    "productTypePg",
                    "BillMngPg",
                    "StatisticPg"
                };

                optionBtn[thisIndex].Active = true;
                optionBtn[thisIndex].Normalcolor = Color.FromArgb(65, 62, 83);

                optionBtn[lastIndex].Active = false;
                optionBtn[lastIndex].Normalcolor = Color.FromArgb(11, 7, 17);

                activeBar.Top = optionBtn[thisIndex].Top;
                activeBar.BringToFront();

                bunifuPages1.PageName = pageName[thisIndex];

                switch (thisIndex)
                {
                    case 0:
                        dasboardTemplate = new DashboardPage();
                        DashboardPg.Controls.Add(dasboardTemplate);
                        break;
                    case 1:
                        productTypeTemplate = new ProductTypePage();
                        productTypePg.Controls.Add(productTypeTemplate);
                        break;
                    case 2:
                        billTemplate = new BillPage();
                        BillMngPg.Controls.Add(billTemplate);
                        break;
                    case 3:
                        statisticTemplate = new StatisticPage();
                        StatisticPg.Controls.Add(statisticTemplate);
                        break;
                }                

                switch (lastIndex)
                {
                    case 0:
                        DashboardPg.Controls.Remove(dasboardTemplate);
                        dasboardTemplate.Dispose();
                        break;
                    case 1:
                        productTypePg.Controls.Remove(productTypeTemplate);
                        productTypeTemplate.Dispose();
                        break;
                    case 2:
                        BillMngPg.Controls.Remove(billTemplate);
                        billTemplate.Dispose();
                        break;
                    case 3:
                        StatisticPg.Controls.Remove(statisticTemplate);
                        statisticTemplate.Dispose();
                        break;
                }
            }            
        }
        
        // End loading needed controls

        // Start hover with system Btn
        private void HoverSystemBtn(BunifuImageButton btn)
        {
            if (btn.BackColor == Color.FromArgb(11, 7, 17))
                btn.BackColor = Color.FromArgb(32, 30, 45);
            else
                btn.BackColor = Color.FromArgb(11, 7, 17);
        }

        private void MinimizeBtn_MouseLeave(object sender, EventArgs e)
        {
            HoverSystemBtn(MinimizeBtn);
        }     

        private void MinimizeBtn_MouseEnter(object sender, EventArgs e)
        {
            HoverSystemBtn(MinimizeBtn);
        }

        private void FullScreenBtn_MouseEnter(object sender, EventArgs e)
        {
            HoverSystemBtn(FullScreenBtn);
        }

        private void FullScreenBtn_MouseLeave(object sender, EventArgs e)
        {
            HoverSystemBtn(FullScreenBtn);
        }

        private void ExitBtn_MouseEnter(object sender, EventArgs e)
        {
            HoverSystemBtn(ExitBtn);
        }

        private void ExitBtn_MouseLeave(object sender, EventArgs e)
        {
            HoverSystemBtn(ExitBtn);
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FullScreenBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // End hover with system Btn

        // Start page redirect Btn
        private void InfoBtn_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageName = "UserInfo";
        }
        // End page redirect Btn

    }
}
