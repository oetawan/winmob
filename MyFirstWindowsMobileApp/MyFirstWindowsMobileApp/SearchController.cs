using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Mobile.Mvc;

namespace MyFirstWindowsMobileApp
{
    public class SearchController : Controller<Products>
    {
        [PublishEvent("OnProductsUpdated")]
        public event EventHandler ProductUpdated;
        
        public SearchController(IView<Products> view)
            : base(view)
        {
            Products products = new Products();
            products.PopulateList();
            this.view.ViewData.Model = products;
            NotifyView();
        }

        private void OnSearch(Object sender, DataEventArgs<string> e)
        {
            this.view.ViewData.Model.FilterData(e.Value);
            NotifyView();
        }

        private void NotifyView()
        {
            if (this.ProductUpdated != null)
            {
                this.ProductUpdated(this, EventArgs.Empty);
            }
        }
    }
}