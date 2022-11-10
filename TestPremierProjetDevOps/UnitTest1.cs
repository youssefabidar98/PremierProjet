using PremierProjetDevOps.Model;

namespace TestPremierProjetDevOps
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Person toto = new Person();
            toto.Name = "Boss";
            Assert.AreEqual(toto.Name, "Boss");
        }

        [TestMethod]
        public void TestMethod2()
        {
            Person toto = new Person();
            Assert.IsInstanceOfType(toto, typeof(Person));
        }
    }
}