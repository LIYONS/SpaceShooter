using UnityEngine;

public class EnemyManager : MonoBehaviour
{

    [SerializeField] private float speed;

    private Vector2 screenBounds;
    private Rigidbody2D rigidBody;
    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }
    private void Update()
    {
        if(transform.position.x<-screenBounds.x)
        {
            Destroy(gameObject);
        }
        rigidBody.MovePosition(transform.position + Vector3.left * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.GetComponent<PlayerMovement>())
        {
            collision.gameObject.GetComponent<PlayerHealth>().Die();
        }
    }
    public void Die()
    {
        Destroy(gameObject);
    }
}
