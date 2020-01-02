using Newtonsoft.Json;
using Refit;
using Storage.sdk;
using StorageManager.Custom_Class;
using StorageManager.CustomElement;
using StrorageRestApi.Contracts.v1.Requests;
using StrorageRestApi.Contracts.v1.Responses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StorageManager
{
    public partial class LoginForm : Form
    {
        public static string cachedToken = string.Empty;
        public static string refreshToken = string.Empty;
        //public static string cachedToken = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiJiYW9hbjExMTExQGdtYWlsLmNvbSIsImp0aSI6ImY0ZmIyODk2LThhOTQtNGMzMC1iMzA1LWMzYmRjNWQwYTE4OCIsImVtYWlsIjoiYmFvYW4xMTExMUBnbWFpbC5jb20iLCJpZCI6IjkxMjFhOTU4LWNhZWEtNGQ5NS1iNDIyLTYxZWUxMzA0ZmYxZCIsIm5iZiI6MTU3MzA2OTM0MywiZXhwIjoxNTc1MTQyOTQzLCJpYXQiOjE1NzMwNjkzNDN9.fyJ0S8TJt_js6_UJTEgq_MDuVrUse_LHpaFH6eJ4g4U";
        
        public LoginForm()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void signUpTab_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageName = "Register";
        }

        private void loginTab_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageName = "Login";
        }        

        private async void loginBtn_Click(object sender, EventArgs e)
        {   
            var identityApi = RestService.For<IIdentityApi>("https://localhost:5001");
            //var storageApi = RestService.For<IStorageApi>("https://localhost:5001", new RefitSettings
            //{
            //    AuthorizationHeaderValueGetter = () => Task.FromResult(cachedToken)
            //});              

            loginBtn.Enabled = false;

            var loginResponse = await identityApi.LoginAsync(new UserLoginRequest
            {
                Email = emailLogin.Text,
                Password = passwordLogin.Text
            });

            if (loginResponse.IsSuccessStatusCode == true)
            {
                cachedToken = loginResponse.Content.Token;
                refreshToken = loginResponse.Content.RefreshToken;
                this.Close();
                System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));
                t.Start();
            }
            else
            {
                ErrorsResult error = JsonConvert.DeserializeObject<ErrorsResult>(loginResponse.Error.Content);
                if(error.Errors != null)
                {
                    string content = error.Errors.SingleOrDefault();
                    string[] image = Directory.GetFiles(@"C:\Users\Admin\source\repos\StorageManager\StorageManager\Img", "fail.gif");

                    Alert problem = new Alert(content, image[0]);
                    problem.ShowDialog();
                    loginBtn.Enabled = true;
                }
                else
                {
                    List<ErrorValidator> contentValid = error.ErrorsValidator.ToList();
                    string[] image = Directory.GetFiles(@"C:\Users\Admin\source\repos\StorageManager\StorageManager\Img", "fail.gif");

                    Alert problem = new Alert("Fields is required", image[0]);
                    problem.ShowDialog();
                    loginBtn.Enabled = true;
                }
            }
        }

        public static void ThreadProc()
        {            
            Application.Run(new Form1());
        }

        private async void registerBtn_Click(object sender, EventArgs e)
        {
            var identityApi = RestService.For<IIdentityApi>("https://localhost:5001");
            //var storageApi = RestService.For<IStorageApi>("https://localhost:5001", new RefitSettings
            //{
            //    AuthorizationHeaderValueGetter = () => Task.FromResult(cachedToken)
            //});
            registerBtn.Enabled = false;
            var registerResponse = await identityApi.RegisterAsync(new UserRegistrationRequest
            {
                Email = emailReg.Text,
                Password = passwordReg.Text,
                Name = nameReg.Text,
                Confirm = confirmReg.Text,
                Phone = phoneReg.Text
            });

            if (registerResponse.IsSuccessStatusCode == true)
            {                
                string[] image = Directory.GetFiles(@"C:\Users\Admin\source\repos\StorageManager\StorageManager\Img", "success.gif");

                Alert success = new Alert("Register Success", image[0]);
                success.ShowDialog();
                bunifuPages1.PageName = "Login";
                registerBtn.Enabled = true;
            }
            else
            {
                ErrorsResult error = JsonConvert.DeserializeObject<ErrorsResult>(registerResponse.Error.Content);
                
                if(error.Errors != null)
                {
                    string content = error.Errors.SingleOrDefault();
                    string[] image = Directory.GetFiles(@"C:\Users\Admin\source\repos\StorageManager\StorageManager\Img", "fail.gif");

                    Alert problem = new Alert(content, image[0]);
                    problem.ShowDialog();
                    registerBtn.Enabled = true;
                }
                else
                {
                    showError(error.ErrorsValidator);
                    string[] image = Directory.GetFiles(@"C:\Users\Admin\source\repos\StorageManager\StorageManager\Img", "fail.gif");

                    Alert problem = new Alert("Register fail", image[0]);
                    problem.ShowDialog();                    
                    registerBtn.Enabled = true;
                }
            }
        }  
        
        void showError(List<ErrorValidator> errorValidator)
        {
            string[] message = { "", "", "", "", "" };
            foreach (var errorVal in errorValidator)
            {
                switch (errorVal.FieldName)
                {
                    case "Name":
                        message[0] += errorVal.Message + Environment.NewLine;
                        errorName.Visible = true;
                        bunifuToolTip1.SetToolTip(errorName, message[0]);
                        break;
                    case "Email":
                        message[1] += errorVal.Message + Environment.NewLine;
                        errorEmail.Visible = true;
                        bunifuToolTip1.SetToolTip(errorEmail, message[1]);
                        break;
                    case "Phone":
                        message[2] += errorVal.Message + Environment.NewLine;
                        errorPhone.Visible = true;
                        bunifuToolTip1.SetToolTip(errorPhone, message[2]);
                        break;
                    case "Password":
                        message[3] += errorVal.Message + Environment.NewLine;
                        errorPassword.Visible = true;
                        bunifuToolTip1.SetToolTip(errorPassword, message[3]);
                        break;
                    case "Confirm":
                        message[4] += errorVal.Message + Environment.NewLine;
                        errorConfirm.Visible = true;
                        bunifuToolTip1.SetToolTip(errorConfirm, message[4]);
                        break;
                }
            }
            
        }

        private void passwordReg_TextChanged(object sender, EventArgs e)
        {
            errorPassword.Visible = false;
        }

        private void nameReg_TextChanged(object sender, EventArgs e)
        {
            errorName.Visible = false;
        }

        private void emailReg_TextChanged(object sender, EventArgs e)
        {
            errorEmail.Visible = false;
        }

        private void phoneReg_TextChanged(object sender, EventArgs e)
        {
            errorPhone.Visible = false;
        }

        private void confirmReg_TextChanged(object sender, EventArgs e)
        {
            errorConfirm.Visible = false;
        }
    }
}
