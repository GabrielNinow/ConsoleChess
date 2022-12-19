using System.Drawing;

namespace ChessBoard;

public class Piece
{
    public Position position { get; set; }
    public Color color { get; protected set; }
    public int moves { get; protected set; }
    public Board board { get; protected set; }

    public Piece(Position position, Color color, Board board)
    {
        this.position = position;
        this.color = color;
        this.board = board;
        this.moves = 0;
    }
    
    
}