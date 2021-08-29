using ProductDetails.Models;
using ProductDetails.RepositaryLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductDetails.BussinessManagerLayer
{
    public class ProductSubBussiness
    {
        public ProductSubcat GetProductSubcat()
        {
            ProductSubRep productSubRep = new ProductSubRep();
            return productSubRep.GetProductSubcat();


        }
    }
}