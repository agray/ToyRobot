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

namespace ToyRobot.Test.CommandTests {
    public class CommandTests : TestBase {
        [Test]
        public void IgnoreMoveWhenUnplaced() {
            BadRobot.Move();
            Assert.IsFalse(BadRobot.IsPlaced());
        }

        [Test]
        public void IgnoreTurnLeftWhenUnplaced() {
            BadRobot.Turn(TurnTo.LEFT);
            Assert.IsFalse(BadRobot.IsPlaced());
        }

        [Test]
        public void IgnoreTurnRightWhenUnplaced() {
            BadRobot.Turn(TurnTo.RIGHT);
            Assert.IsFalse(BadRobot.IsPlaced());
        }

        [Test]
        public void IgnoreReportWhenUnplaced() {
            String report = BadRobot.ReportPosture();
            Assert.AreEqual(String.Empty, report);
        }
    }
}
