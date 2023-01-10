using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity3DProjeRepository.Abstracts.Controllers;

namespace Unity3DProjeRepository.Controllers
{
    public class MoverWallController : WallController
    {
        [SerializeField] Vector3 _direction;
       
        [SerializeField] float _speed=1f;
       


        Vector3 _startPosition;
        float _factor;
        private const float FULL_CIRCLE = Mathf.PI * 2f;
        private void Awake()
        {
            _startPosition = transform.position;
        }
        private void Update()
        {
            float cycle = Time.time / _speed;
            float sinWave =Mathf.Sin( cycle * FULL_CIRCLE);

            // _factor = Mathf.Abs(sinWave);
            _factor = sinWave / 2f + 0.5f;
            Vector3 offset = _direction * _factor;
            transform.position = offset + _startPosition;
            
        }
    }
}

