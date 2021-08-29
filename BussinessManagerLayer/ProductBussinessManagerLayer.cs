using ProductDetails.Models;
using ProductDetails.RepositaryLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductDetails.BussinessManagerLayer
{
    public class ProductBussinessManagerLayer
    {
        public List<ProductModel> GetProducts()
        {
            ProductRepositorylayer productRepositorylayer = new ProductRepositorylayer();
            // List<ProductModel> Products = new List<ProductModel>();
            //Products = productRepositorylayer.GetProducts();
            return productRepositorylayer.GetProducts();
        }
    }
}