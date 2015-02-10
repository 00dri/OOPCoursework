using System.Drawing;

namespace MazeGeneration
{
    public struct RemoveWallAction
    {
        public Point Neighbour;
        public CellState Wall;
    }
}
