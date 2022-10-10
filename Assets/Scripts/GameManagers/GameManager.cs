using UnityEngine;
using UnityEngine.SceneManagement;

namespace SpaceShooter.GameManagers
{
    public class GameManager : MonoBehaviour
    {
        private void Start()
        {
            EventHandler.Instance.OnGameOver += OnGameOver;
        }

        private void OnDisable()
        {
            EventHandler.Instance.OnGameOver -= OnGameOver;
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                RestartGame();
            }
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                QuitGame();
            }
        }

        private void OnGameOver()
        {
            RestartGame();
        }

        public void RestartGame()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        public void QuitGame()
        {
            Application.Quit();
        }
    }
}
