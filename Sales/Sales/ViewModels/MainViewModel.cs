namespace Sales.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class MainViewModel
    {
        #region Attributes

        #endregion

        #region Properties
        public ProductsViewModel Products { get; set; }
        #endregion

        public MainViewModel()
        {
            this.Products = new ProductsViewModel();
        }
    }
}
