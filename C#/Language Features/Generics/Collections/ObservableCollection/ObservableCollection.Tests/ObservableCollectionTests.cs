using System;
using System.Collections.ObjectModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ObservableCollection.Tests
{
    [TestClass]
    public class ObservableCollectionTests
    {
        [TestMethod]
        public void ObservableCollection_Initialization_Test()
        {
            ObservableCollection<string> colors = new ObservableCollection<string>()
            {
                "Red",
                "Green",
                "Blue"
            };

            colors.CollectionChanged += (s, e) =>
            {
                Console.WriteLine(e.Action);
            };

            colors.Add("Voilet");
            colors.Add("Black");
            colors.Remove("Voilet");
            Assert.IsTrue(colors.Count == 4);
        }
    }
}
