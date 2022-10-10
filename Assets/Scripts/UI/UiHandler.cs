using UnityEngine;
using TMPro;

public class UiHandler : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreTxt;
    private int currentScore;
    private const string TXT = "SCORE : ";

    private void Start()
    {
        EventHandler.Instance.OnEnemyKilled+=OnEnemyDied;
        currentScore = 0;
        scoreTxt.text = TXT + currentScore;
    }

    private void OnDisable()
    {
        EventHandler.Instance.OnEnemyKilled -= OnEnemyDied;
    }
    private void OnEnemyDied()
    {
        currentScore++;
        scoreTxt.text = TXT + currentScore;
    }
}
