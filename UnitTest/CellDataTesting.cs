using Sudoku.data.Cells;
using Sudoku.data.Cells.@abstract;
using Sudoku.data.Cells.@enum;
using Sudoku.data.Cells.Factory;
using Sudoku.data.Color;

namespace UnitTest;

public class CellFactoryTests
{
    private readonly CellFactory _cellFactory;
    private readonly int _group = 0;
    private readonly char _cellValue = '0';
    private readonly bool _selected = false;
    private readonly List<int> _helpernumbers = new();

    public CellFactoryTests()
    {
        _cellFactory = new CellFactory();
    }

    [Fact]
    public void ShouldReturnCorrectTypeForEmptyState()
    {
        // Arrange
        var state = CellState.Empty;

        // Act
        var result = _cellFactory.factorMethod(_group, _cellValue, _selected, state, _helpernumbers);

        // Assert
        Assert.IsType<EmptyCell>(result);
    }

    [Fact]
    public void ShouldReturnCorrectTypeForFilledSystemState()
    {
        // Arrange
        var state = CellState.FilledSystem;

        // Act
        var result = _cellFactory.factorMethod(_group, _cellValue, _selected, state, _helpernumbers);

        // Assert
        Assert.IsType<FilledSystemCell>(result);
    }

    // Repeat similar test cases for each of the CellState enum options...

    [Fact]
    public void ShouldThrowArgumentExceptionForInvalidState()
    {
        // Arrange
        var state = (CellState) 99;

        // Act & Assert
        Assert.Throws<ArgumentException>(() =>
            _cellFactory.factorMethod(_group, _cellValue, _selected, state, _helpernumbers));
    }

    [Fact]
    public void ShouldReturnCorrectTypeForCorrectState()
    {
        // Arrange
        var state = CellState.CorrectCell;

        // Act
        var result = _cellFactory.factorMethod(_group, _cellValue, _selected, state, _helpernumbers);

        // Assert
        Assert.IsType<CorrectCell>(result);
    }

    [Fact]
    public void ShouldReturnCorrectTypeForFaultyState()
    {
        // Arrange
        var state = CellState.FaultyCell;

        // Act
        var result = _cellFactory.factorMethod(_group, _cellValue, _selected, state, _helpernumbers);

        // Assert
        Assert.IsType<FaultyCell>(result);
    }

    [Fact]
    public void ShouldReturnCorrectTypeForFilledUserState()
    {
        // Arrange
        var state = CellState.FilledUser;

        // Act
        var result = _cellFactory.factorMethod(_group, _cellValue, _selected, state, _helpernumbers);

        // Assert
        Assert.IsType<FilledUserCell>(result);
    }

    [Fact]
    public void ShouldReturnCorrectTypeForNotACellState()
    {
        // Arrange
        var state = CellState.NotACell;

        // Act
        var result = _cellFactory.factorMethod(_group, _cellValue, _selected, state, _helpernumbers);

        // Assert
        Assert.IsType<NotACell>(result);
    }

    [Fact]
    public void createdCells_return_Color()
    {
        //arrange
        ProductCell result;
        ProductCell result2;
        ProductCell result3;
        ProductCell result4;
        //act
        result = _cellFactory.factorMethod(_group, _cellValue, _selected, CellState.NotACell, _helpernumbers);
        result2 = _cellFactory.factorMethod(_group, _cellValue, _selected, CellState.FaultyCell, _helpernumbers);
        result3 = _cellFactory.factorMethod(_group, _cellValue, _selected, CellState.CorrectCell, _helpernumbers);
        result4 = _cellFactory.factorMethod(_group, _cellValue, _selected, CellState.FilledUser, _helpernumbers);
        //assert
        Assert.Equal(ColorEnum.Black, result.getColor());
        Assert.Equal(ColorEnum.Orange, result2.getColor());
        Assert.Equal(ColorEnum.Red, result3.getColor());
        Assert.Equal(ColorEnum.Pink, result4.getColor());
    }
}