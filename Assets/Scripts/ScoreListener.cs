using UnityEngine;
using UnityEngine.Events;

namespace TapGame
{
    internal sealed class ScoreListener : MonoBehaviour
    {
        [SerializeField] private UnityEvent<int> _scoreChanged = new();

        private void OnEnable() => ScoreTap.ScoreSet.AddListener(_scoreChanged.Invoke);
        private void OnDisable() => ScoreTap.ScoreSet.RemoveListener(_scoreChanged.Invoke);
    }
}
