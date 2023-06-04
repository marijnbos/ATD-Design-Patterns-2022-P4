using Sudoku.data.Boards.Enum;
using Sudoku.view.Cell;
using Sudoku.view.Sudoku_board.Abstract;

namespace Sudoku.view.Sudoku_board
{
    public class FourByFourBoardDrawingStrategy : SudokuBoardView
    {
        public FourByFourBoardDrawingStrategy(SudokuDisplayMode displayoptions, string type, List<List<CellView>> cells) : base(displayoptions, type, cells)
        {
        }

        public override void Draw()
        {
            for (var i = 0; i <  Cells.Count; i++)
            {
                for (var j = 0; j < Cells[i].Count; j++)
                {
                    Console.Write(Cells[i][j].cluster + " ");
                }
            }
           
        }
    }
}