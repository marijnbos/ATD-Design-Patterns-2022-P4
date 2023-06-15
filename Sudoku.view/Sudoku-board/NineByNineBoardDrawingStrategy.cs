using Sudoku.data.Boards.@abstract;
using Sudoku.view.Cell;
using Sudoku.view.Sudoku_board.Abstract;

namespace Sudoku.view.Sudoku_board
{
    public class NineByNineBoardDrawingStrategy : SudokuBoardView
    {
        public NineByNineBoardDrawingStrategy(Board board) : base(board)
        {
        }
        public override void Draw()
        {
            for (int row = 0; row < Size; row++)
            {
                for (int col = 0; col < Size; col++)
                {
                    CellView cellView = GetCell(row, col);
                    cellView.Draw();

                    if ((col + 1) % 3 == 0 && col < Size - 1)
                    {
                        Console.Write("| ");
                    }
                }
                Console.WriteLine();

                if ((row + 1) % 3 == 0 && row < Size - 1)
                {
                    Console.WriteLine(new string('-', Size * 10 + 2));
                }
            }
        }
    }
}