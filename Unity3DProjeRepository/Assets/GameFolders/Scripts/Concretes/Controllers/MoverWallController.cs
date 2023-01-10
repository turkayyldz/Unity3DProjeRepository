using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity3DProjeRepository.Abstracts.Controllers;

namespace Unity3DProjeRepository.Controllers
{
    public class MoverWallController : WallController
    {
        [SerializeField] Vector3 _direction;
        [Range(0f,1f)]
        [SerializeField] float _factor;

        Vector3 _startPosition;

        private void Awake()
        {
            _startPosition = transform.position;
        }
        private void Update()
        {
            Vector3 offset = _direction * _factor;
            transform.position = offset + _startPosition;
        }
    }
}

