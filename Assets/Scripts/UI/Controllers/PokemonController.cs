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

        [ContextMenu("SetUp")]
        public void SetUp()
        {
            if (pokemonData.PokemonType == PokemonType.Ice)
            {
                Debug.Log("Estas ardido");
            }
            
            pokemonView.ChangeName(pokemonData.Name);
            pokemonView.ChangeLevel(pokemonData.CurrentLevel);
            pokemonView.ChangeLife(pokemonData.CurrentLife, pokemonData.MaxLife);
            pokemonView.ChangeImage(pokemonData.CurrentSprite);
        }

    }
}