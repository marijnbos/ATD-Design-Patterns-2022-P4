namespace Sudoku.data.Boards.Factory;

public class BoardFactory : CreatorBoard
{
    
    //wil figire out wich type it is based on the input

    public override Board factorMethod(List<List<ProductCell>> cells, SudokuTypes type, SudokuDisplayMode sudokuDisplayMode)
    {
        throw new NotImplementedException();
    }
}