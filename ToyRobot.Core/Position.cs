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
    public class Position {
        private int X;
        private int Y;

        public Position(int x, int y) {
            X = x;
            Y = y;
        }

        public bool CanMoveNorth() {
            return TheTable.IsNorthAvailable(Y);
        }

        public bool CanMoveEast() {
            return TheTable.IsEastAvailable(X);
        }

        public bool CanMoveSouth() {
            return TheTable.IsSouthAvailable(Y);
        }

        public bool CanMoveWest() {
            return TheTable.IsWestAvailable(X);
        }

        public void MoveNorth() {
            Y++;
        }

        public void MoveEast() {
            X++;
        }

        public void MoveSouth() {
            Y--;
        }

        public void MoveWest() {
            X--;
        }

        public override String ToString() {
            return String.Format("{0},{1}", X, Y);
        }

        public bool Equals(Position other) {
            return X == other.X && Y == other.Y;
        }
    }
}