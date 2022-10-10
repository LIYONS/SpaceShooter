using UnityEngine;

public class BulletManager : MonoBehaviour
{
    [SerializeField] private float speed;

    private Rigidbody2D rigidBody;
    private Vector2 screenBounds;
    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    private void Update()
    {
        if(transform.position.x>screenBounds.x)
        {
            Destroy(gameObject);
        }
        rigidBody.MovePosition(transform.position + Vector3.right * speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<EnemyManager>())
        {
            EventHandler.Instance.InvokeEnemyKilled();
            collision.GetComponent<EnemyManager>().Die();
            Destroy(this.gameObject);
        }
    }
}