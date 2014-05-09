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
using ToyRobot.Core;

namespace ToyRobot {
    class Program {
        public static Robot Robot = new Robot();
        public static String UserInput = String.Empty;

        static void Main(string[] args) {
            PrintTitle();
            do {
                UserInput = Console.ReadLine();
                if(IsValid(UserInput)) {
                    ProcessInput();
                }

            } while(!IsValid(UserInput) || !UserInput.Equals("EXIT"));
        }

        private static bool IsValid(string input) {
            if(input.Equals("REPORT") ||
               input.Equals("MOVE") ||
               input.Equals("LEFT") ||
               input.Equals("RIGHT") ||
               input.Equals("HELP") ||
               input.Equals("EXIT")) {
                return true;
            } else if(input.StartsWith("PLACE")) {
                string[] parts = input.Split(' ');
                if(parts.Length != 2) { 
                    return false; 
                }
                string[] options = parts[1].Split(',');
                if(options.Length != 3) {
                    return false;
                }
                try {
                    int x = int.Parse(options[0]);
                    int y = int.Parse(options[1]);
                } catch(Exception) {
                    return false;
                }
                return options[2].Equals("N") ||
                       options[2].Equals("E") ||
                       options[2].Equals("S") ||
                       options[2].Equals("W");
            } else {
                return false;
            }
        }

        private static void PrintTitle() {
            Console.WriteLine("WELCOME TO TOY ROBOT!");
            Console.WriteLine();
            Console.WriteLine("Execute commands or type HELP for more information.");
            Console.WriteLine();
        }

        private static void PrintHelp() {
            Console.WriteLine();
            Console.WriteLine("PLACE X,Y,F: Place robot on table with position X,Y and direction F.");
            Console.WriteLine("MOVE: Move the robot forward one grid place in direction currently facing.");
            Console.WriteLine("LEFT: Turn robot 90 degrees left.");
            Console.WriteLine("RIGHT: Turn robot 90 degrees right.");
            Console.WriteLine("REPORT: Report current position and direction faced.");
            Console.WriteLine("HELP: Print this help.");
            Console.WriteLine("EXIT: Exit this application.");
            Console.WriteLine();
        }

        private static void ProcessInput() {
            string[] command = UserInput.Split(' ');
            switch(command[0]) {
                case "HELP":
                    PrintHelp();
                    break;
                case "MOVE":
                    Robot.Move();
                    break;
                case "PLACE":
                    Direction direction;
                    string[] options = command[1].Split(',');
                    int x = int.Parse(options[0]);
                    int y = int.Parse(options[1]);    
                    switch(options[2]) {
                        case "N":
                            direction = Direction.NORTH;
                            break;
                        case "E":
                            direction = Direction.EAST;
                            break;
                        case "S":
                            direction = Direction.SOUTH;
                            break;
                        case "W":
                            direction = Direction.WEST;
                            break;
                        default:
                            direction = Direction.NORTH;
                            break;
                    }
                    Robot.Place(x, y, direction);
                    break;
                case "LEFT":
                    Robot.Turn(TurnTo.LEFT);
                    break;
                case "RIGHT":
                    Robot.Turn(TurnTo.RIGHT);
                    break;
                case "REPORT":
                    Console.WriteLine(Robot.ReportPosture());
                    break;
            }
        }
    }
}