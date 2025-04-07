using System;
using UnityEngine;

namespace TapGame
{
    internal sealed class ParticleEffectPlay : MonoBehaviour
    {
        private ParticleSystem _particleSystem;

        private void OnEnable() => _particleSystem = FindObjectOfType<ParticleSystem>();
        private void OnDisable() => _particleSystem = null;

        public void Play() => _particleSystem.Play();
    }
}
