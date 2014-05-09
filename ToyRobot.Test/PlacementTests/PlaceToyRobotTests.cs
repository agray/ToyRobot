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

namespace ToyRobot.Test.PlacementTests {
    public class PlaceToyRobotTests : TestBase {
        [Test]
        [TestCase(0, 0, Direction.NORTH)]
        [TestCase(0, 0, Direction.EAST)]
        [TestCase(0, 0, Direction.SOUTH)]
        [TestCase(0, 0, Direction.WEST)]
        [TestCase(0, 1, Direction.NORTH)]
        [TestCase(0, 1, Direction.EAST)]
        [TestCase(0, 1, Direction.SOUTH)]
        [TestCase(0, 1, Direction.WEST)]
        [TestCase(0, 2, Direction.NORTH)]
        [TestCase(0, 2, Direction.EAST)]
        [TestCase(0, 2, Direction.SOUTH)]
        [TestCase(0, 2, Direction.WEST)]
        [TestCase(0, 3, Direction.NORTH)]
        [TestCase(0, 3, Direction.EAST)]
        [TestCase(0, 3, Direction.SOUTH)]
        [TestCase(0, 3, Direction.WEST)]
        [TestCase(0, 4, Direction.NORTH)]
        [TestCase(0, 4, Direction.EAST)]
        [TestCase(0, 4, Direction.SOUTH)]
        [TestCase(0, 4, Direction.WEST)]
        [TestCase(1, 0, Direction.NORTH)]
        [TestCase(1, 0, Direction.EAST)]
        [TestCase(1, 0, Direction.SOUTH)]
        [TestCase(1, 0, Direction.WEST)]
        [TestCase(1, 1, Direction.NORTH)]
        [TestCase(1, 1, Direction.EAST)]
        [TestCase(1, 1, Direction.SOUTH)]
        [TestCase(1, 1, Direction.WEST)]
        [TestCase(1, 2, Direction.NORTH)]
        [TestCase(1, 2, Direction.EAST)]
        [TestCase(1, 2, Direction.SOUTH)]
        [TestCase(1, 2, Direction.WEST)]
        [TestCase(1, 3, Direction.NORTH)]
        [TestCase(1, 3, Direction.EAST)]
        [TestCase(1, 3, Direction.SOUTH)]
        [TestCase(1, 3, Direction.WEST)]
        [TestCase(1, 4, Direction.NORTH)]
        [TestCase(1, 4, Direction.EAST)]
        [TestCase(1, 4, Direction.SOUTH)]
        [TestCase(1, 4, Direction.WEST)]
        [TestCase(2, 0, Direction.NORTH)]
        [TestCase(2, 0, Direction.EAST)]
        [TestCase(2, 0, Direction.SOUTH)]
        [TestCase(2, 0, Direction.WEST)]
        [TestCase(2, 1, Direction.NORTH)]
        [TestCase(2, 1, Direction.EAST)]
        [TestCase(2, 1, Direction.SOUTH)]
        [TestCase(2, 1, Direction.WEST)]
        [TestCase(2, 2, Direction.NORTH)]
        [TestCase(2, 2, Direction.EAST)]
        [TestCase(2, 2, Direction.SOUTH)]
        [TestCase(2, 2, Direction.WEST)]
        [TestCase(2, 3, Direction.NORTH)]
        [TestCase(2, 3, Direction.EAST)]
        [TestCase(2, 3, Direction.SOUTH)]
        [TestCase(2, 3, Direction.WEST)]
        [TestCase(2, 4, Direction.NORTH)]
        [TestCase(2, 4, Direction.EAST)]
        [TestCase(2, 4, Direction.SOUTH)]
        [TestCase(2, 4, Direction.WEST)]
        [TestCase(3, 0, Direction.NORTH)]
        [TestCase(3, 0, Direction.EAST)]
        [TestCase(3, 0, Direction.SOUTH)]
        [TestCase(3, 0, Direction.WEST)]
        [TestCase(3, 1, Direction.NORTH)]
        [TestCase(3, 1, Direction.EAST)]
        [TestCase(3, 1, Direction.SOUTH)]
        [TestCase(3, 1, Direction.WEST)]
        [TestCase(3, 2, Direction.NORTH)]
        [TestCase(3, 2, Direction.EAST)]
        [TestCase(3, 2, Direction.SOUTH)]
        [TestCase(3, 2, Direction.WEST)]
        [TestCase(3, 3, Direction.NORTH)]
        [TestCase(3, 3, Direction.EAST)]
        [TestCase(3, 3, Direction.SOUTH)]
        [TestCase(3, 3, Direction.WEST)]
        [TestCase(3, 4, Direction.NORTH)]
        [TestCase(3, 4, Direction.EAST)]
        [TestCase(3, 4, Direction.SOUTH)]
        [TestCase(3, 4, Direction.WEST)]
        [TestCase(4, 0, Direction.NORTH)]
        [TestCase(4, 0, Direction.EAST)]
        [TestCase(4, 0, Direction.SOUTH)]
        [TestCase(4, 0, Direction.WEST)]
        [TestCase(4, 1, Direction.NORTH)]
        [TestCase(4, 1, Direction.EAST)]
        [TestCase(4, 1, Direction.SOUTH)]
        [TestCase(4, 1, Direction.WEST)]
        [TestCase(4, 2, Direction.NORTH)]
        [TestCase(4, 2, Direction.EAST)]
        [TestCase(4, 2, Direction.SOUTH)]
        [TestCase(4, 2, Direction.WEST)]
        [TestCase(4, 3, Direction.NORTH)]
        [TestCase(4, 3, Direction.EAST)]
        [TestCase(4, 3, Direction.SOUTH)]
        [TestCase(4, 3, Direction.WEST)]
        [TestCase(4, 4, Direction.NORTH)]
        [TestCase(4, 4, Direction.EAST)]
        [TestCase(4, 4, Direction.SOUTH)]
        [TestCase(4, 4, Direction.WEST)]
        public void ValidPlacementTest(int x, int y, Direction direction) {
            badRobot.Place(x, y, direction);
            Assert.AreEqual(x, badRobot.CurrentPosture.Position.X);
            Assert.AreEqual(y, badRobot.CurrentPosture.Position.Y);
            Assert.AreEqual(direction, badRobot.CurrentPosture.Direction);
        }

        [Test]
        [TestCase(-1, 0, Direction.NORTH)]
        [TestCase(-1, 0, Direction.EAST)]
        [TestCase(-1, 0, Direction.SOUTH)]
        [TestCase(-1, 0, Direction.WEST)]
        [TestCase(0, -1, Direction.NORTH)]
        [TestCase(0, -1, Direction.EAST)]
        [TestCase(0, -1, Direction.SOUTH)]
        [TestCase(0, -1, Direction.WEST)]
        [TestCase(5, 0, Direction.NORTH)]
        [TestCase(5, 0, Direction.EAST)]
        [TestCase(5, 0, Direction.SOUTH)]
        [TestCase(5, 0, Direction.WEST)]
        [TestCase(0, 5, Direction.NORTH)]
        [TestCase(0, 5, Direction.EAST)]
        [TestCase(0, 5, Direction.SOUTH)]
        [TestCase(0, 5, Direction.WEST)]
        public void InvalidPlacementTest(int x, int y, Direction direction) {
            badRobot.Place(x, y, direction);
            Assert.AreEqual(null, badRobot.CurrentPosture);
        }
    }
}