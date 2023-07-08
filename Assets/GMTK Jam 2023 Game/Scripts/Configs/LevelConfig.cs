using System.Collections.Generic;
using UnityEngine;

namespace Avangardum.GmtkJam2023Game.Configs
{
    public class LevelConfig : ScriptableObject
    {
        [field: SerializeField] public List<Vector3> Waypoints;
    }
}