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
                // Convert each character to integer and add it to the board
                char cellValue = cells[i * 4 + j];
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