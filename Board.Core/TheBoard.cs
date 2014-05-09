
namespace Board.Core {
    public class TheBoard {
        public int XExtent { get; private set; }
        public int YExtent { get; private set; }

        public TheBoard() {
            XExtent = 5;
            YExtent = 5;
        }

        public bool IsValidPosition(int x, int y) {
            return x < XExtent && y < YExtent;
        }
    }
}