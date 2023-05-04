using Sudoku.data;
using Sudoku.data.Game;
using Sudoku.view.GameView;

namespace Sudoku.controler
{
    public class GameController
    {
        private SudokuGame SudokuGame { get; }
        private EditorState EditorStates { get; }
        private Game Game { get; }
        private EditorController.EditorController editorController { get; set; }
        private BoardController BoardController { get; set; }

        public GameController(Game game, SudokuGame sudokuGame, EditorState editorStates,
            BoardController boardController)
        {
            Game = game;
            SudokuGame = sudokuGame;
            EditorStates = editorStates;
            BoardController = boardController;
        }
    }
}