using System;
using UnityEngine;
using UnityEngine.UI;

namespace TapGame
{
    public class ChangeImage : MonoBehaviour
    {
        [SerializeField]private GameObject _sprite;

        private void Update()
        {
            if (ScoreTap.Score == 50)
            {
                gameObject.GetComponent<SpriteRenderer>().enabled = false;
                _sprite.SetActive(true);
            }
        }
    }
}
