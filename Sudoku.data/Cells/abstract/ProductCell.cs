using Sudoku.data.Cells.@enum;
using Sudoku.data.Color;

namespace Sudoku.data.Cells.@abstract
{
    public abstract class ProductCell
    {
        public CellState State { get; set; }
        public int Group { get; }
        public abstract char Value { get; set; }
        public abstract ColorEnum getCollor();
        public bool Selected { get; set; }

        public List<int> HelperNumbers { get; set; } = new();

        protected ProductCell(int group, char value, bool selected, CellState state, List<int> helperNumbers)
        {
            Group = group;
            Value = value;
            Selected = selected;
            State = state;
            HelperNumbers = helperNumbers;
        }
        
    }
}