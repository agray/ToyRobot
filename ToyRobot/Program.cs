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
using ToyRobot.Core;

namespace ToyRobot {
    class Program {
        public static Robot Robot = new Robot();
        public static String UserInput = String.Empty;

        static void Main(string[] args) {
            PrintTitle();
            do {
                Console.WriteLine(Constants.ENTER_COMMAND);
                UserInput = Console.ReadLine();
                if(IsValid(UserInput)) {
                    ProcessInput();
                } else {
                    Console.WriteLine(Constants.INVALID_INPUT);
                }

            } while(!UserInput.Equals(Constants.EXIT));
        }

        private static bool IsValid(string input) {
            if(input.Equals(Constants.REPORT) ||
               input.Equals(Constants.MOVE) ||
               input.Equals(Constants.LEFT) ||
               input.Equals(Constants.RIGHT) ||
               input.Equals(Constants.HELP) ||
               input.Equals(Constants.EXIT)) {
                return true;
            } else if(input.StartsWith(Constants.PLACE)) {
                string[] parts = input.Split(Constants.SPACE_CHAR);
                if(parts.Length != 2) { 
                    return false; 
                }
                string[] options = parts[1].Split(Constants.COMMA_CHAR);
                if(options.Length != 3) {
                    return false;
                }
                try {
                    int x = int.Parse(options[0]);
                    int y = int.Parse(options[1]);
                } catch(Exception) {
                    return false;
                }
                return options[2].Equals(Constants.NORTH) ||
                       options[2].Equals(Constants.EAST) ||
                       options[2].Equals(Constants.SOUTH) ||
                       options[2].Equals(Constants.WEST);
            } else {
                return false;
            }
        }

        private static void PrintTitle() {
            Console.WriteLine(Constants.TAG_LINE);
            Console.WriteLine();
            Console.WriteLine(Constants.INITIAL_INSTRUCTION);
            Console.WriteLine();
        }

        private static void PrintHelp() {
            Console.WriteLine();
            Console.WriteLine(Constants.AVAILABLE_COMMANDS);
            Console.WriteLine(Constants.PLACE_HELP);
            Console.WriteLine(Constants.MOVE_HELP);
            Console.WriteLine(Constants.LEFT_HELP);
            Console.WriteLine(Constants.RIGHT_HELP);
            Console.WriteLine(Constants.REPORT_HELP);
            Console.WriteLine(Constants.HELP_HELP);
            Console.WriteLine(Constants.EXIT_HELP);
            Console.WriteLine();
        }

        private static void ProcessInput() {
            string[] command = UserInput.Split(Constants.SPACE_CHAR);
            switch(command[0]) {
                case Constants.HELP:
                    PrintHelp();
                    break;
                case Constants.MOVE:
                    Robot.Move();
                    break;
                case Constants.PLACE:
                    Direction direction;
                    string[] options = command[1].Split(Constants.COMMA_CHAR);
                    int x = int.Parse(options[0]);
                    int y = int.Parse(options[1]);    
                    switch(options[2]) {
                        case Constants.NORTH:
                            direction = Direction.NORTH;
                            break;
                        case Constants.EAST:
                            direction = Direction.EAST;
                            break;
                        case Constants.SOUTH:
                            direction = Direction.SOUTH;
                            break;
                        case Constants.WEST:
                            direction = Direction.WEST;
                            break;
                        default:
                            direction = Direction.NORTH;
                            break;
                    }
                    Robot.Place(x, y, direction);
                    break;
                case Constants.LEFT:
                    Robot.Turn(TurnTo.LEFT);
                    break;
                case Constants.RIGHT:
                    Robot.Turn(TurnTo.RIGHT);
                    break;
                case Constants.REPORT:
                    String status = Robot.ReportPosture();
                    if(status != String.Empty) {
                        Console.WriteLine(Robot.ReportPosture());
                    }
                    break;
                case Constants.EXIT:
                    Console.WriteLine(Constants.EXIT_MESSAGE);
                    break;
            }
        }
    }
}