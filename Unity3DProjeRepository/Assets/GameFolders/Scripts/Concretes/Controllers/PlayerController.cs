using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using Unity3DProjeRepository.Inputs;
using Unity3DProjeRepository.Movements;

namespace Unity3DProjeRepository.Controllers
{
    public class PlayerController : MonoBehaviour
    {

        [SerializeField] float _turnSpeed = 10f;
        [SerializeField] float _force = 55f;

        Mover _mover;
        DefaultInput _input;
        Rotator _rotator;

        bool _isForceUp;
        float _leftRight;

        public float TurnSpeed => _turnSpeed;
        public float Force => _force;
        private void Awake()
        {
           
            _input = new DefaultInput();
            _mover=new Mover(this);
            _rotator = new Rotator(this);
        }
        private void Update()
        {
            //ýnput
            if (_input.IsForceUp)
            {
                _isForceUp = true;
               
            }
            else
            {
                _isForceUp = false;
               
            }
            _leftRight = _input.LeftRight;
        }
        private void FixedUpdate()
        {
            //fizik iþlemleri
            if (_isForceUp)
            {
                _mover.FixedTick();   
            }
            _rotator.FixedTick(_leftRight);
            
        }
    }
}

