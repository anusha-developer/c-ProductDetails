using ProductDetails.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductDetails.RepositaryLayer
{
    public class ProductRepositorylayer
    {
        public List<ProductModel> GetProducts()
        {
            List<ProductModel> Products = new List<ProductModel>();
            ProductModel productObject = new ProductModel();
            for (int i = 1; i <= 100; i++)
            {
                productObject = new ProductModel();
                productObject.ProductId = i;
                productObject.Productname = "Acer" + i;
                productObject.Productfeatures = "4GB RAM";
                Products.Add(productObject);
            }
            return Products;
        }
    }
}