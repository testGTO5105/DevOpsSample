using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SampleLibrary.Tests
{
    [TestClass]
    public class EvenDiscriminatorTest
    {
        [TestMethod]
        [DataRow(2,true)]
        [DataRow(3, false)]
        [DataRow(10, true)]
        [DataRow(11, false)]
        public void DiscriminateTest(int num, bool expected)
        {
            var actual = EvenDiscriminator.Discriminate(num);
            Assert.AreEqual(expected, actual);
        }
    }
}
