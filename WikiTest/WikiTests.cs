using Microsoft.VisualStudio.TestTools.UnitTesting;
using WikiLib;

namespace WikiTest
{
    [TestClass]
    public class WikiTests
    {
        [TestMethod]
        public void WikiSearch1()
        {
            var people = Wiki.WikiSearch("Pope");

            Assert.AreNotEqual(0, people.Result.Count);

        }
    }
}
