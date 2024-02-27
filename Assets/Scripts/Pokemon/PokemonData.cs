using System;
using UnityEngine;

namespace Pokemon
{
    [Serializable]
    public class PokemonData
    {
        public string Name;
        public int Level;
        public int Life;
        public Sprite Sprite;

        private int _maxLife;
        public int MaxLife => Level * Life;
    }
}