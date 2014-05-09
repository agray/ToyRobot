
namespace Table.Core {
    public class TheTable {
        public int XExtent { get; private set; }
        public int YExtent { get; private set; }

        public TheTable() {
            XExtent = 5;
            YExtent = 5;
        }

        public bool IsValidPosition(int x, int y) {
            return x > -1 && y > -1 && x < XExtent && y < YExtent;
        }
    }
}