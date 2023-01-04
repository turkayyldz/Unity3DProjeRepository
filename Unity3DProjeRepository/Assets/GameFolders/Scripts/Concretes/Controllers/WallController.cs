using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Unity3DProjeRepository.Managers;


namespace Unity3DProjeRepository.Controllers
{
    public class WallController : MonoBehaviour
    {
        private void OnCollisionEnter(Collision other)
        {
            PlayerController player = other.collider.GetComponent<PlayerController>();
            if (player !=null)
            {
                GameManager.Instance.GameOver();
                
            }
        }
    }
}

