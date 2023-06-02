using Sudoku.data.Color;

namespace Sudoku.data.Cells.@abstract
{
    //todo introduce composit pattern to group cells
    public abstract class ProductCell
    {
        private int Group { get; }
        public abstract char Value { get; set; }
        public abstract ColorEnum getCollor();
        protected ProductCell(int group)
        {
            Group = group;
        }
    }
}