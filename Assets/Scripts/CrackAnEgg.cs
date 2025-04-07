using UnityEngine;
using UnityEngine.Events;

namespace TapGame
{
    internal sealed class CrackAnEgg : MonoBehaviour
    {
        [SerializeField] private int _scoreTarget = 50;
        [SerializeField] private GameObject _shell;
        [SerializeField] private GameObject _pet;
        [SerializeField] private UnityEvent _cracked = new();

        private void OnEnable() => ScoreTap.ScoreSet.AddListener(CheckScore);
        private void OnDisable() => ScoreTap.ScoreSet.RemoveListener(CheckScore);

        private void CheckScore(int score)
        {
            if (score < _scoreTarget) return;

            _cracked.Invoke();

            _shell.SetActive(false);
            _pet.SetActive(true);

            ScoreTap.Score = 0;

            Destroy(this);
        }
    }
}
