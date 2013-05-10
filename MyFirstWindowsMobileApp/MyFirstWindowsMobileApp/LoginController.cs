using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Mobile.Mvc;
using System.Windows.Forms;

namespace MyFirstWindowsMobileApp
{
    public class LoginController: Controller
    {
        public LoginController(IView view)
            : base(view)
        {

        }

        protected override void OnViewStateChanged(string key)
        {
            if (key == LoginEvents.LOGIN)
            {
                if (view.ViewData["UserId"].ToString() == "Alex" &&
                   view.ViewData["Password"].ToString() == "password")
                {
                    this.view.ViewData["Status"] = "Login succedded.";
                }
                else
                {
                    this.view.ViewData["Status"] = "Login failed.";
                }
                this.view.UpdateView("Status");
            }
            else if (key == LoginEvents.EXIT)
            {
                Application.Exit();
            }
        }
    }
}