using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReverseLinkedList;
using System.Collections.Generic;

namespace ReverseLinkedListTests
{
    [TestClass]
    public class ReversedSinglyLinkedListTests
    {
        [TestMethod]
        public void NoNodesReversedCorrectly()
        {
            var actual = new LinkedList(new List<int>()).Reverse().GetValues();
            var expected = new List<int>();
            CollectionAssert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void OneNodeReversedCorrectly()
        {
            var actual = new LinkedList(new List<int> { 1 }).Reverse().GetValues();
            var expected = new List<int> { 1 };
            CollectionAssert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void TwoNodesReversedCorrectly()
        {
            var actual = new LinkedList(new List<int> { 1, 2 }).Reverse().GetValues();
            var expected = new List<int> { 2, 1 };
            CollectionAssert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void ThreeNodesReversedCorrectly()
        {
            var actual = new LinkedList(new List<int> { 1, 2, 3 }).Reverse().GetValues();
            var expected = new List<int> { 3, 2, 1 };
            CollectionAssert.AreEqual(actual, expected);
        }
    }
}
