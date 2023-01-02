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
        
        Mover _mover;
        DefaultInput _input;

        bool _isForceUp;
        private void Awake()
        {
           
            _input = new DefaultInput();
            _mover=new Mover(GetComponent<Rigidbody>());
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
        }
        private void FixedUpdate()
        {
            //fizik iþlemleri
            if (_isForceUp)
            {
                _mover.FixedTick();   
            }
            
        }
    }
}

