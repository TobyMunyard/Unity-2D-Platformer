using UnityEngine;

public class CoinCollect : MonoBehaviour
{
    public int coinValue = 1;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            ScoreManager.Instance.AddCoins(coinValue);
            Destroy(gameObject);
        }
    }
}
