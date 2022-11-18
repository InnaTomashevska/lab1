﻿using Database;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using AnalaizerClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestEstimate1
{
    [TestClass]
    public class UnitTest2
    {


        [TestMethod]
        public void TestMethod2()
        {
            var optionsBuilder = new DbContextOptionsBuilder<MyDbContext>();
            optionsBuilder.UseSqlServer(@"Data Source=GWTN141-10;Initial Catalog=lab1;Trusted_Connection=True");
            using (MyDbContext context = new MyDbContext(optionsBuilder.Options))
            {
                var values_array = context.testingValues.ToList();
                AnalaizerClass.expression = values_array[0].Expresion;
                var expectedResult = AnalaizerClass.Estimate();
                Assert.AreEqual(expectedResult, values_array[0].ExprectedResult, "default test");
            }

        }
    }
}