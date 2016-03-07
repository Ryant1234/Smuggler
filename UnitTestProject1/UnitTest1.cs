using System;
using System.Security.Cryptography.X509Certificates;
using WindowsFormsApplication4;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class RandomTest
    {
        [TestMethod]
        public void NumberGenerate() // Test to see if the number generate works
        {
            var test = new Smuggle();
            Random Random = new Random();
            test.RandomTurnNumber = Random.Next(1, 7);
            Assert.IsTrue(test.RandomTurnNumber >= 1 & test.RandomTurnNumber < 7);

        }

        [TestMethod] 
        public void MySmuggleWin()
        {
            var test = new Smuggle();
            test.Count = 2;          
            int Expectedcount = 2;
            Assert.AreEqual(Expectedcount, test.Count);

        }
    }
}






  