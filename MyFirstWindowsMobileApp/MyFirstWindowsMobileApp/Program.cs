using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MyFirstWindowsMobileApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [MTAThread]
        static void Main()
        {
            SearchForm form = new SearchForm();
            SearchController controller = new SearchController(form);
            Application.Run(form);
        }
    }
}