using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using Unity3DProjeRepository.Inputs;

namespace Unity3DProjeRepository.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] float _force;
        Rigidbody _rigidbody;
        DefaultInput _input;
        bool _isForceUp;
        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
            _input = new DefaultInput();
        }
        private void Update()
        {
            //ýnput
            if (_input.IsFotceUp)
            {
                _isForceUp = true;
            }
            else
            {
                _isForceUp = false;
            }
        }
        private void FixedUpdate()
        {
            //fizik iþlemleri
            if (_isForceUp)
            {
                _rigidbody.AddForce(Vector3.up * Time.deltaTime*_force);
            }
            
        }
    }
}

