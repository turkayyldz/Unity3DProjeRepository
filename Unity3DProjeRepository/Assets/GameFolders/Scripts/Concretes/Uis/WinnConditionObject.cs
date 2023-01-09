using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity3DProjeRepository.Managers;



namespace Unity3DProjeRepository.Uis
{
    public class WinnConditionObject : MonoBehaviour
    {
        [SerializeField] GameObject _winConditionPanel;
        private void Awake()
        {
            if (_winConditionPanel.activeSelf)
            {
                _winConditionPanel.SetActive(false);
            }
        }
        private void OnEnable()
        {
            GameManager.Instance.OnMissionSucced += HandleOnMissionSuccen;
        }

        private void OnDisable()
        {
            GameManager.Instance.OnMissionSucced -= HandleOnMissionSuccen;
        }
        private void HandleOnMissionSuccen()
        {
            if (!_winConditionPanel.activeSelf)
            {
                _winConditionPanel.SetActive(true);
            }
        }
    }
}

