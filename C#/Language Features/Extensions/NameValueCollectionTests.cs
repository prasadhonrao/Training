using Extensions.Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Specialized;

namespace Extensions
{
    [TestClass]
    public class NameValueCollectionTests
    {
        [TestMethod]
        public void ToInt_Valid_Input_Test()
        {
            var collection = new NameValueCollection();
            collection.Add("name", "prasad");
            collection.Add("job", "programmer");
            var result = collection.ToQueryString();
            Assert.IsTrue(result == "name=prasad&job=programmer");
        }
    }
}
