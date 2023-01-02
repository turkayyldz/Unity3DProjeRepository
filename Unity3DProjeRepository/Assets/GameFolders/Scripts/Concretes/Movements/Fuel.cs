using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unity3DProjeRepository.Movements
{
    public class Fuel : MonoBehaviour
    {
        [SerializeField] float _maxFuel = 100f;
        [SerializeField] float _currentFuel ;
        [SerializeField] ParticleSystem _particle;

        public bool IsEmpty => _currentFuel < 1f;

        private void Awake()
        {
            _currentFuel = _maxFuel;
        }
        public void FuelIncrease(float increase)
        {
            // incurease s�rekli artt�k�a math.min iki de�er aras�ndaki minunmum de�eri alacak 
            // _currentFuel _maxFuel de�erini ge�ince otamatik olarak max� de�er olarak alacak.
            _currentFuel += increase;
            _currentFuel = Mathf.Min(_currentFuel, _maxFuel);
            if (_particle.isPlaying)
            {
                _particle.Stop();
            }

        }
        public void FuelDecrease(float decrease)
        {
            _currentFuel -= decrease;
            _currentFuel = Mathf.Max(_currentFuel, 0f);
            if (_particle.isStopped)
            {
                _particle.Play();
            }
        }
    }
}

