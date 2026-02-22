namespace ChessLibrary.Figures
{
    public class Bishop
    {
        public bool isIsMovePossible(Coord startCoord, Coord endCoord)
        {
            if (startCoord.Rank == endCoord.Rank && startCoord.File == endCoord.File)
                return false;
            int bx = Math.Abs(startCoord.Rank - endCoord.Rank);
            int by = Math.Abs(startCoord.File - endCoord.File);
            return bx == by;
        }
    }
}
