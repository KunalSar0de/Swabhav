
namespace TicTacToeCore
{
    public class Game
    {
        private Player[] _player;
        private ResultAnalyzer _analyzer;
        private ResultType _status;
        private Player _currentPlayer;

        public Game(Player[] player, ResultAnalyzer analyzer)
        {               
            _player = player;
            _analyzer = analyzer;
            _currentPlayer = _player[0];
        }

        public void Play(int location)
        {                  
            if (_currentPlayer ==_player[0])
            {
                _analyzer.GetBoard.MarkCellAtPosition(location, _player[0].GetPlayerMark);                        
                _currentPlayer=_player[1];
            }else if (_currentPlayer ==_player[1])
            {
                _analyzer.GetBoard.MarkCellAtPosition(location, _player[1].GetPlayerMark);
                _currentPlayer=_player[0];
            }
        }

        public ResultType GetStatus
        {
            get
            {
                _status = GetAnalyzer.Analyze();
                return _status;
            }
        }
        public Board GetBoard
        {
            get
            {
                return _analyzer.GetBoard;
            }
        }
        public ResultAnalyzer GetAnalyzer
        {
            get
            {
                return _analyzer;
            }
        }
        public string GetCurrentPlayer
        {
            get{
                return _currentPlayer.GetPlayerName;
            } 
        }
    }
}
