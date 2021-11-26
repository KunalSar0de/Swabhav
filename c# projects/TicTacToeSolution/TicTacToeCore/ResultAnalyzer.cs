
namespace TicTacToeCore
{
    public class ResultAnalyzer
    {
        private Board _board;
        public ResultAnalyzer(Board board)
        {
            _board = board;
        }

        public ResultType Analyze()
        {
           
            if (CheckRow().Equals(ResultType.WIN) || CheckColum().Equals(ResultType.WIN) 
                || CheckDiagonal().Equals(ResultType.WIN))
                return ResultType.WIN;
            else if (_board.CheckBoardIsFull())
                return ResultType.DRAW;
            return ResultType.NO_RESULT;
        }

        private ResultType CheckRow()
        {
            if (ChechEveryCondition(0, 1, 2))
                return ResultType.WIN;
            else if (ChechEveryCondition(3, 4, 5))
                return ResultType.WIN;
            else if (ChechEveryCondition(6, 7, 8))
                return ResultType.WIN;
            return ResultType.NO_RESULT;   
        }
        
       
        private ResultType CheckColum()
        {
            if (ChechEveryCondition(0, 3, 6))
                return ResultType.WIN;
            else if (ChechEveryCondition(1, 4, 7))
                return ResultType.WIN;
            else if (ChechEveryCondition(2, 5, 8))
                return ResultType.WIN;
            return ResultType.NO_RESULT;
        }
         
        private ResultType CheckDiagonal()
        {
            if (ChechEveryCondition(0, 4, 8))
                return ResultType.WIN;
            else if (ChechEveryCondition(2, 4, 6))
                return ResultType.WIN;
            return ResultType.NO_RESULT;
        }
        private bool ChechEveryCondition(int i, int j, int k)
        {
            if (_board.GetAllCells[i].GetMark == _board.GetAllCells[j].GetMark &&
                _board.GetAllCells[j].GetMark == _board.GetAllCells[k].GetMark &&
                _board.GetAllCells[i].GetMark != MarkType.EMPTY)
                return true;
            return false;
        }

        public Board GetBoard
        {
            get
            {
                return _board;
            }
        }
    }
}
