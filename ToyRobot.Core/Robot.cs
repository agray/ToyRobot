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

using System;
using Table.Core;

namespace ToyRobot.Core {
    public class Robot {
        private Posture CurrentPosture;

        public Robot() {
            CurrentPosture = null;
        }

        public bool IsPlaced() {
            return CurrentPosture != null;
        }

        public bool ZenLike(Posture other) {
            return CurrentPosture.Equals(other);
        }

        public void Place(int x, int y, Direction direction) {
            if(TheTable.IsValidPosition(x, y)) {
                Position position = new Position(x, y);
                CurrentPosture = new Posture(position, direction);
            }
        }

        public String ReportPosture() {
            return IsPlaced() ? CurrentPosture.ToString() : String.Empty;
        }

        public void Move() {
            if(IsPlaced() && CurrentPosture.CanMove()) {
                CurrentPosture.Move();
            }
        }

        public void Turn(TurnTo turnTo) {
            if(IsPlaced()) {
                if(turnTo.Equals(TurnTo.LEFT)) {
                    CurrentPosture.TurnLeft();
                } else {
                    CurrentPosture.TurnRight();
                }
            }
        }
    }
}