using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace TapGame
{
    public class ScoreTap : MonoBehaviour
    {
        private static int _score = 0;

        [SerializeField] private TMP_Text _scoreText;
        [SerializeField] private GameObject _firstEgg;
        [SerializeField] private Button _button;
        [SerializeField] private Canvas _canvas;
        [SerializeField] private SpawnEgg _eggSpawner;

        public static int Score
        {
            get => _score;
            set
            {
                _score = value;
                ScoreSet?.Invoke(value);
            }
        }

        public static readonly UnityEvent<int> ScoreSet = new();

        private void OnEnable()
        {
            ScoreSet.AddListener(UpdateScore);

            _eggSpawner.SpawnPrefab(_firstEgg);
        }

        private void UpdateScore(int arg0)
        {
            _scoreText.text = "Score: " + arg0;
        }

        public void AddScore()
        {
            Score += 1;
            _scoreText.text = "Score: " + Score;
        }

        private void OnDisable()
        {
            ScoreSet.RemoveListener(UpdateScore);
        }
    }
}
