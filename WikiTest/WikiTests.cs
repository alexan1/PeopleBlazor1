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

        [TestMethod]
        public void GetPerson1()
        {
            var person = Wiki.GetWikiPerson(303).Result;

            Assert.IsNotNull(person);

            Assert.AreEqual("Elvis Presley", person.Name);
        }
    }
}
