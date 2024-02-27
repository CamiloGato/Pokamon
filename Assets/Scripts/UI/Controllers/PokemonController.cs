using Pokemon;
using UI.Views;
using UnityEngine;

namespace UI.Controllers
{
    public class PokemonController : MonoBehaviour
    {
        [Header("Requirement")]
        [SerializeField] private PokemonData pokemonData;
        [SerializeField] private PokemonView pokemonView;

        public void Start()
        {
            pokemonView.ChangeName(pokemonData.PokemonDataBase.Name);
            pokemonView.ChangeLevel(pokemonData.currentLevel);
            pokemonView.ChangeLife(pokemonData.currentLife, pokemonData.MaxLife);
            pokemonView.ChangeImage(pokemonData.PokemonDataBase.FrontSprite);
        }

    }
}