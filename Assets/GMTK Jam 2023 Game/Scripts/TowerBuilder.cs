using System.Collections;
using Avangardum.GmtkJam2023Game.Configs;
using UnityEngine;

namespace Avangardum.GmtkJam2023Game
{
    public class TowerBuilder : MonoBehaviour
    {
        [SerializeField] private float _buildIntervalSeconds;

        private HumanCommander _commander;
        private TowerConfig _towerConfig;

        private void Start()
        {
            StartCoroutine(Loop());
        }

        private IEnumerator Loop()
        {
            yield return new WaitForSeconds(_buildIntervalSeconds);
            Iteration();
        }

        private void Iteration()
        {
            
        }
    }
}