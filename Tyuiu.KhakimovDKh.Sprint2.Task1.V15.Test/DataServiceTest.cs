using Tyuiu.KhakimovDKh.Sprint2.Task1.V15.Lib;
namespace Tyuiu.KhakimovDKh.Sprint2.Task1.V15.Test
{

    [TestClass]
    public class DataServiceTest
    {                                                                    
        [TestMethod]
        public void VoidExpression()
        {
            DataService ds = new DataService();

            int a = 415;
            int b = 616;
            int c = 134;
            int d = 127;

            bool[] bools = new bool[] { true, false, true, false, true, false };
            var res = ds.GetLogicOperations(a, b, c, d);
            CollectionAssert.AreEqual(bools, res);
        }
    }
}
