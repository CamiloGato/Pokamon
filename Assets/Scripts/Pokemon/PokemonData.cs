using System;

namespace Pokemon
{
    [Serializable]
    class PokemonData
    {
        public int currentLevel;
        public int currentLife;
        public PokemonDataBase PokemonDataBase;

        public int Attack => currentLevel * PokemonDataBase.Attributes.Attack;
        public int Defense => currentLevel * PokemonDataBase.Attributes.Defense;
        public int MaxLife => currentLevel * PokemonDataBase.Attributes.HP;
    }
}