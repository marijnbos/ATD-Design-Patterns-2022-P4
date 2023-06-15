using Sudoku.data.Boards.Enum;
using Sudoku.data.Cells.@abstract;

namespace Sudoku.data.Boards.Interface;

public interface IConcreteBoard
{
    uint NumberOfGroups { get; set; }
    List<List<ProductCell>> Cells { get; set; }
    public IConcreteBoard copy();

    public void Accept(ISudokuVistor vistor);
}