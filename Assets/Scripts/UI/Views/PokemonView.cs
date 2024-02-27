using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Views
{
    public class PokemonView : MonoBehaviour
    {
        [Header("Requirements")]
        [SerializeField] private TMP_Text pokemonName;
        [SerializeField] private TMP_Text level;
        [SerializeField] private TMP_Text currentLife;
        [SerializeField] private Image currentImage;
        
        public void ChangeName(string newName)
        {
            pokemonName.text = newName;
        }

        public void ChangeLevel(int level)
        {
            this.level.text = $"LVL. {level}";
        }

        public void ChangeLife(int amount, int max)
        {
            currentLife.text = $"HP: {amount}/{max}";
        }

        public void ChangeImage(Sprite sprite)
        {
            currentImage.sprite = sprite;
        }

    }
}