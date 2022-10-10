using UnityEngine;

public class Boundaries : MonoBehaviour
{
    [SerializeField] private Vector2 offest;

    private Vector2 screenBounds;
    private Transform playerTransform;
    private Vector3 viewPos;
    private void Awake()
    {
        playerTransform = this.transform;
    }
    private void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        Debug.Log(screenBounds);
    }
    private void Update()
    {
        viewPos = playerTransform.position;
        viewPos.x = Mathf.Clamp(viewPos.x, -screenBounds.x, screenBounds.x);
        viewPos.y = Mathf.Clamp(viewPos.y, -screenBounds.y, screenBounds.y);
        playerTransform.position=viewPos;
    }
}
