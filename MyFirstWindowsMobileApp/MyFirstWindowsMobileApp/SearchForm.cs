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
    public partial class SearchForm : ViewForm, IView<Products>
    {
        [PublishEvent("OnSearch")]
        public event EventHandler<DataEventArgs<string>> OnSearchEvent;

        public SearchForm()
        {
            InitializeComponent();
        }

        public new ViewDataDictionary<Products> ViewData { get; set; }

        private void OnProductsUpdated(Object sender, EventArgs e)
        {
            this.lblProductType.Text = this.ViewData.Model.ProductType;
            this.lstProducts.DataSource = this.ViewData.Model.ProductList;
        }

        private void cmdSearch_Click(object sender, EventArgs e)
        {
            if (OnSearchEvent != null)
            {
                OnSearchEvent(this, new DataEventArgs<string>(txtSearch.Text));
            }
        }

        #region IView<Products> Members

        private Products _products;

        public new Products Model
        {
            get
            {
                return _products;
            }
            set
            {
                _products = value;
            }
        }

        #endregion
    }
}