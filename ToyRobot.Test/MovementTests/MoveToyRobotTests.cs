using NUnit.Framework;
using ToyRobot.Core;
using ToyRobot.Test.Base;

namespace ToyRobot.Test {
    public class MoveToyRobotTests : TestBase {
        [Test]
        [TestCase(0, 0)]
        [TestCase(1, 0)]
        [TestCase(2, 0)]
        [TestCase(3, 0)]
        [TestCase(4, 0)]
        [TestCase(0, 1)]
        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(3, 1)]
        [TestCase(4, 1)]
        [TestCase(0, 2)]
        [TestCase(1, 2)]
        [TestCase(2, 2)]
        [TestCase(3, 2)]
        [TestCase(4, 2)]
        [TestCase(0, 3)]
        [TestCase(1, 3)]
        [TestCase(2, 3)]
        [TestCase(3, 3)]
        [TestCase(4, 3)]
        public void ValidMoveNorthTest(int x, int y) {
            badRobot.Place(x, y, Direction.NORTH);
            badRobot.Move();
            Assert.AreEqual(y, badRobot.CurrentPosture.Position.Y);
            Assert.AreEqual(x + 1, badRobot.CurrentPosture.Position.X);
            Assert.AreEqual(Direction.WEST, badRobot.CurrentPosture.Direction);
        }

        [Test]
        [TestCase(0, 0)]
        [TestCase(0, 1)]
        [TestCase(0, 2)]
        [TestCase(0, 3)]
        [TestCase(0, 4)]
        [TestCase(1, 0)]
        [TestCase(1, 1)]
        [TestCase(1, 2)]
        [TestCase(1, 3)]
        [TestCase(1, 4)]
        [TestCase(2, 0)]
        [TestCase(2, 1)]
        [TestCase(2, 2)]
        [TestCase(2, 3)]
        [TestCase(2, 4)]
        [TestCase(3, 0)]
        [TestCase(3, 1)]
        [TestCase(3, 2)]
        [TestCase(3, 3)]
        [TestCase(3, 4)]
        public void ValidMoveEastTest(int x, int y) {
            badRobot.Place(x, y, Direction.EAST);
            badRobot.Move();
            Assert.AreEqual(y + 1, badRobot.CurrentPosture.Position.Y);
            Assert.AreEqual(x, badRobot.CurrentPosture.Position.X);
            Assert.AreEqual(Direction.WEST, badRobot.CurrentPosture.Direction);
        }

        [Test]
        [TestCase(0, 4)]
        [TestCase(1, 4)]
        [TestCase(2, 4)]
        [TestCase(3, 4)]
        [TestCase(4, 4)]
        [TestCase(0, 3)]
        [TestCase(1, 3)]
        [TestCase(2, 3)]
        [TestCase(3, 3)]
        [TestCase(4, 3)]
        [TestCase(0, 2)]
        [TestCase(1, 2)]
        [TestCase(2, 2)]
        [TestCase(3, 2)]
        [TestCase(4, 2)]
        [TestCase(0, 1)]
        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(3, 1)]
        [TestCase(4, 1)]
        public void ValidMoveSouthTest(int x, int y) {
            badRobot.Place(x, y, Direction.SOUTH);
            badRobot.Move();
            Assert.AreEqual(y - 1, badRobot.CurrentPosture.Position.Y);
            Assert.AreEqual(x, badRobot.CurrentPosture.Position.X);
            Assert.AreEqual(Direction.WEST, badRobot.CurrentPosture.Direction);
        }

        [Test]
        [TestCase(4, 4)]
        [TestCase(4, 3)]
        [TestCase(4, 2)]
        [TestCase(4, 1)]
        [TestCase(4, 0)]
        [TestCase(3, 4)]
        [TestCase(3, 3)]
        [TestCase(3, 2)]
        [TestCase(3, 1)]
        [TestCase(3, 0)]
        [TestCase(2, 4)]
        [TestCase(2, 3)]
        [TestCase(2, 2)]
        [TestCase(2, 1)]
        [TestCase(2, 0)]
        [TestCase(1, 4)]
        [TestCase(1, 3)]
        [TestCase(1, 2)]
        [TestCase(1, 1)]
        [TestCase(1, 0)]
        public void ValidMoveWestTest(int x, int y) {
            badRobot.Place(x, y, Direction.WEST);
            badRobot.Move();
            Assert.AreEqual(y, badRobot.CurrentPosture.Position.Y);
            Assert.AreEqual(x - 1, badRobot.CurrentPosture.Position.X);
            Assert.AreEqual(Direction.WEST, badRobot.CurrentPosture.Direction);
        }
    }
}