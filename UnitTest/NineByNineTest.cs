using Sudoku.data.Boards;
using Sudoku.data.Boards.@abstract;
using Sudoku.data.Boards.Enum;
using Sudoku.data.Boards.Interface;
using Sudoku.data.Cells.@abstract;
using Sudoku.data.Cells.@enum;
using Sudoku.data.Cells.Factory;
using Sudoku.data.Position;

namespace UnitTest
{
    using System;
    using System.Collections.Generic;
    using Xunit;
}

namespace Sudoku.Tests
{
    public class NineByNineTest
    {
        public string cells { get; set; }
        public NineByNine nineByNine;
        public SudokuDisplayMode sudokuDisplayMode = SudokuDisplayMode.Assist;
        public NineByNineTest()
        {
            cells = "530070000600195000098000060800060003400803001700020006060000280000419005000080079";
        }
        [Fact]
        public void CreateBoard_ValidInput_ReturnsCorrectBoard()
        {
            // Arrange
            nineByNine = new NineByNine(cells, sudokuDisplayMode);

            // Act
            var board = nineByNine.CreateBoard(cells);

            // Assert
            Assert.Equal(9, board.Count);
            Assert.Equal(9, board[0].Count);
        }

        [Fact]
        public void SolveBoard_UnsolvableBoard_ThrowsException()
        {
            // Arrange
            sudokuDisplayMode = SudokuDisplayMode.Assist;
            cells = "";

            // Act & Assert
            Assert.Throws<IndexOutOfRangeException>(() => new NineByNine(cells, sudokuDisplayMode));
        }

        [Fact]
        public void Move_ValidInput_ReturnsCorrectMove()
        {
            // Arrange
            nineByNine = new NineByNine(cells, sudokuDisplayMode);
            var move = new Pos(1,1);
            
            // Act
            nineByNine.move(move);
            
            // Assert
            Assert.Equal(1, nineByNine.SelectedCell.X);
            Assert.Equal(1, nineByNine.SelectedCell.Y);
        }
        
        
    

    

  

     

        [Fact]
        public void CopyCells_Validinput_ReturnsCopyOfCells()
        {
            // Arrange
            nineByNine = new NineByNine(cells, sudokuDisplayMode);

            // Act
            var board = nineByNine.CreateBoard(cells);
            var copy = nineByNine.CopyCells();

            // Assert
            Assert.Equivalent(board, copy);
        }
    

        [Fact]
        public void CopyCells_ThrowsExecption_ReturnsCopyOfCells()
        { 
            // Arrange
            
             nineByNine = new NineByNine(cells, sudokuDisplayMode);
            
            // Act
            var board = nineByNine.CreateBoard(cells);
            nineByNine.Cells = null;

            // assert
            Assert.Throws<Exception>(() => nineByNine.CopyCells());
        }
        
        
        [Fact]
        public void Solver_ValidInput_ReturnsCorrectMove()
        {
            // Arrange
            nineByNine = new NineByNine(cells, sudokuDisplayMode);
            
            // Act
            var newboard = nineByNine.SolvedBoard;
            
            // Assert
            Assert.NotEqual(newboard.Cells, nineByNine.Cells);
            Assert.NotEqual(newboard.Cells[0][3].Value , nineByNine.Cells[0][3].Value);
            Assert.Equal(newboard.Cells[0][0].Value , nineByNine.Cells[0][0].Value);
        }

       
    }
}