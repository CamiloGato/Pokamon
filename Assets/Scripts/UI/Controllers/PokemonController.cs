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
            pokemonView.ChangeName(pokemonData.Name);
            pokemonView.ChangeLevel(pokemonData.Level);
            pokemonView.ChangeLife(pokemonData.Life, pokemonData.MaxLife);
            pokemonView.ChangeImage(pokemonData.Sprite);
        }

    }
}