using UnityEngine;
using SpaceShooter.GameManagers;
namespace SpaceShooter.Player
{
    public class PlayerHealth : MonoBehaviour
    {
        public void Die()
        {
            EventHandler.Instance.InvokeOnGameover();
            Destroy(gameObject, .2f);         
        }
    }
}
