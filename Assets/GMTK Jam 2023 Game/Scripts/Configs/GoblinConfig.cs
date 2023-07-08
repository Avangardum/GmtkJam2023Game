using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Avangardum.GmtkJam2023Game.Configs
{
    public class GoblinConfig : ScriptableObject
    {
        [Serializable]
        private class Entry
        {
            public string Id;
            public int Price;
            public GameObject Prefab;
        }

        [SerializeField] private List<Entry> _entries;

        public int GetGoblinPrice(string id) => GetEntry(id).Price;

        public GameObject GetGoblinPrefab(string id) => GetEntry(id).Prefab;

        private Entry GetEntry(string id) => _entries.Single(e => e.Id == id);
    }
}