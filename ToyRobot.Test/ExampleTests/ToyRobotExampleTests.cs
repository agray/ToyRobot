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
using System;
using ToyRobot.Core;
using ToyRobot.Test.Base;

namespace ToyRobot.Test.ExampleTests {
    public class ToyRobotExampleTests : TestBase {
        [Test]
        public void ExampleTestA() {
            String report = String.Empty;
            BadRobot.Place(0, 0, Direction.NORTH);
            BadRobot.Move();
            report = BadRobot.ReportPosture();
            Assert.AreEqual("Output: 0,1,NORTH", report);
        }

        [Test]
        public void ExampleTestB() {
            String report = String.Empty;
            BadRobot.Place(0, 0, Direction.NORTH);
            BadRobot.Turn(TurnTo.LEFT);
            report = BadRobot.ReportPosture();
            Assert.AreEqual("Output: 0,0,WEST", report);
        }

        [Test]
        public void ExampleTestC() {
            String report = String.Empty;
            BadRobot.Place(1, 2, Direction.EAST);
            BadRobot.Move();
            BadRobot.Move();
            BadRobot.Turn(TurnTo.LEFT);
            BadRobot.Move();
            report = BadRobot.ReportPosture();
            Assert.AreEqual("Output: 3,3,NORTH", report);
        }
    }
}