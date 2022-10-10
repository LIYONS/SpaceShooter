using UnityEngine;

namespace SpaceShooter.Player
{
    public class Boundaries : MonoBehaviour
    {
        private Vector2 screenBounds;
        private Transform playerTransform;
        private Vector3 viewPos;
        private float objectWidth;
        private float objectHeight;
        private void Start()
        {
            playerTransform = this.transform;
            screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
            objectWidth = GetComponent<SpriteRenderer>().bounds.size.x / 2;
            objectHeight = GetComponent<SpriteRenderer>().bounds.size.y / 2;
        }
        private void Update()
        {
            viewPos = playerTransform.position;
            viewPos.x = Mathf.Clamp(viewPos.x, -screenBounds.x + objectWidth, screenBounds.x - objectWidth);
            viewPos.y = Mathf.Clamp(viewPos.y, -screenBounds.y + objectHeight, screenBounds.y - objectHeight);
            playerTransform.position = viewPos;
        }
    }
}