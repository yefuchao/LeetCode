using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task_Scheduler;

namespace LeetCodeTest
{
    [TestClass]
    public class Task_SchedulerTest
    {
        [TestMethod]
        public void TestTaskScheduler()
        {
            char[] tasks = new char[] { 'A', 'A', 'A', 'B', 'B', 'B' };
            Assert.AreEqual(Program.LeastInterval(tasks, 2), tasks.Length + 2);
            //Assert.AreEqual(Program.LeastInterval(tasks, 4), tasks.Length + 2);
        }
    }
}
