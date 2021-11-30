using TicTacToeCore.Models;

namespace TicTacToeCore.Engine
{
    public interface IEngine
    {
        PositionModel GetNextMove_Max(GameStateModel game);
        PositionModel GetNextMove_SelectDepth(GameStateModel game, int depth);
    }
}
