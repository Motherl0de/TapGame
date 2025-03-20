
using System;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace TapGame
{
    public class ScoreTap : MonoBehaviour
    {
        [SerializeField] private TMP_Text _scoreText;
        [SerializeField] private Sprite _image;
        [SerializeField]private Button _button;
        [SerializeField] private ParticleSystem _particleSystem;
        private static int _score = 0;
        public static int Score
        {
            get => _score;
            set
            {
                _score = value;
                ScoreSet?.Invoke(value);
            }
        }

        public static UnityEvent<int> ScoreSet = new();

        private void OnEnable()
        {
            ScoreSet.AddListener(UpdateScore);
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

        public void EffectBom()
        {
            if (Score == 10)
            {
                var particle = Instantiate(_particleSystem, _button.transform.position, Quaternion.identity);
                particle.Play();
                Destroy(particle, 1f);
            }
        }

        private void Update()
        {
            if (_score >= 10)
            {
                _button.image.sprite = _image;
            }
        }

        private void OnDisable()
        {
            ScoreSet.RemoveListener(UpdateScore);
        }
    }
}
