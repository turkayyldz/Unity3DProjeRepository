using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Unity3DProjeRepository.Managers;

namespace Unity3DProjeRepository.Controllers
{
    public class FinishFloorController : MonoBehaviour
    {
        [SerializeField] GameObject _finishFireWork;
        [SerializeField] GameObject _finisLight;

        private void OnCollisionEnter(Collision other)
        {
            PlayerController player = other.collider.GetComponent<PlayerController>();
            if (player == null) return;
            // üstten aþþaðýya dokunmasýný saðlýyor.
            if (other.GetContact(0).normal.y==-1)
            {
                _finishFireWork.gameObject.SetActive(true);
                _finisLight.gameObject.SetActive(true);
                GameManager.Instance.MissionSucced();
            }
            else
            {
                //Game oVER
                GameManager.Instance.GameOver();
            }
           
        }
    }
}

