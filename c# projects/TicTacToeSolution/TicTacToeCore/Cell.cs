using System;

namespace TicTacToeCore
{
    public class Cell
    {
        private MarkType _mark;

        public Cell()
        {
            _mark = MarkType.EMPTY;
        }
               
        public void MarkCell(MarkType mark)
        {
            if (_mark==MarkType.EMPTY)
            {
                _mark = mark;
            }
            else
            {
                throw new Exception("Cell already marked");
            }         
               
        }
        public MarkType GetMark
        {
            get
            {
                return _mark;
            }
        }
    }
}
