using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ToyRobot.Core;

namespace ToyRobot.Test {
    public class ToyRobotTests {

        private MyToyRobot robot;
        
        [SetUp]
        public void Setup() {
            robot = new MyToyRobot();
        }

        [TearDown]
        public void Cleanup() {
            robot = null;
        }

        [Test]
        [TestCase(1, 2)]
        public void TestAddTwoNumbers(int a, int b) {
            int result = robot.AddTwoNumbers(a, b);
            Assert.AreEqual(3, result);
        }
    }
}