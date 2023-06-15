using Sudoku.data.Boards.@abstract;
using Sudoku.view.Cell;

namespace Sudoku.view.Sudoku_board.Abstract;

public abstract class SudokuBoardView : IView
{
    private string _displayOptions;
    private List<List<CellView>> Cells { get; set; }

    public int Size => Cells.Count;

    public CellView GetCell(int row, int column)
    {
        return Cells[row][column];
    }

    public SudokuBoardView(Board board)
    {
        ProcessData(board);
        Draw();
    }

    public abstract void Draw();

    internal void ProcessData(Board board)
    {
        _displayOptions = "";
        Cells = new List<List<CellView>>();

        for (var i = 0; i < board.Size; i++)
        {
            List<CellView> row = new();
            for (var j = 0; j < board.Size; j++)
            {
                var cell = board.GetCell(i, j);
                var cellValue = cell.Value != 0 ? cell.Value.ToString() : " ";
                var cellView = new CellView(cell);
                row.Add(cellView);
            }

            Cells.Add(row);
        }
    }
}