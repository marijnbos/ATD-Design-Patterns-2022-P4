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
             // SolveSudoku(fourByFour.Cells);
    }

    public void Visit(NineByNine nineByNine)
    {
        if (SolveNormalBoard(nineByNine.SolvedBoard, 3, 3) == false)
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
        throw new NotImplementedException();
    }
    private void SolveSudoku(List<List<ProductCell>> cells)
    {
        throw new NotImplementedException();
    }


private bool SolveNormalBoard(Board board, int groupWidth, int groupHeight)
{
    int row = -1;
    int col = -1;
    bool isEmpty = true;

    for (int i = 0; i < board.Size; i++)
    {
        for (int j = 0; j < board.Size; j++)
        {
            if (board.Cells[i][j].State != data.Cells.@enum.CellState.FilledSystem)
            {
                row = i;
                col = j;
                isEmpty = false;
                break;
            }
        }
        if (!isEmpty)
        {
            break;
        }
    }

    if (isEmpty)
    {
        return true;
    }

    for (char num = '1'; num <= Convert.ToChar(board.Size); num++)
    {
        if (IsSafe(board.Cells, row, col, num, groupHeight, groupWidth, board.Size))
        {
            CellFactory factory = new CellFactory();
            var c = board.Cells[row][col];
            board.Cells[row][col] = factory.factorMethod(c.Group, num, false, CellState.FilledSystem, new List<int>()); 

            if (SolveNormalBoard(board, groupWidth, groupHeight))
            {
                return true;
            }
            board.Cells[row][col] = c;
        }       
    }

    return false;
}

private bool IsSafe(List<List<ProductCell>> cells, int row, int col, char num, int groupHeight, int groupWidth, int Size)
{
    for (int j = 0; j < Size; j++)
    {
        if (cells[row][j].Value == num)
        {
            return false;
        }
    }

    for (int i = 0; i < Size; i++)
    {
        if (cells[i][col].Value == num)
        {
            return false;
        }
    }

    int startRow = groupWidth * (row / groupWidth);
    int startCol = groupHeight * (col / groupHeight);
    for (int i = 0; i < groupHeight; i++)
    {
        for (int j = 0; j < groupWidth; j++)
        {
            if (cells[startRow + i][startCol + j].Value == num)
            {
                return false;
            }
        }
    }

    return true;
    }
}