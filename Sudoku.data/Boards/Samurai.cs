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
    public override int Size => 21;

    public Samurai(string cells, SudokuDisplayMode sudokuDisplayMode) : base(cells, sudokuDisplayMode)
    {
    }

    public override IConcreteBoard copy()
    {
        var clone = (Samurai) MemberwiseClone();
        clone.SudokuDisplayMode = SudokuDisplayMode;
        clone.Cells = CopyCells();
        clone.SolvedBoard = SolvedBoard;
        return clone;
    }

    public override List<List<ProductCell>> CreateBoard(string cells)
    {
        const int boardSize = 21;
        const int offset = 6;
        const int overlapStart = 9;
        const int overlapEnd = 11;
        const int middleStart = 15;
    
        var board = new List<List<ProductCell>>();
        var group = 0;

        var cellIndex = 0;

        for (var i = 0; i < boardSize; i++)
        {
            var row = new List<ProductCell>();
            for (var j = 0; j < boardSize; j++)
            {
                // if it's an overlapping or non-board cell, create a NotaCell
                if ((((i >= 0 && i < offset) || (i >= middleStart && i < boardSize)) && (j == overlapStart || j == overlapEnd)) ||
                    (((j >= 0 && j < offset) || (j >= middleStart && j < boardSize)) && (i == overlapStart || i == overlapEnd)))
                {
                    row.Add(new CellFactory().factorMethod(group, '0', false, CellState.NotACell, new List<int>()));
                    continue;
                }

                // if it's an overlapping or non-board cell, create an empty cell
                if (((i < offset || i >= middleStart) && (j < offset || j >= middleStart)) ||
                    (i > overlapStart && i < overlapEnd + 1 && j > overlapStart && j < overlapEnd + 1))
                {
                    row.Add(new CellFactory().factorMethod(group, '0', false, CellState.Empty, new List<int>()));
                    continue;
                }

                var cellValue = cells[cellIndex++];
                var selected = i == 0 && j == 0;
                row.Add(new CellFactory().factorMethod(group, cellValue, selected,
                    cellValue == '0' ? CellState.Empty : CellState.FilledSystem, new List<int>()));
                group++;
            }

            board.Add(row);
        }

        return board;
    }


    public override void init()
    {
        SolvedBoard = (Samurai) copy();
        Accept(new SudokuSolverVisitor());
    }

    public override void Accept(ISudokuVistor vistor)   
    {
        // vistor.Visit(this);
    }
}