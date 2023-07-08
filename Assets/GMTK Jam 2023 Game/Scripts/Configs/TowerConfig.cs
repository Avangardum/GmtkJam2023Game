using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Avangardum.GmtkJam2023Game.Configs
{
    public class TowerConfig : ScriptableObject
    {
        [Serializable]
        private class Entry
        {
            public string Id;
            public List<int> Prices;
            public List<GameObject> Prefabs;
        }

        [SerializeField] private List<Entry> _entries;

        public int GetTowerPrice(string id, int level) => GetEntry(id).Prices[level - 1];

        public GameObject GetTowerPrefab(string id, int level) => GetEntry(id).Prefabs[level - 1];

        private Entry GetEntry(string id) => _entries.Single(e => e.Id == id);
    }
}