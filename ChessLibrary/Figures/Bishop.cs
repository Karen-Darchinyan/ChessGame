namespace ChessLibrary.Figures
{
    public class Bishop
    {
        public Color color;
        public bool isIsMovePossible(Coord startCoord, Coord endCoord)
        {
            if (startCoord.Row == endCoord.Row && startCoord.Column == endCoord.Column)
                return false;
            int bx = Math.Abs(startCoord.Row - endCoord.Row);
            int by = Math.Abs(startCoord.Column - endCoord.Column);
            return bx == by;
        }
    }
}
