using System;
using Table.Core;
using ToyRobot.Core;

namespace ToyRobot {
    class Program {
        static void Main(string[] args) {
            Robot robot = new Robot();
            robot.Place(0, 0, Direction.NORTH);
            robot.Move();
            Console.WriteLine(robot.ReportPosture());

            robot.Place(0, 0, Direction.NORTH);
            robot.Turn(TurnTo.LEFT);
            Console.WriteLine(robot.ReportPosture());

            robot.Place(1, 2, Direction.EAST);
            robot.Move();
            robot.Move();
            robot.Turn(TurnTo.LEFT);
            robot.Move();
            Console.WriteLine(robot.ReportPosture());
        }
    }
}