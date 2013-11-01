using NUnit.Framework;

namespace NUnitWithInheritanceDemo
{
    [TestFixture]
    public class Implementation : Base
    {
        [TestFixtureSetUp]
        public void OncePerClassSetupPerClass()
        {
            MyWriter.WriteLine("\tImplementation - Setup - Once per class");
        }

        [TestFixtureTearDown]
        public void OncePerClassTeardownPerClass()
        {
            MyWriter.WriteLine("\tImplementation - Teardown - Once per class");
        }

        [SetUp]
        public void BeforeTest()
        {
            MyWriter.WriteLine("\t\tImplementation - Setup - once per test");
        }

        [TearDown]
        public void AfterTest()
        {
            MyWriter.WriteLine("\t\tImplementation - Teardown - once per test");
        }
        
        [Test]
        public void T1()
        {
            MyWriter.WriteLine("\t\t\tTest1");
        }
        [Test]
        public void T2()
        {
            MyWriter.WriteLine("\t\t\tTest2");
        }
    }
}