using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Mobile.Mvc;

namespace MyFirstWindowsMobileApp
{
    public class SearchController : Controller<Products>
    {
        public SearchController(IView<Products> view)
            : base(view)
        {
            Products products = new Products();
            products.PopulateList();
            this.view.ViewData.Model = products;
            this.view.UpdateView("Products");
        }

        protected override void OnViewStateChanged(string key)
        {
            switch (key)
            {
                case "Search":
                    string filter = this.view.ViewData["Filter"].ToString();
                    this.view.ViewData.Model.FilterData(filter);
                    this.view.UpdateView("Products");
                    break;
            }
        }
    }
}