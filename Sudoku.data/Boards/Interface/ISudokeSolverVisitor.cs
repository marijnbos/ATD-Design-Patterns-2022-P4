using Sudoku.data.Boards;
public interface ISudokuSolverVisitor
{
    void Visit(Board board);
    void Visit(FourByFour fourByFour);
    void Visit(NineByNine nineByNine);
    void Visit(Jigsaw jigsaw);
    void Visit(Samurai samurai);
    void Visit(SixBySix sixBySix);
}
