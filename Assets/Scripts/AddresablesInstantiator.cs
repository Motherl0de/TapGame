using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace TapGame
{
    public sealed class AddresablesInstantiator : MonoBehaviour
    {
        [SerializeField] private AssetReferenceSprite _prefabButtonTap;
        [SerializeField]private Transform _parent;

        private void Start()
        {
            _prefabButtonTap.LoadAssetAsync().Completed += OnAddresableLoaded;
        }

        private void OnAddresableLoaded(AsyncOperationHandle<Sprite> obj)
        {
            if (obj.Status == AsyncOperationStatus.Succeeded)
            {
                Instantiate(obj.Result, _parent);
            }
            else
            {
                Debug.LogError("Failed to load asset");
            }
        }
    }
}
