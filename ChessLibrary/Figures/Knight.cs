namespace ChessLibrary.Figures
{
    public class Knight
    {
        public Color color;
        public bool IsMovePossible(Coord startCoord, Coord endCoord)
        {
            if (startCoord.Row == endCoord.Row && startCoord.Column == endCoord.Column)
                return false;
            int bx = Math.Abs(startCoord.Row - endCoord.Row);
            int by = Math.Abs(startCoord.Column - endCoord.Column);
            return (bx == 2 && by == 1) || (bx == 1 && by == 2);  
        }
        #region Minimum steps from start to finish for knight
        //public static void StepHorsMoves(int[,] board, Coord positon, int step)
        //{
        //    int[,] offsets =
        //    {
        //        { 2, 1 }, { 2, -1 },
        //        { -2, 1 }, { -2, -1 },
        //        { 1, 2 }, { 1, -2 },
        //        { -1, 2 }, { -1, -2 }
        //    };
        //    // Եթե արդեն քայլը փոքր կամ հավասար է նախորդիվ լրացված արժեքին, ոչինչ չանել:
        //    if (board[positon.Row, positon.Column] != -1 && board[positon.Row, positon.Column] <= step)
        //        return;

        //    board[positon.Row, positon.Column] = step;

        //    for (int i = 0; i < 8; i++)
        //    {
        //        int newX = positon.Row + offsets[i, 0];
        //        int newY = positon.Column + offsets[i, 1];

        //        if (newX >= 0 && newX < 8 && newY >= 0 && newY < 8)
        //        {
        //            StepHorsMoves(board, new Coord(newX, newY), step + 1);
        //        }
        //    }
        //}
        #endregion
    }
}
