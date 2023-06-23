using Sudoku.data.Boards.@abstract;
using Sudoku.data.Color;
using Sudoku.view.Cell;
using Sudoku.view.Sudoku_board.Abstract;

namespace Sudoku.view.Sudoku_board;

public class JigsawBoardDrawingStrategy : SudokuBoardView
{
    public JigsawBoardDrawingStrategy(Board board) : base(board)
    {
    }

    public override void Draw()
    {
        for (var row = 0; row < Size; row++)
        {
            for (var col = 0; col < Size; col++)
            {
                var cellView = GetCell(row, col);
                SetConsoleBackgroundColor(cellView.Group);
                cellView.Draw();
            }

            Console.WriteLine();
        }
    }

    private void SetConsoleBackgroundColor(int group)
    {
        switch (group % 6)
        {
            case 0:
                Console.BackgroundColor = ConsoleColor.White;
                break;
            case 1:
                Console.BackgroundColor = ConsoleColor.Blue;
                break;
            case 2:
                Console.BackgroundColor = ConsoleColor.Gray;
                break;
            case 3:
                Console.BackgroundColor = ConsoleColor.Cyan;
                break;
            case 4:
                Console.BackgroundColor = ConsoleColor.DarkCyan;
                break;
            case 5:
                Console.BackgroundColor = ConsoleColor.DarkGray;
                break;
            default:
                ResetConsoleBackgroundColor();
                break;
        }
    }

    private void ResetConsoleBackgroundColor()
    {
        Console.ResetColor();
    }
}