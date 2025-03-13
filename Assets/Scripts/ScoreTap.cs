
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace TapGame
{
    public class ScoreTap : MonoBehaviour
    {
        [SerializeField] private TMP_Text _scoreText;
        [SerializeField] private Sprite _image;
        private int _score = 0;
        [SerializeField]private Button _button;

        public void AddScore()
        {
            _score += 1;
            _scoreText.text = "Score: " + _score;
        }

        private void Update()
        {
            if (_score > 10)
            {
                _button.image.sprite = _image;
            }
        }
    }
}
