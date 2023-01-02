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
        public void FixedTick(float direction)
        {
            if (direction == 0)
            {
                //freezeRotation = yukarý aþþaðýya yapmadýðýmýz sürece rotasyonu dondurmak.
                if (_rigidbody.freezeRotation) _rigidbody.freezeRotation = false;
                return;

                
            }
            if (!_rigidbody.freezeRotation) _rigidbody.freezeRotation = true;
            //Vector3.back =  d ye bastýðýmýzda -  yönünde hareket etmesini istediðimiz için ters iþlemde back kullanýyoruz. -1 döndürür.
            _playerController.transform.Rotate(Vector3.back * Time.deltaTime*direction*_playerController.TurnSpeed);
            

            

            
        }
    }
}

