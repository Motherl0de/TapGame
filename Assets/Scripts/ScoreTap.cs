
using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace TapGame
{
    public class ScoreTap : MonoBehaviour
    {
        [SerializeField] private TMP_Text _scoreText;
        [SerializeField] private Sprite _image;
        [SerializeField]private Button _button;
        [SerializeField] private ParticleSystem _particleSystem;
        private int _score = 0;


        public void AddScore()
        {
            _score += 1;
            _scoreText.text = "Score: " + _score;
        }

        public void EffectBom()
        {
            if (_score == 10)
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
    }
}
