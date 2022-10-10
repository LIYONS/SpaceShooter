using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float movementSpeed;

    private Rigidbody2D rigidBody;
    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        HandleMovement();
    }

    private void HandleMovement()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rigidBody.MovePosition( transform.position + Vector3.up*movementSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            rigidBody.MovePosition(transform.position + Vector3.down * movementSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            rigidBody.MovePosition(transform.position + Vector3.left * movementSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rigidBody.MovePosition(transform.position + Vector3.right * movementSpeed * Time.deltaTime);
        }
    }
}
