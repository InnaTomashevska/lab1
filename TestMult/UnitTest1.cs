using CalcClassBr;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestMult
{
    [TestClass]
    public class UnitTest1
    {
      
        long a, b;
        int ExpectedResult;
        public TestContext TestContext { get; set; }
        [DataSource(
            "System.Data.SqlClient",
            @"Data Source=GWTN141-10;Initial Catalog=lab1;Trusted_Connection=True",
            "TestMult",
            DataAccessMethod.Sequential
            )]
        [TestMethod]
        public void mult()
        {
            a = Int32.Parse(TestContext.DataRow.Table.Rows[0][1].ToString());
            b = Int32.Parse(TestContext.DataRow.Table.Rows[0][2].ToString());
            ExpectedResult = Int32.Parse(TestContext.DataRow.Table.Rows[0][3].ToString());
            int ActionResult = CalcClass.Mult(a, b);

            try
            {
                Assert.AreEqual(ExpectedResult, ActionResult);
            } catch 
            {
                System.Console.WriteLine("eror in");
            }
        }
        [DataSource(
            "System.Data.SqlClient",
            @"Data Source=GWTN141-10;Initial Catalog=lab1;Trusted_Connection=True",
            "TestMult",
            DataAccessMethod.Sequential
            )]
        [TestMethod]
        public void mult2()
        {
            a = Int32.Parse(TestContext.DataRow.Table.Rows[1][1].ToString());
            b = Int32.Parse(TestContext.DataRow.Table.Rows[1][2].ToString());
            ExpectedResult = Int32.Parse(TestContext.DataRow.Table.Rows[1][3].ToString());
            int ActionResult = CalcClass.Mult(a, b);

            try
            {
                Assert.AreEqual(ExpectedResult, ActionResult);
            } catch 
            {
                System.Console.WriteLine("eror in");
            }
        }
        [DataSource(
            "System.Data.SqlClient",
            @"Data Source=GWTN141-10;Initial Catalog=lab1;Trusted_Connection=True",
            "TestMult",
            DataAccessMethod.Sequential
            )]
        [TestMethod]
        public void multWithZero()
        {
            a = Int32.Parse(TestContext.DataRow.Table.Rows[2][1].ToString());
            b = Int32.Parse(TestContext.DataRow.Table.Rows[2][2].ToString());
            ExpectedResult = Int32.Parse(TestContext.DataRow.Table.Rows[2][3].ToString());
            int ActionResult = CalcClass.Mult(a, b);

            try
            {
                Assert.AreEqual(ExpectedResult, ActionResult);
            } catch 
            {
                System.Console.WriteLine("eror in");
            }
        }
        [DataSource(
            "System.Data.SqlClient",
            @"Data Source=GWTN141-10;Initial Catalog=lab1;Trusted_Connection=True",
            "TestMult",
            DataAccessMethod.Sequential
            )]
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void multWithLeftRange()
        {
            a = Int32.Parse(TestContext.DataRow.Table.Rows[3][1].ToString());
            b = Int32.Parse(TestContext.DataRow.Table.Rows[3][2].ToString());
            ExpectedResult = Int32.Parse(TestContext.DataRow.Table.Rows[3][3].ToString());
            int ActionResult = CalcClass.Mult(a, b);

            try
            {
                Assert.AreEqual(ExpectedResult, ActionResult);
            } catch 
            {
                System.Console.WriteLine("eror in");
            }
        }
        [DataSource(
            "System.Data.SqlClient",
            @"Data Source=GWTN141-10;Initial Catalog=lab1;Trusted_Connection=True",
            "TestMult",
            DataAccessMethod.Sequential
            )]
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void multWithRightRange()
        {
            a = Int32.Parse(TestContext.DataRow.Table.Rows[4][1].ToString());
            b = Int32.Parse(TestContext.DataRow.Table.Rows[4][2].ToString());
            ExpectedResult = Int32.Parse(TestContext.DataRow.Table.Rows[4][3].ToString());
            int ActionResult = CalcClass.Mult(a, b);

            try
            {
                Assert.AreEqual(ExpectedResult, ActionResult);
            } catch 
            {
                System.Console.WriteLine("eror in");
            }
        }
    }
}
