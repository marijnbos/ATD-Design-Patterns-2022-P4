using Sudoku.data.Boards.Interface;

public interface IVisitorComponent 
{
    void Accept(ISudokuVistor visitor);
}