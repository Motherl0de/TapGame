
using UnityEngine;
using UnityEngine.UI;

namespace TapGame
{
    public class SpawnEgg : MonoBehaviour
    {
        [SerializeField] private Sprite[] _rewardSprite;
        [SerializeField] private Image _spawnPoint;
        public void SpawnRandomPrefab()
        {
            var randomPrefab = _rewardSprite[Random.Range(0, _rewardSprite.Length)];
            //var newObj = Instantiate(randomPrefab, _spawnPoint.transform.position, Quaternion.identity);
            _spawnPoint.sprite = randomPrefab;
            Debug.Log($"Заменили спрайт ");
            ScoreTap.Score = 0;
        }
    }
}
