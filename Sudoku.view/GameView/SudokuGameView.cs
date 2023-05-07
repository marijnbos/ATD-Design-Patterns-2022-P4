namespace Sudoku.view.GameView;

public class SudokuGameView : IView
{
    private readonly SudokuBoardView _sudokuBoardView;
    public SudokuGameView(string json)
    {
        /*
         if (board is StandardBoard)
            {
                _sudokuBoardView = new SudokuBoardView(new StandardBoardDrawingStrategy());
            }
            else
            {
                throw new ArgumentException("Unsupported board type");
            }

        /etc
        */
    }

    public void ProcessData(string json)
    {
            throw new NotImplementedException();
    }
    
    public void Draw()
    {
        //nieuwe board aanmaken en tekenen board aanmaken 
        _sudokuBoardView.Draw();
    }

    private void Deserialize(string json){
        throw new NotImplementedException();
    }
}