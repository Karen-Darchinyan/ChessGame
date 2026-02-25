namespace ChessLibrary;

public struct Coord
{
    public Column Column;
    public int Row;
    public Coord(Column by, int bx) 
    {
        Column = by;
        Row = bx;
    }
}