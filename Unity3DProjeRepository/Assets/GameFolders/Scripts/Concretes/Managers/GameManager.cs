using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


namespace Unity3DProjeRepository.Managers
{
    public class GameManager : MonoBehaviour
    {
        
        public event System.Action OnGameOver;
        public event System.Action OnMissionSucced;
        public static GameManager Instance { get; private set; }
        public object HandleOnMissionSucced { get; internal set; }

        private void Awake()
        {
            SingletonThisGameObject();
        }
        private void SingletonThisGameObject()
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(this.gameObject);
            }
            else
            {
                Destroy(this.gameObject);
            }
        }
        public void GameOver()
        {

            //if (OnGameOver!=null)
            //{
            //    GameOver();
            //}
            //kýsa yazýmý 
            OnGameOver?.Invoke();
        }
        public void MissionSucced()
        {
            OnMissionSucced?.Invoke();
        }
       
        public void LoadLevelScene(int levelIndex=0)
        {
            //Coroutine metodlar diðer methorlar arasýndaki fark coroutine metodlar çalýþýrken baþka metodlarda çalýþabiliyor
            // bötlelikle oyun oynanurken içeride iþlem yaýplacak metodun verileri fazla ise baþka metoda geçerek oyunun donmamasýný saðlýyor. 
            StartCoroutine(LoadLevelSceneAsync(levelIndex));
        }
        private IEnumerator LoadLevelSceneAsync(int levelIndex)
        {
            yield return SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex+levelIndex);
        }
        public void LoadMenuScene()
        {
            StartCoroutine(LoadMenuSceneAsync());
        }
        private IEnumerator LoadMenuSceneAsync()
        {
            
            yield return SceneManager.LoadSceneAsync("Menu");
        }
        public void Exit()
        {
            Debug.Log("Exit process on triggered");
            Application.Quit();
        }
    }
}

