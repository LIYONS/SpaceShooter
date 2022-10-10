using System;
using UnityEngine;

namespace SpaceShooter.GameManagers
{
    public class EventHandler : MonoBehaviour
    {
        private static EventHandler instance;

        public static EventHandler Instance { get { return instance; } }

        public event Action OnEnemyKilled;

        public event Action OnGameOver;

        private void Awake()
        {
            if (instance != null)
            {
                Destroy(this);
            }
            else
            {
                instance = this;
            }
        }

        public void InvokeEnemyKilled()
        {
            OnEnemyKilled?.Invoke();
        }
        public void InvokeOnGameover()
        {
            OnGameOver?.Invoke();
        }
    }
}

