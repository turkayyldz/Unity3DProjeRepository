using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using Unity3DProjeRepository.Inputs;
using Unity3DProjeRepository.Movements;
using Unity3DProjeRepository.Managers;

namespace Unity3DProjeRepository.Controllers
{
    public class PlayerController : MonoBehaviour
    {

        [SerializeField] float _turnSpeed = 10f;
        [SerializeField] float _force = 55f;

        Mover _mover;
        DefaultInput _input;
        Rotator _rotator;
        Fuel _fuel;

        bool _canMove;
        bool _canForceUp;
        float _leftRight;

        public float TurnSpeed => _turnSpeed;
        public float Force => _force;
        private void Awake()
        {
           
            _input = new DefaultInput();
            _mover=new Mover(this);
            _rotator = new Rotator(this);
            _fuel = GetComponent<Fuel>();
        }
        private void Start()
        {
            _canMove = true;
        }
        private void OnEnable()
        {
            GameManager.Instance.OnGameOver += HandleOnEventTriggered;
        }
        private void OnDisable()
        {
            GameManager.Instance.OnGameOver -= HandleOnEventTriggered;
        }

        private void Update()
        {
            if (!_canMove) return;
            

            
            //ýnput
            if (_input.IsForceUp && !_fuel.IsEmpty)
            {
                _canForceUp = true;
               
            }
            else
            {
                _canForceUp = false;
                _fuel.FuelIncrease(0.01f);
               
            }
            _leftRight = _input.LeftRight;
        }
        private void FixedUpdate()
        {
            //fizik iþlemleri
            if (_canForceUp)
            {
                _mover.FixedTick();
                _fuel.FuelDecrease(0.2f);
            }
            _rotator.FixedTick(_leftRight);
            
        }
        private void HandleOnEventTriggered()
        {
            _canMove = false;
            _canForceUp = false;
            _leftRight = 0f;
            _fuel.FuelIncrease(0f);
        }
    }
}

