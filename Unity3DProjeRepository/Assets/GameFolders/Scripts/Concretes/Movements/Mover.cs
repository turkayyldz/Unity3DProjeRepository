using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unity3DProjeRepository.Movements
{
    public class Mover
    {
        Rigidbody _rigidbody;
        public  Mover (Rigidbody rigidbody)
        {
            _rigidbody = rigidbody;
            Debug.Log("qasd");

        }
        public void FixedTick()
        {
            _rigidbody.AddRelativeForce(Vector3.up * Time.deltaTime * 55f);
        }

    }
}
    


