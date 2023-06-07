using Sudoku.data.Boards.@abstract;
using Sudoku.data.Boards.Enum;
using Sudoku.data.Boards.Interface;
using Sudoku.data.Cells.@abstract;
using Sudoku.data.Cells.@enum;
using Sudoku.data.Cells.Factory;
using Sudoku.data.Position;

namespace Sudoku.data.Boards;

public class NineByNine : Board
{
    public NineByNine(string cells, SudokuDisplayMode sudokuDisplayMode) : base(cells, SudokuTypes.NineByNine, sudokuDisplayMode)
    {
    }

    public override IConcreteBoard copy()
    {
        NineByNine clone = (NineByNine) this.MemberwiseClone();
        clone.SudokuDisplayMode = this.SudokuDisplayMode;
        clone.Cells = CopyCells();
        return clone;
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
                char cellValue = cells[i * 9 + j];
                bool selected = (i == 0 && j == 0) ? true : false;
                row.Add(new CellFactory().factorMethod(group, cellValue, selected, (cellValue == '0') ? CellState.Empty : CellState.FilledSystem));
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
    NineByNine clone = (NineByNine)copy();
    if(!SolveBoard(clone)) throw new Exception("The board can't be solved");
    return clone;
}

private bool SolveBoard(Board board)
{
    int row = -1;
    int col = -1;
    bool isEmpty = true;

    for (int i = 0; i < 9; i++)
    {
        for (int j = 0; j < 9; j++)
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

    for (char num = '1'; num <= '9'; num++)
    {
        if (IsSafe(board.Cells, row, col, num))
        {
            CellFactory factory = new CellFactory();
            var c = board.Cells[row][col];
            board.Cells[row][col] = factory.factorMethod(c.Group, num, false, CellState.FilledSystem); 

            if (SolveBoard(board))
            {
                return true;
            }
            board.Cells[row][col] = c;
        }       
    }

    return false;
}

private bool IsSafe(List<List<ProductCell>> cells, int row, int col, char num)
{
    for (int j = 0; j < 9; j++)
    {
        if (cells[row][j].Value == num)
        {
            return false;
        }
    }

    for (int i = 0; i < 9; i++)
    {
        if (cells[i][col].Value == num)
        {
            return false;
        }
    }

    int startRow = 3 * (row / 3);
    int startCol = 3 * (col / 3);
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            if (cells[startRow + i][startCol + j].Value == num)
            {
                return false;
            }
        }
    }

    return true;
    }

    public override Board validateBoard()
    {
        var board = getSolvedBoard();
            for (int i = 0; i < 9; i++)
                {
                for (int j = 0; j < 9; j++)
                {
                    if (this.Cells[i][j].State == data.Cells.@enum.CellState.FilledUser &&
                        this.Cells[i][j].Value != board.Cells[i][j].Value)
                    {
                        var cell = board.Cells[i][j];
                        var factory = new CellFactory();
                        board.Cells[i][j] = factory.factorMethod(cell.Group, cell.Value,
                         cell.Selected, data.Cells.@enum.CellState.FaultyCell);
                    }
                }
            }
        return board;
    }
}