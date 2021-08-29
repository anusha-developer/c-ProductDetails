using ProductDetails.BussinessManagerLayer;
using ProductDetails.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProductDetails.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2", "skilliceberg" };
        }
        [Route("api/Companyname")]
        public string GetcompanyName()
        {
            return "skilliceberg";
        }
        /*[Route("api/AllProducts")]
        public ProductModel Getproduct()
        {
            ProductModel products = new ProductModel();
            products.ProductId = 1;
            products.Productname = "Dell";
            products.Productfeatures = "8GB RAM 500GB";

            return products;
        }*/
        /*[Route("api/AllProductsdetails")]

        public List<ProductModel> GetAllProduct()
        {
            ProductBussinessManagerLayer product = new ProductBussinessManagerLayer();

            return product.GetProducts();

        }*/
            /*List<ProductModel> Products = new List<ProductModel>();
         ProductModel productObject = new ProductModel();
            for (int i = 1 ; i <= 100;i++)
             {
             productObject = new ProductModel();
                 productObject.ProductId = i;
                 productObject.Productname = "Acer" + i;
                 productObject.Productfeatures = "4GB RAM";
                 Products.Add(productObject);*/

            //return Products;
    
        /*[Route("allproducts")]
        
        public List<ProductModel> products = new List<ProductModel>();
        ProductModel productobject = new ProductModel();
        for( int i=1;i<=100;i++)
         {
        var data2 = new Products();
        data2.ProductId=i;
        data2.Productname="LENOVO"+i;
        data2.Productfeatures="32GB RAM 1T";
       this.ProductArray.push(data2)
    }*/

    // GET api/values/5
    public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
