using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Value.Type.Constraints
{
    [TestClass]
    public class ValueTypeConstraintsTests
    {
        [TestMethod]
        public void ValueType_Int_Test()
        {
            var intTest = new ValueConstrainedType<int>();
            Assert.IsNotNull(intTest);

            var dateTimeTest = new ValueConstrainedType<DateTime>();
            Assert.IsNotNull(dateTimeTest);
        }

        [TestMethod]
        public void ValueTypeCollection_Int_Test()
        {
            var ints = new ValueConstrainedCollectionType<int>();
            ints.Add(1);
            ints.Add(2);
            ints.Add(3);
            Assert.IsNotNull(ints);

            var guids = new ValueConstrainedCollectionType<Guid>();
            guids.Add(new Guid());
            guids.Add(new Guid());
            guids.Add(new Guid());
            Assert.IsNotNull(guids);

            var dateTimes = new ValueConstrainedCollectionType<DateTime>();
            dateTimes.Add(new DateTime());
            dateTimes.Add(new DateTime().AddDays(10));
            Assert.IsNotNull(dateTimes);
        }

    }
}
