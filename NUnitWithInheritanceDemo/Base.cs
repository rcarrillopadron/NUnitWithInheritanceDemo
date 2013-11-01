using NUnit.Framework;

namespace NUnitWithInheritanceDemo
{
    [TestFixture]
    public abstract class Base
    {
        [TestFixtureSetUp]
        public void OncePerClassSetupBase()
        {
            MyWriter.WriteLine("Base class - Setup - Once per class");
        }

        [TestFixtureTearDown]
        public void OncePerClassTeardownBase()
        {
            MyWriter.WriteLine("Base class - Teardown - Once per class");
        }
    }
}