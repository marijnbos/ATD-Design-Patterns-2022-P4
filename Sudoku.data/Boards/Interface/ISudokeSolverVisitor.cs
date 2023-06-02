using Sudoku.data.Boards.@abstract;

namespace Sudoku.data.Boards.Interface;

public interface ISudokuSolverVisitor
{
    void Visit(Board board);
    void Visit(FourByFour fourByFour);
    void Visit(NineByNine nineByNine);
    void Visit(Jigsaw jigsaw);
    void Visit(Samurai samurai);
    void Visit(SixBySix sixBySix);
}