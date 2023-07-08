using Avangardum.GmtkJam2023Game.Commands;
using Avangardum.GmtkJam2023Game.Configs;
using Zenject;

namespace Avangardum.GmtkJam2023Game
{
    public class GoblinCommander
    {
        private const int CommonGoblinsBetweenShamansCount = 5;
        private const string CommonGoblinId = "Common Goblin";
        private const string GoblinShamanId = "Goblin Shaman";
        
        private GameManager _gameManager;
        private GoblinConfig _goblinConfig;
        private CoinStorage _coinStorage;

        private int _commonGoblinsLeftUntilShaman;

        private bool MustSpawnGoblinIfPossible => _gameManager.GoblinCount == 0;

        public GoblinCommander(GameManager gameManager, GoblinConfig goblinConfig, 
            [Inject(Id = ZenjectIds.Goblins)] CoinStorage coinStorage)
        {
            _gameManager = gameManager;
            _goblinConfig = goblinConfig;
            _coinStorage = coinStorage;

            _commonGoblinsLeftUntilShaman = CommonGoblinsBetweenShamansCount;
        }
        
        public IGoblinCommand RequestCommand()
        {
            var wantsToSpawnShaman = _commonGoblinsLeftUntilShaman == 0;
            if (wantsToSpawnShaman)
            {
                if (CanAfford(GoblinShamanId))
                {
                    return new SpawnGoblinCommand(GoblinShamanId);
                }
                else
                {
                    if (MustSpawnGoblinIfPossible && CanAfford(CommonGoblinId))
                    {
                        return new SpawnGoblinCommand(CommonGoblinId);
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            else
            {
                if (CanAfford(CommonGoblinId))
                {
                    _commonGoblinsLeftUntilShaman--;
                    return new SpawnGoblinCommand(CommonGoblinId);
                }
                else
                {
                    return null;
                }
            }
        }

        private bool CanAfford(string id) => _coinStorage.Coins >= _goblinConfig.GetGoblinPrice(id);
    }
}