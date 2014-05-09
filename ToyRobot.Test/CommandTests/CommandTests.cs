using NUnit.Framework;
using System;
using ToyRobot.Core;
using ToyRobot.Test.Base;

namespace ToyRobot.Test.CommandTests {
    public class CommandTests : TestBase {
        [Test]
        public void IgnoreMoveWhenUnplaced() {
            badRobot.Move();
            Assert.AreEqual(null, badRobot.CurrentPosture);
        }

        [Test]
        public void IgnoreTurnLeftWhenUnplaced() {
            badRobot.Turn(TurnTo.LEFT);
            Assert.AreEqual(null, badRobot.CurrentPosture);
        }

        [Test]
        public void IgnoreTurnRightWhenUnplaced() {
            badRobot.Turn(TurnTo.RIGHT);
            Assert.AreEqual(null, badRobot.CurrentPosture);
        }

        [Test]
        public void IgnoreReportWhenUnplaced() {
            String report = badRobot.ReportPosture();
            Assert.AreEqual(String.Empty, report);
        }
    }
}
