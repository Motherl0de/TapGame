
using UnityEngine;
using UnityEngine.UI;

namespace TapGame
{
    public class SpawnEgg : MonoBehaviour
    {
        [SerializeField] private Object[] _rewardSprite;
        [SerializeField] private Transform _spawnPoint;
        public void SpawnRandomPrefab()
        {
            var randomPrefab = _rewardSprite[Random.Range(0, _rewardSprite.Length)];
            var newObj = Instantiate(randomPrefab, _spawnPoint.position, Quaternion.identity);

            Debug.Log($"Заменили спрайт на {newObj}");
            ScoreTap.Score = 0;
        }
    }
}
