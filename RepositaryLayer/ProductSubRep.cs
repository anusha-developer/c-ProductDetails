using ProductDetails.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductDetails.RepositaryLayer
{
    public class ProductSubRep
    {
        public ProductSubcat GetProductSubcat()
        {
            ProductSubcat productSubcat = new ProductSubcat();
            productSubcat.Id = 1;
            productSubcat.Name = "Women";
            productSubcat.maincategoryId = 1;

            return productSubcat;
        }
    }
}