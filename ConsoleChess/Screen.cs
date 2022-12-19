using ChessBoard;

namespace ConsoleChess;

public class Screen
{
    public static void printBoard(Board board)
    {
        for (int i = 0; i < board.lines; i++)
        {
            for (int j = 0; j < board.columns; j++)
            {
                if (board.piece(i,j) != null)
                {
                    Console.WriteLine(board.piece(i,j) + " ");
                }
                else
                {
                    Console.WriteLine("- ");
                }
            }
        }
    } 
}