using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    public void Die()
    {
        Destroy(gameObject, .2f);
        gameManager.RestartGame();
    }
}
