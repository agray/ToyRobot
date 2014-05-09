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
                //UserInput = DisplayMenu();
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
            Console.WriteLine("PLACE X,Y,F: Place robot on table at grid X,Y facing in direction F, where F is one of N, S, E or W.");
            Console.WriteLine("MOVE: Attempt to move the robot forward one grid place in direction currently facing.");
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