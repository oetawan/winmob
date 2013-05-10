using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Mobile.Mvc;

namespace MyFirstWindowsMobileApp
{
    public partial class LoginForm : ViewForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        protected override void OnUpdateView(string key)
        {
            if (key == LoginEvents.STATUS)
            {
                this.lblStatus.Text = this.ViewData["Status"].ToString();
            }
        }

        private void menuLogin_Click(object sender, EventArgs e)
        {
            this.ViewData["UserId"] = txtUser.Text;
            this.ViewData["Password"] = txtPassword.Text;
            this.OnViewStateChanged(LoginEvents.LOGIN);
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            this.OnViewStateChanged(LoginEvents.EXIT);
        }
    }
}