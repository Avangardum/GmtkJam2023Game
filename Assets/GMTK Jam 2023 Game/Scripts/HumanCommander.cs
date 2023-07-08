using Avangardum.GmtkJam2023Game.Configs;
using Zenject;

namespace Avangardum.GmtkJam2023Game
{
    public class HumanCommander
    {
        private GameManager _gameManager;
        private TowerConfig _towerConfig;
        private CoinStorage _coinStorage;

        public HumanCommander(GameManager gameManager, TowerConfig towerConfig, 
            [Inject(Id = ZenjectIds.Humans)] CoinStorage coinStorage)
        {
            _gameManager = gameManager;
            _towerConfig = towerConfig;
            _coinStorage = coinStorage;
        }
    }
}