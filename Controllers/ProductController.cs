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
    public class ProductController : ApiController
    {

        [Route("api/Products")]
        public ProductModel Getproduct()
        {
            ProductModel products = new ProductModel();
            products.ProductId = 1;
            products.Productname = "Dell";
            products.Productfeatures = "8GB RAM 500GB";

            return products;
        }

       
        [Route("api/AllProducts")]

        public List<ProductModel> GetAllProduct()
        {
            ProductBussinessManagerLayer product = new ProductBussinessManagerLayer();
            List<ProductModel> products = new List<ProductModel>();
            products = product.GetProducts();
            return products;

        }// GET: api/Product
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Product/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Product
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Product/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Product/5
        public void Delete(int id)
        {
        }
    }
}
