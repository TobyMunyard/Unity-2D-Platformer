using UnityEngine;

public class CoinRotator : MonoBehaviour
{
    public Sprite[] coinSprites; 
    public float frameRate = 0.1f;   

    private SpriteRenderer spriteRenderer;
    private int currentFrame;
    private float timer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= frameRate)
        {
            timer = 0f;
            currentFrame = (currentFrame + 1) % coinSprites.Length;
            spriteRenderer.sprite = coinSprites[currentFrame];
        }
    }
}
