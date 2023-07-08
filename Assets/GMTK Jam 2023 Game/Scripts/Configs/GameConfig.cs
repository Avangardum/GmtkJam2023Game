using UnityEngine;

namespace Avangardum.GmtkJam2023Game.Configs
{
    public class GameConfig : ScriptableObject
    {
        [field: SerializeField] public float SpikesDps { get; private set; }
        [field: SerializeField] public float ThicketsSlow { get; private set; }
        [field: SerializeField] public float GameOverCountdownTimeSeconds { get; private set; }
    }
}