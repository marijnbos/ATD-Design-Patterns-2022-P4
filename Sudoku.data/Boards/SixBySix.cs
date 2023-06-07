using Sudoku.data.Boards.@abstract;
using Sudoku.data.Boards.Enum;
using Sudoku.data.Boards.Interface;
using Sudoku.data.Cells.@abstract;
using Sudoku.data.Cells.Factory;
using Sudoku.data.Position;

namespace Sudoku.data.Boards;

public class SixBySix : Board
{
    public SixBySix(string cells, SudokuDisplayMode sudokuDisplayMode) : base(cells, SudokuTypes.SixBySix, sudokuDisplayMode)
    {
    }

    public override IConcreteBoard copy()
    {
        //todo make this return a new sixbysix board
        throw new NotImplementedException();
    }

    public override List<List<ProductCell>> CreateBoard(string cells)
    {
        var board = new List<List<ProductCell>>();
        int group = 0;
        for (int i = 0; i < 6; i++)
        {
            var row = new List<ProductCell>();
            for (int j = 0; j < 6; j++)
            {
                char cellValue = cells[i * 6 + j];
                bool selected = (i == 0 && j == 0) ? true : false;
                row.Add(new CellFactory().factorMethod(group, cellValue, selected));
                group++;
            }
            board.Add(row);
        }
        return board;
    }

    public override void move(Pos move)
    {
        ProductCell? selectedCell = Cells.SelectMany(row => row).FirstOrDefault(cell => cell.Selected);

        if (selectedCell != null)
        {
            int currentRow = Cells.FindIndex(row => row.Contains(selectedCell));
            int currentColumn = Cells[currentRow].FindIndex(cell => cell == selectedCell);

            int newRow = currentRow + move.X;
            int newColumn = currentColumn + move.Y;

            if (newRow >= 0 && newRow < Size && newColumn >= 0 && newColumn < Size)
            {
                selectedCell.Selected = false;
                selectedCell = Cells[newRow][newColumn];
                SelectedCell = new Pos(newColumn, newRow);
                selectedCell.Selected = true;
            }
        }
    }

    public override Board getSolvedBoard()
    {
        throw new NotImplementedException();
    }

    public override Board validateBoard()
    {
        throw new NotImplementedException();
    }
}