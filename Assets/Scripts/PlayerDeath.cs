using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{
    public Transform lastCheckpoint;
    
    public void Die()
    {
        transform.position = lastCheckpoint.position;
    }
}
