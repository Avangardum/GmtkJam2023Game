using UnityEngine;
using Zenject;

namespace Avangardum.GmtkJam2023Game
{
    public class SpikeDamageReceiver : MonoBehaviour
    {
        private TerrainDetector _terrainDetector;
        private HealthStorage _healthStorage;

        [Inject]
        private void Inject(TerrainDetector terrainDetector, HealthStorage healthStorage)
        {
            _terrainDetector = terrainDetector;
            _healthStorage = healthStorage;
        }
    }
}