using AnalaizerClassLibrary;

namespace Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            AnalaizerClass.expression = "2+3";

            const string expectedResult = "5";

            var result = AnalaizerClass.Estimate();

            Assert.Equal(expectedResult, result);
        }
    }
}