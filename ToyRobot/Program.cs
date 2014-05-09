using Board.Core;
using ToyRobot.Core;

namespace ToyRobot {
    class Program {
        static void Main(string[] args) {
            TheBoard board = new TheBoard();

            Robot robot = new Robot();
            robot.Place(-1, 0, Direction.EAST);
            robot.Move();
            robot.Report();

        }
    }
}