using System;
using UnityEngine;

namespace Pokemon
{
    [ CreateAssetMenu(fileName = "Pokemon", menuName = "Data/Pokemon") ]
    public class PokemonDataBase : ScriptableObject
    {
        public string Name;
        public PokemonAttributes Attributes;
        public Sprite FrontSprite;
        public Sprite BackSprite;
    }
    
    [Serializable]
    public class PokemonAttributes
    {
        public int HP;
        public int Attack;
        public int Defense;
    }
}