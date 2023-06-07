using Sudoku.data.Boards.@abstract;
using Sudoku.data.Boards.Enum;
using Sudoku.data.Boards.Interface;
using Sudoku.data.Cells.@abstract;
using Sudoku.data.Cells.Factory;
using Sudoku.data.Position;

namespace Sudoku.data.Boards;

public class FourByFour : Board
{

    public FourByFour(string inputCells, SudokuTypes type, SudokuDisplayMode sudokuDisplayMode) : base(inputCells, type, sudokuDisplayMode)
    {
    }

    public override IConcreteBoard copy()
    {
        //todo make this return a new fourbyfour board
        throw new NotImplementedException();
    }

    public override List<List<ProductCell>> CreateBoard(string cells)
    {
        var board = new List<List<ProductCell>>();
        int group = 0;
        for (int i = 0; i < 4; i++)
        {
            var row = new List<ProductCell>();
            for (int j = 0; j < 4; j++)
            {
                char cellValue = cells[i * 4 + j];
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
        Accept(new SudokuSolverVisitor());
        return this;
    }

    public override Board validateBoard()
    {
        throw new NotImplementedException();
    }


}