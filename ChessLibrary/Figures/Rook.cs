namespace ChessLibrary.Figures
{
    public class Rook
    {
        public Color color;
        public bool IsMovePossible(Coord startCoord, Coord endCoord)
        {
            if (startCoord.Row == endCoord.Row && startCoord.Column == endCoord.Column)
                return false;
            int bx = Math.Abs(startCoord.Row - endCoord.Row);
            int by = Math.Abs(startCoord.Column - endCoord.Column);
            return startCoord.Row == endCoord.Row || startCoord.Column == endCoord.Column;
        }
    }
}
