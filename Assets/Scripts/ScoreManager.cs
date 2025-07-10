using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;

    public int totalCoins = 0;

    [SerializeField] private TMP_Text text;

    void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    public void AddCoins(int amount)
    {
        totalCoins += amount;
        text.text = "Score: " + totalCoins;
        Debug.Log("Coins: " + totalCoins);
    }
}
