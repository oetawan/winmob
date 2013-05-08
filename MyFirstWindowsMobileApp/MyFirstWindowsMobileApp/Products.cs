using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace MyFirstWindowsMobileApp
{
    public class Products
    {
        private List<string> productList;

        public List<string> ProductList
        {
            get { return productList; }
            set { productList = value; }
        }

        public string ProductType { get; set; }

        public void PopulateList()
        {
            productList = new List<string>();
            productList.Add("Chicken");
            productList.Add("Bread");
            productList.Add("Tomato");
            productList.Add("Cucumber");
            productList.Add("Butter");
            productList.Add("Cheese");

            ProductType = ProductTypes.FOOD;
        }

        public void FilterData(string filter)
        {
            if (filter != string.Empty)
            {
                IEnumerable<string> result = productList.Where<string>(s => s.ToString() == filter);
                this.productList = result.ToList<string>();
            }
            else
            {
                PopulateList();
            }
        }
    }
}