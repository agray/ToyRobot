#region Licence
/*
 * The MIT License
 *
 * Copyright (c) 2014, Andrew Gray
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in
 * all copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 * THE SOFTWARE.
 */
#endregion

using NUnit.Framework;
using ToyRobot.Core;
using ToyRobot.Test.Base;

namespace ToyRobot.Test.MovementTests {
    public class ToyRobotMovementTests : TestBase {
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
            BadRobot.Place(x, y, Direction.NORTH);
            BadRobot.Move();
            Posture expectedPosture = new Posture(new Position(x, y + 1), Direction.NORTH);
            Assert.IsTrue(BadRobot.ZenLike(expectedPosture));
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
            BadRobot.Place(x, y, Direction.EAST);
            BadRobot.Move();
            Posture expectedPosture = new Posture(new Position(x + 1, y), Direction.EAST);
            Assert.IsTrue(BadRobot.ZenLike(expectedPosture));
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
            BadRobot.Place(x, y, Direction.SOUTH);
            BadRobot.Move();
            Posture expectedPosture = new Posture(new Position(x, y - 1), Direction.SOUTH);
            Assert.IsTrue(BadRobot.ZenLike(expectedPosture));
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
            BadRobot.Place(x, y, Direction.WEST);
            BadRobot.Move();
            Posture expectedPosture = new Posture(new Position(x - 1, y), Direction.WEST);
            Assert.IsTrue(BadRobot.ZenLike(expectedPosture));
        }

        [Test]
        [TestCase(0, 4)]
        [TestCase(1, 4)]
        [TestCase(2, 4)]
        [TestCase(3, 4)]
        [TestCase(4, 4)]
        public void InvalidMoveNorthTest(int x, int y) {
            BadRobot.Place(x, y, Direction.NORTH);
            BadRobot.Move();
            Posture expectedPosture = new Posture(new Position(x, y), Direction.NORTH);
            Assert.IsTrue(BadRobot.ZenLike(expectedPosture));
        }

        [Test]
        [TestCase(4, 0)]
        [TestCase(4, 1)]
        [TestCase(4, 2)]
        [TestCase(4, 3)]
        [TestCase(4, 4)]
        public void InvalidMoveEastTest(int x, int y) {
            BadRobot.Place(x, y, Direction.EAST);
            BadRobot.Move();
            Posture expectedPosture = new Posture(new Position(x, y), Direction.EAST);
            Assert.IsTrue(BadRobot.ZenLike(expectedPosture));
        }

        [Test]
        [TestCase(0, 0)]
        [TestCase(1, 0)]
        [TestCase(2, 0)]
        [TestCase(3, 0)]
        [TestCase(4, 0)]
        public void InvalidMoveSouthTest(int x, int y) {
            BadRobot.Place(x, y, Direction.SOUTH);
            BadRobot.Move();
            Posture expectedPosture = new Posture(new Position(x, y), Direction.SOUTH);
            Assert.IsTrue(BadRobot.ZenLike(expectedPosture));
        }

        [Test]
        [TestCase(0, 0)]
        [TestCase(0, 1)]
        [TestCase(0, 2)]
        [TestCase(0, 3)]
        [TestCase(0, 4)]
        public void InvalidMoveWestTest(int x, int y) {
            BadRobot.Place(x, y, Direction.WEST);
            BadRobot.Move();
            Posture expectedPosture = new Posture(new Position(x, y), Direction.WEST);
            Assert.IsTrue(BadRobot.ZenLike(expectedPosture));
        }
    }
}