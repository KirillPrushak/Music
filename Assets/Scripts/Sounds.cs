using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class Sounds : MonoBehaviour
    {
        [SerializeField]
        private AudioSource _musicSource;
        [SerializeField] private float _muffledMultiplier = 0.3f;
        [Header("Debug")]
        [SerializeField] private float _realSound = 1;
        [SerializeField] private bool muffled = false;

        private void Awake()
        {
            if (_musicSource == null)
            {
                throw new NullReferenceException();
            }
        }
        public void MasterVolume(float volume)
        {
            _realSound = volume;
            if (muffled)
            {
                Muffle();
            }
            else
            {
                Demuffle();
            }

        }
        
        public void ToggleMusic()
        {
            _musicSource.mute = !_musicSource.mute;
        }
        
        public void Toggle(bool value)
        {
            _musicSource.mute = value;
        }

        public void Muffle()
        {
            _musicSource.volume = _realSound * _muffledMultiplier;
            muffled = true;
        }

        public void Demuffle()
        {
            _musicSource.volume = _realSound;
            muffled = true;
        }
    }
}