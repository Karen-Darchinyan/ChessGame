namespace ChessLibrary;

public struct Coord
{
    public int Rank;
    public int File;
    public Coord(int bx, int by) 
    {
        Rank = bx;
        File = by;
    }
}