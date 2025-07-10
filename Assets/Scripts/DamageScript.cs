using UnityEngine;

public class DamageScript : MonoBehaviour
{
    [SerializeField] private GameObject player;
    public PlayerDeath playerDeath;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            playerDeath.Die();
        }
    }
}
