using Sudoku.data.Boards.@abstract;
using Sudoku.data.Boards.Enum;
using Sudoku.data.Boards.Interface;
using Sudoku.data.Cells.@abstract;
using Sudoku.data.Cells.@enum;
using Sudoku.data.Cells.Factory;
using Sudoku.data.Position;

namespace Sudoku.data.Boards;

public class Samurai : Board
{
    public override int Size {get{return 21;}} 

    public Samurai(string cells, SudokuDisplayMode sudokuDisplayMode) : base(cells, sudokuDisplayMode)
    {
    }

    public override IConcreteBoard copy()
    {
        Samurai clone = (Samurai) MemberwiseClone();
        clone.SudokuDisplayMode = SudokuDisplayMode;
        clone.Cells = CopyCells();
        clone.SolvedBoard = SolvedBoard;
        return clone;
    }

    public override List<List<ProductCell>> CreateBoard(string cells)
    {
        var board = new List<List<ProductCell>>();
        int group = 0;

        int cellIndex = 0;

        for (int i = 0; i < 21; i++)
        {
            var row = new List<ProductCell>();
            for (int j = 0; j < 21; j++)
            {
                // if it's an overlapping or non-board cell, create a NotaCell
                if ((i >= 0 && i < 6 || i >= 15 && i <= 21) && (j == 9 || j == 10 || j == 11) ||
                    (j >= 0 && j < 6 || j >= 15 && j <= 21) && (i == 9 || i == 10 || i == 11))
                {
                    row.Add(new CellFactory().factorMethod(group, '0', false, CellState.NotACell, new List<int>()));
                    continue;
                }

                // if it's an overlapping or non-board cell, create an empty cell
                if ((i < 6 || i > 14) && (j < 6 || j > 14) ||
                    ((i > 8 && i < 12) && (j > 8 && j < 12)))
                {
                    row.Add(new CellFactory().factorMethod(group, '0', false, CellState.Empty, new List<int>()));
                    continue;
                }

                char cellValue = cells[cellIndex++];
                bool selected = (i == 0 && j == 0) ? true : false;
                row.Add(new CellFactory().factorMethod(group, cellValue, selected, (cellValue == '0') ? CellState.Empty : CellState.FilledSystem, new List<int>()));
                group++;
            }
            board.Add(row);
        }
        return board;
    }

    public override void init()
    {
        this.SolvedBoard = (Samurai)copy();
        Accept(new SudokuSolverVisitor());
    }

    public override void Accept(ISudokuVistor vistor)
    {
        vistor.Visit(this);
    }
}