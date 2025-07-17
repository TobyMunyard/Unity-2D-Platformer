using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{
    public Transform lastCheckpoint;
    [SerializeField] private ScoreManager scoreManager;
    
    public void Die()
    {
        transform.position = lastCheckpoint.position;
        scoreManager.AddDeath();
    }
}
