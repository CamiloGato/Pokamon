using System;
using UnityEngine;

namespace Pokemon
{
    [Serializable]
    class PokemonData
    {
        [SerializeField] private bool _isPlayer;
        [SerializeField] private int _currentLevel;
        [SerializeField] private int _currentLife;
        [SerializeField] private PokemonDataBase _pokemonDataBase;

        public int Attack => _currentLevel * _pokemonDataBase.Attributes.Attack;
        public int Defense => _currentLevel * _pokemonDataBase.Attributes.Defense;
        public int MaxLife => _currentLevel * _pokemonDataBase.Attributes.HP;
        public int CurrentLevel => _currentLevel;
        public int CurrentLife => _currentLife;
        public string Name => _pokemonDataBase.Name;
        public Sprite CurrentSprite =>
            (_isPlayer)
            ? _pokemonDataBase.BackSprite
            : _pokemonDataBase.FrontSprite;

        public PokemonType PokemonType => _pokemonDataBase.Type;

        // {
        //
        //     if (isPlayer)
        //     {
        //         return _pokemonDataBase.BackSprite
        //     }
        //     else
        //     {
        //         return _pokemonDataBase.FrontSprite
        //     }
        //     
        // }
    }
}