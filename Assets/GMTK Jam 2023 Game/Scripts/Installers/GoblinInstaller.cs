using Zenject;

namespace Avangardum.GmtkJam2023Game.Installers
{
    public class GoblinInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<HealthStorage>().FromComponentOn(gameObject).AsSingle();
            Container.Bind<TerrainDetector>().FromComponentOn(gameObject).AsSingle();
        }
    }
}