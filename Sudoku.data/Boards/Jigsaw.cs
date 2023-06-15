using Sudoku.data.Boards.@abstract;
using Sudoku.data.Boards.Adapter;
using Sudoku.data.Boards.Enum;
using Sudoku.data.Boards.Interface;
using Sudoku.data.Cells.@abstract;
using Sudoku.data.Cells.@enum;
using Sudoku.data.Cells.Factory;
using Sudoku.data.Position;

namespace Sudoku.data.Boards;

public class Jigsaw : Board
{
    public Jigsaw(string cells, SudokuDisplayMode sudokuDisplayMode) : base(cells,  sudokuDisplayMode)
    {
    }

    public override IConcreteBoard copy()
    {
        throw new NotImplementedException();
    }

    public override List<List<ProductCell>> CreateBoard(string Inputcells)
    {
        return new JigsawAdapter().CreateBoard(Inputcells.Remove(0,10));
    }

    public override void move(Pos move)
    {
        var old = Cells[SelectedCell.X][SelectedCell.Y];
        int newRow = SelectedCell.X + move.X;
        int newColumn = SelectedCell.Y + move.Y;

        if (newRow >= 0 && newRow < Size && newColumn >= 0 && newColumn < Size)
        {
            old.Selected = false;
            var selectedCell = Cells[newRow][newColumn];
            SelectedCell = new Pos(newColumn, newRow);
            selectedCell.Selected = true;
        }
    }

    public override Board getSolvedBoard()
    {
        return this;
    }

    public override Board validateBoard()
    {
        throw new NotImplementedException();
    }
}

