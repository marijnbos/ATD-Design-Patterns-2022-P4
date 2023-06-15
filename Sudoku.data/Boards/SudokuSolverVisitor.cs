using Sudoku.data.Boards.@abstract;
using Sudoku.data.Boards.Enum;
using Sudoku.data.Boards.Interface;
using Sudoku.data.Cells.@abstract;
using Sudoku.data.Cells.@enum;
using Sudoku.data.Cells.Factory;

namespace Sudoku.data.Boards;

public class SudokuSolverVisitor : ISudokuVistor
{
    public void Visit(FourByFour fourByFour)
    {
        if (SolveNormalBoard(fourByFour.SolvedBoard, fourByFour.GroupWidth, fourByFour.GroupHeight) == false)
            throw new Exception("Provided board cannot be solved");
    }

    public void Visit(NineByNine nineByNine)
    {
        if (SolveNormalBoard(nineByNine.SolvedBoard, nineByNine.GroupWidth, nineByNine.GroupHeight) == false)
            throw new Exception("Provided board cannot be solved");
    }

    public void Visit(Jigsaw jigsaw)
    {
        throw new NotImplementedException();
    }

    public void Visit(Samurai samurai)
    {
        throw new NotImplementedException();
    }

    public void Visit(SixBySix sixBySix)
    {
        if (SolveNormalBoard(sixBySix.SolvedBoard, sixBySix.GroupWidth, sixBySix.GroupHeight) == false)
            throw new Exception("Provided board cannot be solved");
    }


    private bool SolveNormalBoard(Board board, int groupWidth, int groupHeight)
    {
        var row = -1;
        var col = -1;
        var isEmpty = true;
        for (var i = 0; i < board.Size; i++)
        {
            for (var j = 0; j < board.Size; j++)
                if (board.Cells[i][j].State != CellState.FilledSystem)
                {
                    row = i;
                    col = j;
                    isEmpty = false;
                    break;
                }

            if (!isEmpty) break;
        }

        if (isEmpty) return true;

        for (var num = '1'; num <= Convert.ToChar(board.Size.ToString()); num++)
            if (IsSafe(board.Cells, row, col, num, groupHeight, groupWidth, board.Size))
            {
                var factory = new CellFactory();
                var c = board.Cells[row][col];
                board.Cells[row][col] =
                    factory.factorMethod(c.Group, num, false, CellState.FilledSystem, new List<int>());

                if (SolveNormalBoard(board, groupWidth, groupHeight)) return true;
                board.Cells[row][col] = c;
            }

        return false;
    }

    private bool IsSafe(List<List<ProductCell>> cells, int row, int col, char num, int groupHeight, int groupWidth,
        int Size)
    {
        for (var j = 0; j < Size; j++)
            if (cells[row][j].Value == num)
                return false;

        for (var i = 0; i < Size; i++)
            if (cells[i][col].Value == num)
                return false;

        var startRow = groupHeight * (row / groupHeight);
        var startCol = groupWidth * (col / groupWidth);


        for (var i = 0; i < groupHeight; i++)
        for (var j = 0; j < groupWidth; j++)
            if (cells[startRow + i][startCol + j].Value == num)
                return false;

        return true;
    }
}