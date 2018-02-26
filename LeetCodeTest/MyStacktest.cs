using Microsoft.VisualStudio.TestTools.UnitTesting;
using My_Queue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTest
{
    [TestClass]
    public class MyStackTest
    {
        [TestMethod]
        public void TestMyStack()
        {
            MyStack stack = new MyStack();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Assert.AreEqual(stack.Pop(), 3);
            Assert.AreEqual(stack.Top(), 2);
            Assert.AreEqual(stack.Empty(), false);

        }
    }
}
