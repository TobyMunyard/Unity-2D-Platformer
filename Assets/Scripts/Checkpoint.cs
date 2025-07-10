using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public PlayerDeath playerDeath;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerDeath.lastCheckpoint = transform;
        }
    }
}
