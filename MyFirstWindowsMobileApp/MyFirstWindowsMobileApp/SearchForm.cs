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
        public SearchForm()
        {
            InitializeComponent();
        }

        public new ViewDataDictionary<Products> ViewData { get; set; }

        protected override void OnUpdateView(string key)
        {
            if (key == "Category")
            {
                this.lblProductType.Text = this.ViewData.Model.ProductType;
            }
            if (key == "Products")
            {
                this.lstProducts.DataSource = this.ViewData.Model.ProductList;
            }
        }

        private void cmdSearch_Click(object sender, EventArgs e)
        {
            this.ViewData["Filter"] = txtSearch.Text;
            this.OnViewStateChanged("Search");
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