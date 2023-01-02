using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity3DProjeRepository.Controllers;

namespace Unity3DProjeRepository.Movements
{
    public class Rotator
    {
        Rigidbody _rigidbody;
        PlayerController _playerController;
        public Rotator(PlayerController playerController)
        {
            _playerController = playerController;
            _rigidbody = playerController.GetComponent<Rigidbody>();
        }
        public void FixedUpdate()
        {

        }
    }
}

