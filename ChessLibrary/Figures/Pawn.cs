namespace ChessLibrary.Figures
{
    public class Pawn
    {
        public Color Color;
        public Pawn(Color color) 
        {
            Color = color;
        }

        public bool IsMovePossible(Coord startCoord, Coord endCoord)
        {
            int bRow = startCoord.Row - endCoord.Row;
            int bColumn = Math.Abs(startCoord.Column - endCoord.Column);
            if (Color == Color.White)
            {
                if (startCoord.Row <= 0 || endCoord.Row <= startCoord.Row)
                    return false;
                if (startCoord.Row == 2)
                    return bRow == -1 || bRow == -2;
                else if(startCoord.Row > 2)
                    return bRow == -1; 
            }
            else
            {
                if (startCoord.Row >= 8 || endCoord.Row >= startCoord.Row)
                    return false;
                if (startCoord.Row == 7)
                    return bRow == 1 || bRow == 2;
                else if (startCoord.Row < 7)
                    return bRow == 1;
            }
            return false;
        }
    }
}
