using NUnit.Framework;
using System;
using ToyRobot.Core;
using ToyRobot.Test.Base;

namespace ToyRobot.Test.ExampleTests {
    public class ExampleTests : TestBase {
        [Test]
        public void ExampleTestA() {
            string report = String.Empty;
            badRobot.Place(0, 0, Direction.NORTH);
            badRobot.Move();
            report = badRobot.ReportPosture();
            Assert.AreEqual("Output: 0,1,NORTH", report);
        }

        [Test]
        public void ExampleTestB() {
            string report = String.Empty;
            badRobot.Place(0, 0, Direction.NORTH);
            badRobot.Turn(TurnTo.LEFT);
            report = badRobot.ReportPosture();
            Assert.AreEqual("Output: 0,0,WEST", report);
        }

        [Test]
        public void ExampleTestC() {
            string report = String.Empty;
            badRobot.Place(1, 2, Direction.EAST);
            badRobot.Move();
            badRobot.Move();
            badRobot.Turn(TurnTo.LEFT);
            badRobot.Move();
            report = badRobot.ReportPosture();
            Assert.AreEqual("Output: 3,3,NORTH", report);
        }
    }
}
