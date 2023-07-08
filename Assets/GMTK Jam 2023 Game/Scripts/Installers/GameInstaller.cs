using Avangardum.GmtkJam2023Game.Configs;
using UnityEngine;
using UnityEngine.Serialization;
using Zenject;

namespace Avangardum.GmtkJam2023Game.Installers
{
    public class GameInstaller : MonoInstaller
    {
        [SerializeField] private GameConfig _gameConfig;
        [SerializeField] private LevelConfig _levelConfig;
        [SerializeField] private GoblinConfig _goblinConfig;
        [SerializeField] private TowerConfig _towerConfig;

        public override void InstallBindings()
        {
            Container.Bind<GameManager>().AsSingle();
            Container.Bind<AbilityController>().AsSingle();
            Container.Bind<GameUI>().FromComponentsInHierarchy().AsSingle();
            Container.Bind<GamePresenter>().AsSingle().NonLazy();
                
            Container.Bind<GoblinCommander>().AsSingle();
            Container.Bind<HumanCommander>().AsSingle();
            
            Container.Bind<GameConfig>().FromInstance(_gameConfig);
            Container.Bind<LevelConfig>().FromInstance(_levelConfig);
            Container.Bind<GoblinConfig>().FromInstance(_goblinConfig);
            Container.Bind<TowerConfig>().FromInstance(_towerConfig);
            
            Container.Bind<CoinStorage>().WithId(ZenjectIds.Humans).AsCached();
            Container.Bind<CoinStorage>().WithId(ZenjectIds.Goblins).AsCached();
        }
    }
}
