using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace TapGame
{
    public class ScoreTap : MonoBehaviour
    {
        [SerializeField] private TMP_Text _scoreText;
        private int _score = 0;

        public void AddScore()
        {
            _score += 1;
            _scoreText.text = "Score: " + _score;
        }
    }
}
