using UnityEngine;

namespace TapGame
{
    public sealed class DestroyGameObject : MonoBehaviour
    {
        private ADS _ads;
        [SerializeField]private GameObject _target;

        private void OnEnable()
        {
            _ads = FindObjectOfType<ADS>();
            _ads.AdsShown.AddListener(DestroySelf);
        }

        private void DestroySelf()
        {
            Destroy(_target);
        }

        private void OnDisable()
        {
            _ads.AdsShown.RemoveListener(DestroySelf);
            _ads = null;
        }
    }
}
