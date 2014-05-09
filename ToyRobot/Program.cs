using Table.Core;
using ToyRobot.Core;

namespace ToyRobot {
    class Program {
        static void Main(string[] args) {
            TheTable table = new TheTable();

            Robot robot = new Robot();
            robot.Place(0, 0, Direction.NORTH);
            robot.Move();
            robot.Report();

            robot.Place(0, 0, Direction.NORTH);
            robot.Turn(TurnTo.LEFT);
            robot.Report();

            robot.Place(1, 2, Direction.EAST);
            robot.Move();
            robot.Move();
            robot.Turn(TurnTo.LEFT);
            robot.Move();
            robot.Report();
        }
    }
}