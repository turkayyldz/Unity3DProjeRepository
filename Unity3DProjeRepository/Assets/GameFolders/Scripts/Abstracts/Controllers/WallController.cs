using UnityEngine;
using Unity3DProjeRepository.Managers;


namespace Unity3DProjeRepository.Controllers
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

