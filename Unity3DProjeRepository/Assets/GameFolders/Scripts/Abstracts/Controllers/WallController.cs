using UnityEngine;
using Unity3DProjeRepository.Managers;
using Unity3DProjeRepository.Controllers;

namespace Unity3DProjeRepository.Abstracts.Controllers
{
    public abstract class WallController : MonoBehaviour
    {
        private void OnCollisionEnter(Collision other)
        {
            PlayerController player = other.collider.GetComponent<PlayerController>();
            if (player !=null && player.CanMove )
            {
                GameManager.Instance.GameOver();
                
            }
        }
    }
}

