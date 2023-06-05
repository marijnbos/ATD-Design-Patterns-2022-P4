using Sudoku.data.Boards.@abstract;
using Sudoku.data.Boards.Interface;
using Sudoku.data.EditorStates;
using Sudoku.data.Game.Enum;
using Sudoku.data.Game.State;
using Sudoku.data.Input.Enum;
using System.Text.Json;

namespace Sudoku.data.Game;

public class GameContext : IObserver<IConcreteBoard>, IObserver<PlayerInput>
{
    public IGameState State { get; set; }
    public DisplayOptions DisplayOption { get; }
    public Board Board { get; }
    public EditorState EditorState { get; private set; }
    public GameStatus GameStatus { get; private set; }
    

    public GameContext(IGameState state, Board board, DisplayOptions displayOption, EditorState editorState)
    {
        State = state;
        Board = board;
        Board.Subscribe(this);
        DisplayOption = displayOption;
        EditorState = editorState;
        GameStatus = GameStatus.Ongoing;
    }

    public void Move(PlayerInput input)
    {
        State.Move(input, this);
    }

    public void solve()
    {
        State.solve(this);
    }

    public void OnCompleted()
    {
        throw new NotImplementedException();
    }

    public void OnError(Exception error)
    {
        throw new NotImplementedException();
    }

    public void OnNext(IConcreteBoard value)
    {
        throw new NotImplementedException();
    }

    public void OnNext(PlayerInput value)
    {
        switch (value)
        {
            case PlayerInput.EditorToggle:
                editorToggle();
                break;
            case PlayerInput.Solve:
                solve();
                break;
            default:
            if (IsNumberInput(value)) {
                string numberValue = ((int)value - (int)PlayerInput.Num1 + 1).ToString();
                State.insert(numberValue, this);
            }
            break;
        }
    }

    private bool IsNumberInput(PlayerInput input)
    {
        return input >= PlayerInput.Num1 && input <= PlayerInput.Num9;
    }
    
    private void editorToggle(){
        EditorState = (EditorState == EditorState.Help) ? EditorState.Defenitive : EditorState.Help;
        State = (EditorState == EditorState.Help) ? new InsertingHelpNumbers() : new InsertRealNumberState();
    }
}