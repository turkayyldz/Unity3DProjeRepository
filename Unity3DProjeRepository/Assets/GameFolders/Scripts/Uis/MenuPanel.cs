using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity3DProjeRepository.Managers;


namespace Unity3DProjeRepository.Uis
{
    public class MenuPanel : MonoBehaviour
    {
        public void StartClicked()
        {
            GameManager.Instance.LoadLevelScene(1);
        }
        public void ExitClicked()
        {
            GameManager.Instance.Exit();
        }
    }
}

