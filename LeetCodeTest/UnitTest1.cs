using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using My_Queue;

namespace LeetCodeTest
{
    [TestClass]
    public class MyQueueTest
    {
        [TestMethod]
        public void TestMyQueue()
        {
            MyQueue queue = new MyQueue();

            queue.Push(1);
            queue.Push(2);
            queue.Push(3);

            Assert.AreEqual(queue.Pop(), 1);
            Assert.AreEqual(queue.Peek(), 2);
            Assert.AreEqual(queue.Empty(), false);
        }
    }
}
