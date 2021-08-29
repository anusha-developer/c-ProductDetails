using ProductDetails.Models;
using ProductDetails.RepositaryLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductDetails.BussinessManagerLayer
{
    public class TestControllerBussiness
    {
        public TestControllerBussiness()
        {

        }
        public TestModel GetTestModel()
        {


            TestRepositary test = new TestRepositary();
            return test.GetTestModel();
        }
       
             
    }
}