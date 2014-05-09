using Board.Core;
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
            TheBoard board = new TheBoard();
            if(board.IsValidPosition(x, y)) {
                Position position = new Position(x, y);
                CurrentPosture = new Posture(position, direction);
            }
        }

        private bool CanMove() {
            TheBoard board = new TheBoard();
            switch(CurrentPosture.Direction) {
                case Direction.NORTH:
                    return CurrentPosture.Position.X < board.XExtent - 1;
                case Direction.EAST:
                    return CurrentPosture.Position.Y < board.YExtent - 1;
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
            if(!CanMove()) {
                Console.WriteLine("Can't move in that direction");
            } else {
                switch(CurrentPosture.Direction) {
                    case Direction.NORTH:
                        CurrentPosture.Position.X++;
                        break;
                    case Direction.EAST:
                        CurrentPosture.Position.Y++;
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
            if(turnTo.Equals(TurnTo.LEFT)) {
                TurnLeft();
            } else {
                TurnRight();
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

        //public int AddTwoNumbers(int a, int b) {
        //    return a + b;
        //}
    }
}