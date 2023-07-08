using Avangardum.GmtkJam2023Game.Commands;
using Avangardum.GmtkJam2023Game.Configs;
using Zenject;

namespace Avangardum.GmtkJam2023Game
{
    public class GoblinCommander
    {
        private GameManager _gameManager;
        private GoblinConfig _goblinConfig;
        private CoinStorage _coinStorage;

        public GoblinCommander(GameManager gameManager, GoblinConfig goblinConfig, 
            [Inject(Id = ZenjectIds.Goblins)] CoinStorage coinStorage)
        {
            _gameManager = gameManager;
            _goblinConfig = goblinConfig;
            _coinStorage = coinStorage;
        }
        
        public IGoblinCommand RequestCommand()
        {
            return null;
        }
    }
}