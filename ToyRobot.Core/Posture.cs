
namespace ToyRobot.Core {
    public class Posture {
        public Position Position { get; set; }
        public Direction Direction { get; set; }

        public Posture(Position position, Direction direction) {
            Position = position;
            Direction = direction;
        }
    }
}