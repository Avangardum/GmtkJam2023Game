using System;
using System.Collections;
using Avangardum.GmtkJam2023Game.Commands;
using Avangardum.GmtkJam2023Game.Configs;
using UnityEngine;
using UnityEngine.Serialization;
using Zenject;

namespace Avangardum.GmtkJam2023Game
{
    public class GoblinSpawner : MonoBehaviour
    {
        [SerializeField] private float _spawnIntervalSeconds;

        private GoblinCommander _commander;
        private GoblinConfig _goblinConfig;

        [Inject]
        public void Inject(GoblinCommander commander, GoblinConfig goblinConfig)
        {
            _commander = commander;
            _goblinConfig = goblinConfig;
        }

        private void Start()
        {
            StartCoroutine(Loop());
        }

        private IEnumerator Loop()
        {
            yield return new WaitForSeconds(_spawnIntervalSeconds);
            Iteration();
        }

        private void Iteration()
        {
            var command = _commander.RequestCommand();
            switch (command)
            {
                case SpawnGoblinCommand spawnGoblinCommand:
                    SpawnGoblin(spawnGoblinCommand.Id);
                    break;
            }
        }

        private void SpawnGoblin(string id)
        {
            // TODO
        }
    }
}