﻿using Table.Core;
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
                Console.WriteLine("Robot isn't placed on the board yet.");
            } else if(!CanMove()) {
                Console.WriteLine("Can't move in that direction.");
            } else {
                switch(CurrentPosture.Direction) {
                    case Direction.NORTH:
                        CurrentPosture.Position.Y += 1;
                        break;
                    case Direction.EAST:
                        CurrentPosture.Position.X += 1;
                        break;
                    case Direction.SOUTH:
                        CurrentPosture.Position.Y -= 1;
                        break;
                    case Direction.WEST:
                        CurrentPosture.Position.X -= 1;
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

        public void Report() {
            if(!IsPlaced()) {
                Console.WriteLine(String.Format("Output: {0},{1},{2}",
                                                CurrentPosture.Position.X,
                                                CurrentPosture.Position.Y,
                                                CurrentPosture.Direction));
            }
        }

        //public int AddTwoNumbers(int a, int b) {
        //    return a + b;
        //}
    }
}