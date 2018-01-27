using System;
using System.Collections.Concurrent;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace ConcurrentDictionary.Collection.Tests
{
    [TestClass]
    public class ConcurrentDictionaryTests
    {
        [TestMethod]
        public void ConcurrentDictionary_TryAdd_Test()
        {
            var stock = new ConcurrentDictionary<string, int>();
            stock.TryAdd("Levis", 100);
            stock.TryAdd("Killer", 35);
            stock.TryAdd("Mufti", 75);

            Assert.IsTrue(stock.Count == 3);
        }

        [TestMethod]
        public void ConcurrentDictionary_AddDuplicate_Test()
        {
            var stock = new ConcurrentDictionary<string, int>();
            stock.TryAdd("Levis", 100);
            stock.TryAdd("Killer", 35);
            stock.TryAdd("Mufti", 75);

            var success = stock.TryAdd("Mufti", 100);

            Assert.IsFalse(success);
        }

        [TestMethod]
        public void ConcurrentDictionary_TryRemove_Test()
        {
            var stock = new ConcurrentDictionary<string, int>();
            stock.TryAdd("Levis", 100);
            stock.TryAdd("Killer", 35);
            stock.TryAdd("Mufti", 75);

            int levis;
            var levisRemoved = stock.TryRemove("Levis", out levis);

            Assert.IsTrue(stock.Count == 2);
            Assert.IsTrue(levisRemoved);
            Assert.IsTrue(levis == 100);
        }

        [TestMethod]
        public void ConcurrentDictionary_Remove_Missing_Item_Test()
        {
            var stock = new ConcurrentDictionary<string, int>();
            stock.TryAdd("Levis", 100);

            int unknown;
            bool isMissingItemRemoved = stock.TryRemove("Unknown Item", out unknown);

            Assert.IsTrue(stock.Count == 1);
            Assert.IsTrue(unknown == 0);
            Assert.IsFalse(isMissingItemRemoved);
        }


        [TestMethod]
        public void ConcurrentDictionary_TryUpdate_Test()
        {
            var stock = new ConcurrentDictionary<string, int>();
            stock.TryAdd("Levis", 100);
            stock.TryAdd("Killer", 35);
            stock.TryAdd("Mufti", 75);

            var update1 = stock.TryUpdate("Killer", 100, 35);
            Console.WriteLine("Killer stock count {0}", stock["Killer"]);
            Assert.IsTrue(update1);
            
            // Second call will fail since the comparison value was already updated to 100 during first call.
            // This might possible in multithreaded environment.
            var update2 = stock.TryUpdate("Killer", 100, 35);
            Console.WriteLine("Killer stock count {0}", stock["Killer"]);
            Assert.IsTrue(update2 == false);
        }

        [TestMethod]
        public void ConcurrentDictionary_AddOrUpdate_Test()
        {
            var stock = new ConcurrentDictionary<string, int>();
            stock.TryAdd("Levis", 100);
            stock.TryAdd("Killer", 35);
            stock.TryAdd("Mufti", 75);

            var localCount = stock.AddOrUpdate("Local", 1, (key, oldValue) => oldValue + 1);
            Assert.IsTrue(localCount == 1);

            var killerCount = stock.AddOrUpdate("Killer", 1, (key, oldValue) => oldValue + 1);
            var t1 = Task.Run(() =>
            {
                killerCount = stock.AddOrUpdate("Killer", 1, (key, oldValue) => oldValue + 1); 
            });
            var t2 = Task.Run(() =>
            {
                killerCount = stock.AddOrUpdate("Killer", 1, (key, oldValue) => oldValue + 1);
            });
            Task.WaitAll(t1, t2);

            Assert.IsTrue(killerCount == 38);
        }

        [TestMethod]
        public void ConcurrentDictionary_GetOrAdd_Test()
        {
            var stock = new ConcurrentDictionary<string, int>();
            stock.TryAdd("Levis", 100);
            stock.TryAdd("Killer", 35);
            stock.TryAdd("Mufti", 75);

            // GetorAdd method either gets the 'value' of provided 'key' item if it exists
            // If not, then it will add the new 'key-value' pair in the concurrent dictionary
            int localCount = stock.GetOrAdd("Local", 0);
            int levisCount = stock.GetOrAdd("Levis", 0);
            Assert.IsTrue(stock.Count == 4);
            Assert.IsTrue(stock["Local"] == 0);
            Assert.AreEqual(100, levisCount);
            Console.WriteLine("Local stock count {0}", localCount);
        }

        
    }
}
