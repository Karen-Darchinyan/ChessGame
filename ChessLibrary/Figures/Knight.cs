namespace ChessLibrary.Figures
{
    public class Knight
    {
        public bool IsMovePossible(Coord startCoord, Coord endCoord)
        {
            if (startCoord.Rank == endCoord.Rank && startCoord.File == endCoord.File)
                return false;
            int bx = Math.Abs(startCoord.Rank - endCoord.Rank);
            int by = Math.Abs(startCoord.File - endCoord.File);
            return (bx == 2 && by == 1) || (bx == 1 && by == 2);  
        }
        #region Minimum steps from start to finish for knight
        public static void StepHorsMoves(int[,] board, Coord positon, int step)
        {
            int[,] offsets =
            {
                { 2, 1 }, { 2, -1 },
                { -2, 1 }, { -2, -1 },
                { 1, 2 }, { 1, -2 },
                { -1, 2 }, { -1, -2 }
            };
            // Եթե արդեն քայլը փոքր կամ հավասար է նախորդիվ լրացված արժեքին, ոչինչ չանել:
            if (board[positon.Rank, positon.File] != -1 && board[positon.Rank, positon.File] <= step)
                return;

            board[positon.Rank, positon.File] = step;

            for (int i = 0; i < 8; i++)
            {
                int newX = positon.Rank + offsets[i, 0];
                int newY = positon.File + offsets[i, 1];

                if (newX >= 0 && newX < 8 && newY >= 0 && newY < 8)
                {
                    StepHorsMoves(board, new Coord(newX, newY), step + 1);
                }
            }
        }
        #endregion
    }
}
