using Tyuiu.TatarinovDA.Sprint0.Task2.V0.Lib;
namespace Tyuiu.TatarinovDA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Данил";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет..., Данил", res);
        }
    }
}
