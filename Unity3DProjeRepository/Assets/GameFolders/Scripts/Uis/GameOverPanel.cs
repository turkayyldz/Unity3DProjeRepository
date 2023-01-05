using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity3DProjeRepository.Managers;

namespace Unity3DProjeRepository.Uis
{
    public class GameOverPanel : MonoBehaviour
    {
        public void YesClicked()
        {
            GameManager.Instance.LoadLevelScene();
        }
        public void NoClicked()
        {
            GameManager.Instance.LoadMenuScene();
        }
    }
    

}
