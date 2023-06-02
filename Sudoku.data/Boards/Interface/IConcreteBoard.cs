using Sudoku.data.Position;

namespace Sudoku.data.Boards;

public interface IConcreteBoard
{
    uint NumberOfGroups { get; set; }
    List<List<ProductCell>> Cells { get; set; }
    public IConcreteBoard copy();
    public void insert(uint nubmer);
    public SudokuTypes type {get;}
    public void Accept(ISudokuSolverVisitor visitor);
} 