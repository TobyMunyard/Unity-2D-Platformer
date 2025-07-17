using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;

    public int totalCoins = 0;
    public int totalDeaths = 0;

    [SerializeField] private TMP_Text text;
    [SerializeField] private TMP_Text deathText;


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
    }

    public void AddDeath()
    {
        totalDeaths += 1;
        deathText.text = "Deaths: " + totalDeaths;
    }
}
