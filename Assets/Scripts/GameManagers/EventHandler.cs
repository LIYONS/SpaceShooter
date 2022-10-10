using System;
using UnityEngine;

public class EventHandler : MonoBehaviour
{
    private static EventHandler instance;

    public static EventHandler Instance { get { return instance; } }

    public event Action OnEnemyKilled;

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

}
