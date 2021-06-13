using HareGame.Game;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace HareGameTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Player player = PlayerFactory.GetInstance(10);
            Assert.AreEqual(player == null, true);
        }
    }
}
