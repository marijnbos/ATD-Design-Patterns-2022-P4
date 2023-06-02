using Sudoku.data.Boards.@abstract;
using Sudoku.data.Boards.Enum;
using Sudoku.data.Boards.Interface;
using Sudoku.data.Cells.@abstract;
using Sudoku.data.Cells.Factory;
using Sudoku.data.Position;

namespace Sudoku.data.Boards;

public class NineByNine : Board
{
    public NineByNine(string cells, SudokuDisplayMode sudokuDisplayMode) :  base(cells, SudokuTypes.NineByNine, sudokuDisplayMode)
    {
    }

    public override IConcreteBoard copy()
    {
        //todo make this return a actual list of 9x9 cells
        throw new NotImplementedException();
    }

    public override List<List<ProductCell>> CreateBoard(string cells)
    {
        var board = new List<List<ProductCell>>();
        int group = 0;
        for (int i = 0; i < 9; i++)
        {
            var row = new List<ProductCell>();
            for (int j = 0; j < 9; j++)
            {
                // Convert each character to integer and add it to the board
                char cellValue = cells[i * 9 + j];
                row.Add(new CellFactory().factorMethod(group,cellValue));
                group++;
            }
            board.Add(row);
        }
        return board;
    }

    public override void move(Pos move)
    {
        throw new NotImplementedException();
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