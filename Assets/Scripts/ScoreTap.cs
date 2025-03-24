
using System;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using Random = UnityEngine.Random;


namespace TapGame
{
    public class ScoreTap : MonoBehaviour
    {
        [SerializeField] private TMP_Text _scoreText;
        [SerializeField] private GameObject _image;
        [SerializeField]private Button _button;
        [SerializeField] private Canvas _canvas;
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
            var pos = new Vector3(_button.transform.position.x, _button.transform.position.y, -1);
            Instantiate(_image, pos, Quaternion.identity, parent: _canvas.transform);
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
                var pos = new Vector3(_button.transform.position.x, _button.transform.position.y, -2);
                var particle = Instantiate(_particleSystem, pos, Quaternion.identity);
                particle.Play();
                Destroy(particle, 1f);
            }
        }

        private void OnDisable()
        {
            ScoreSet.RemoveListener(UpdateScore);
        }
    }
}
