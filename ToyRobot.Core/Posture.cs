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

namespace ToyRobot.Core {
    public class Posture {
        private Position Position;
        private Direction Direction;

        public Posture(Position position, Direction direction) {
            Position = position;
            Direction = direction;
        }

        public bool CanMove() {
            switch(Direction) {
                case Direction.NORTH:
                    return Position.CanMoveNorth();
                case Direction.EAST:
                    return Position.CanMoveEast();
                case Direction.SOUTH:
                    return Position.CanMoveSouth();
                case Direction.WEST:
                    return Position.CanMoveWest();
                default:
                    //this will never happen.
                    return false;
            }
        }

        public void Move() {
            switch(Direction) {
                case Direction.NORTH:
                    Position.MoveNorth();
                    break;
                case Direction.EAST:
                    Position.MoveEast();
                    break;
                case Direction.SOUTH:
                    Position.MoveSouth();
                    break;
                case Direction.WEST:
                    Position.MoveWest();
                    break;
            }
        }

        public void TurnLeft() {
            switch(Direction) {
                case Direction.NORTH:
                    Direction = Direction.WEST;
                    break;
                case Direction.EAST:
                    Direction = Direction.NORTH;
                    break;
                case Direction.SOUTH:
                    Direction = Direction.EAST;
                    break;
                case Direction.WEST:
                    Direction = Direction.SOUTH;
                    break;
            }
        }

        public void TurnRight() {
            switch(Direction) {
                case Direction.NORTH:
                    Direction = Direction.EAST;
                    break;
                case Direction.EAST:
                    Direction = Direction.SOUTH;
                    break;
                case Direction.SOUTH:
                    Direction = Direction.WEST;
                    break;
                case Direction.WEST:
                    Direction = Direction.NORTH;
                    break;
            }
        }

        public override String ToString() {
            return String.Format("Output: {0},{1}", Position.ToString(), Direction);
        }

        public bool Equals(Posture other) {
            return Direction.Equals(other.Direction) &&
                   Position.Equals(other.Position);
        }
    }
}