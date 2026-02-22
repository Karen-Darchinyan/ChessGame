using ChessLibrary;
using ChessLibrary.Figures;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunStepHorsMoves();
            static void RunStepHorsMoves()
            {
                Console.Write("Enter the value of the first column (A-H) and row (1-8): ");
                string? firstValue = Console.ReadLine();
                if (firstValue.Length != 2 || firstValue[0] < 'A' || firstValue[0] > 'H' || firstValue[1] < '1' || firstValue[1] > '8')
                {
                    Console.WriteLine("Invalid first position.");
                    return;
                }
                Console.Write("Enter the value of the last column (A-H) and row (1-8): ");
                string? lastValue = Console.ReadLine();
                if (lastValue.Length != 2 || lastValue[0] < 'A' || lastValue[0] > 'H' || lastValue[1] < '1' || lastValue[1] > '8')
                {
                    Console.WriteLine("Invalid first position.");
                    return;
                }
                // Քանի որ զանգվածը տողերը դասակարգված են վերևից ներքև, իսկ շախմատում դա ներքևից վերև է:
                int file1 = firstValue[0] - 'A';
                int rank1 = 7 - (firstValue[1] - '1');
                int file2 = lastValue[0] - 'A';
                int rank2 = 7 - (lastValue[1] - '1');

                Coord startCoord = new Coord(file1, rank1);
                Coord endCoord = new Coord(file2, rank2);

                King king = new King();
                bool isMoveKing = king.IsMovePossible(startCoord, endCoord);
                Console.WriteLine($"King: {isMoveKing}");

                Rook rook = new Rook();
                bool isMoveRook = rook.IsMovePossible(startCoord, endCoord);
                Console.WriteLine($"Rook: {isMoveRook}");

                Bishop bishop = new Bishop();
                bool isMoveBishop = bishop.isIsMovePossible(startCoord, endCoord);
                Console.WriteLine($"Bishop: {isMoveBishop}");

                Knight knight = new Knight();
                bool isMoveKnight = knight.IsMovePossible(startCoord, endCoord);
                Console.WriteLine($"Knight: {isMoveKnight}");

                Queen queen = new Queen();
                bool isMoveQueen = queen.IsMovePossible(startCoord, endCoord);
                Console.WriteLine($"Quesn: {isMoveQueen}");

                Pawn pawn = new Pawn();
                bool isMovePawn = pawn.IsMovePossible(startCoord, endCoord, true, false);
                Console.WriteLine($"Pawn: {isMovePawn}");

                #region Minimum steps from start to finish for knight
                //int[,] board = new int[8, 8];
                //// Սկզբնական բոլոր դաշտերը -1:
                //for (int y = 0; y < 8; y++)
                //    for (int x = 0; x < 8; x++)
                //        board[y, x] = -1;

                //Knight.StepHorsMoves(board, startCoord, 0);
                ////Տախտակը տպել:
                //for (int y = 0; y < 8; y++)
                //{
                //    for (int x = 0; x < 8; x++)
                //        Console.Write(board[y, x] + "\t");
                //    Console.WriteLine();
                //}
                //int minSteps = board[endCoord.Rank, endCoord.File];
                //Console.WriteLine($"Minimum steps from start to finish: {minSteps}");
                #endregion
            }
        }
    }
}
