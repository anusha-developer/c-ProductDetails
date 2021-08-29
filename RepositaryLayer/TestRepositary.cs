using ProductDetails.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductDetails.RepositaryLayer
{
    public class TestRepositary
    {
        public TestRepositary()
        {

        }
        public TestRepositary GetTestModel()
        {
            TestModel testModel = new TestModel();
            testModel.EmployeeId = 1;
            testModel.EmployeeName = "Anusha";
            testModel.EmployeeDesignation = "Developer";
            testModel.EmployeeSalary = 30000;
            return GetTestModel();
           
        }
    }
    

}