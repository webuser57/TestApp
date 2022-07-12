using Microsoft.VisualStudio.TestTools.UnitTesting;
using VersionIncrementLib;

namespace VersionIncrementTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Feature_Test()
        {
            string _version = "1.0.1.1";
            string _expectedversion = "1.0.2.0";
            string _incrversion = VersionIncrementLib.VersionIncrement.UpdateVersion(RELEASETYPE.FEATURE, _version);

            Assert.IsNotNull(_incrversion);
            Assert.AreEqual(_incrversion, _expectedversion);
        }

        [TestMethod]
        public void BugFix_Test()
        {
            string _version = "1.0.1.1";
            string _expectedversion = "1.0.1.2";
            string _incrversion = VersionIncrementLib.VersionIncrement.UpdateVersion(RELEASETYPE.BUGFIX, _version);

            Assert.IsNotNull(_incrversion);
            Assert.AreEqual(_incrversion, _expectedversion);
        }  
    }
}
