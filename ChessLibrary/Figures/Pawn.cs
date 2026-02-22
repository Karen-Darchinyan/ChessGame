namespace ChessLibrary.Figures
{
    public class Pawn
    {
        public bool IsMovePossible(Coord startCoord, Coord endCoord, bool isWhite, bool captures)
        {
            int bRank = startCoord.Rank - endCoord.Rank;
            int bFile = Math.Abs(startCoord.File - endCoord.File);
            if (isWhite)
            {
                if (startCoord.Rank <= 0 || endCoord.Rank <= startCoord.Rank)
                    return false;
                if (captures)
                    return bRank == -1 && bFile == 1;
                if (startCoord.Rank == 2)
                    return bRank == -1 || bRank == -2;
                else if(startCoord.Rank > 2)
                    return bRank == -1; 
            }
            else
            {
                if (startCoord.Rank >= 8 || endCoord.Rank >= startCoord.Rank)
                    return false;
                if (captures)
                    return bRank == 1 && bFile == 1;
                if (startCoord.Rank == 7)
                    return bRank == 1 || bRank == 2;
                else if (startCoord.Rank < 7)
                    return bRank == 1;
            }
            return false;
        }
    }
}
