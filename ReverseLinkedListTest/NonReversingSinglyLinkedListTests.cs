using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReverseLinkedList;
using System.Collections.Generic;

namespace ReverseLinkedListTests
{
    [TestClass]
    public class NonReversingSinglyLinkedListTests
    {
        [TestMethod]
        public void NoNodesOk()
        {
            var actual = new LinkedList().GetValues();
            var expected = new List<int> { };
            CollectionAssert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void OneNodeOk()
        {
            var actual = new LinkedList(new List<int> { 1 }).GetValues();
            var expected = new List<int> { 1 };
            CollectionAssert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void TwoNodesOk()
        {
            var actual = new LinkedList(new List<int> { 1, 2 }).GetValues();
            var expected = new List<int> { 1, 2 };
            CollectionAssert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void ThreeNodesOk()
        {
            var actual = new LinkedList(new List<int> { 1, 2, 3 }).GetValues();
            var expected = new List<int> { 1, 2, 3 };
            CollectionAssert.AreEqual(actual, expected);
        }
    }
}
