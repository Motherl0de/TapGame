using UnityEngine;

namespace TapGame
{
    public class SpawnEgg : MonoBehaviour
    {
        [SerializeField] private GameObject[] _eggs;
        [SerializeField] private RectTransform _spawnPoint;

        public void SpawnRandomPrefab()
        {
            var randomPrefab = _eggs[Random.Range(0, _eggs.Length)];
            Instantiate(randomPrefab, _spawnPoint.transform.position, Quaternion.identity, parent: _spawnPoint);
            Debug.Log($"Заменили спрайт ");
            ScoreTap.Score = 0;
        }

        public void SpawnPrefab(GameObject prefab)
        {
            Instantiate(prefab, _spawnPoint.transform.position, Quaternion.identity, parent: _spawnPoint);
            Debug.Log($"Заменили спрайт ");
            ScoreTap.Score = 0;
        }
    }
}
