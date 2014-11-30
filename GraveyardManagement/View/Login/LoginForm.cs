using System;
using System.Windows.Forms;
using GraveyardManagement.Controller;
using GraveyardManagement.Global;

namespace GraveyardManagement.View.Login
{
    public partial class LoginForm : Form
    {
        private readonly ILoginService loginService;

        public LoginForm()
        {
            InitializeComponent();
            loginService = new LoginMock(); // TODO: asta trebuie schimbat cu un serviciu autentic ... candva
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            var username = txt_Username.Text.Trim();
            var password = txt_Password.Text.Trim();
            txt_Password.Text = "";

            var user = loginService.Login(username, password); 

            if (user == null)
            {
                lbl_LoginError.Show();
            }
            else
            {
                lbl_LoginError.Hide();
                GlobalVariables.CurrentUser = user; // clasa statica, in folderul Global

                // TODO: apelat formul principal
                this.Hide();

                var mainForm = new MainForm();
                mainForm.ShowDialog();

                this.Dispose();
            }
        }
    }
}
