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

using Table.Core;
using System;

namespace ToyRobot.Core {
    public class Robot {
        public Posture CurrentPosture { get; set; }

        public Robot() {
            CurrentPosture = null;
        }

        public bool IsPlaced() {
            return CurrentPosture != null;
        }

        public void Place(int x, int y, Direction direction) {
            TheTable table = new TheTable();
            if(table.IsValidPosition(x, y)) {
                Position position = new Position(x, y);
                CurrentPosture = new Posture(position, direction);
            }
        }

        private bool CanMove() {
            TheTable board = new TheTable();
            switch(CurrentPosture.Direction) {
                case Direction.NORTH:
                    return CurrentPosture.Position.Y < board.YExtent - 1;
                case Direction.EAST:
                    return CurrentPosture.Position.X < board.XExtent - 1;
                case Direction.SOUTH:
                    return CurrentPosture.Position.Y > 0;
                case Direction.WEST:
                    return CurrentPosture.Position.X > 0;
                default:
                    //this will never happen.
                    return false;
            }
        }

        public void Move() {
            if(!IsPlaced()) {
                Console.WriteLine("Robot isn't placed on the table yet.");
            } else if(!CanMove()) {
                Console.WriteLine("Can't move in that direction.");
            } else {
                switch(CurrentPosture.Direction) {
                    case Direction.NORTH:
                        CurrentPosture.Position.Y++;
                        break;
                    case Direction.EAST:
                        CurrentPosture.Position.X++;
                        break;
                    case Direction.SOUTH:
                        CurrentPosture.Position.Y--;
                        break;
                    case Direction.WEST:
                        CurrentPosture.Position.X--;
                        break;
                }
            }
        }

        public void Turn(TurnTo turnTo) {
            if(IsPlaced()) {
                if(turnTo.Equals(TurnTo.LEFT)) {
                    TurnLeft();
                } else {
                    TurnRight();
                }
            }
        }

        private void TurnLeft() {
            switch(CurrentPosture.Direction) {
                case Direction.NORTH:
                    CurrentPosture.Direction = Direction.WEST;
                    break;
                case Direction.EAST:
                    CurrentPosture.Direction = Direction.NORTH;
                    break;
                case Direction.SOUTH:
                    CurrentPosture.Direction = Direction.EAST;
                    break;
                case Direction.WEST:
                    CurrentPosture.Direction = Direction.SOUTH;
                    break;
            }
        }

        private void TurnRight() {
            switch(CurrentPosture.Direction) {
                case Direction.NORTH:
                    CurrentPosture.Direction = Direction.EAST;
                    break;
                case Direction.EAST:
                    CurrentPosture.Direction = Direction.SOUTH;
                    break;
                case Direction.SOUTH:
                    CurrentPosture.Direction = Direction.WEST;
                    break;
                case Direction.WEST:
                    CurrentPosture.Direction = Direction.NORTH;
                    break;
            }
        }

        public String ReportPosture() {
            if(IsPlaced()) {
                return String.Format("Output: {0},{1},{2}",
                                     CurrentPosture.Position.X,
                                     CurrentPosture.Position.Y,
                                     CurrentPosture.Direction);
            } else {
                return String.Empty;
            }
        }
    }
}