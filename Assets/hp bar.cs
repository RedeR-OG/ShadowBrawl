using UnityEngine;

public class hpbar : MonoBehaviour
{
    public PlayerHP playerHp;
    public SpriteRenderer hpBar;

    public Sprite hp3;
    public Sprite hp2;
    public Sprite hp1;
    public Sprite hp0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerHp.nowHP >= 3)
        {
            hpBar.sprite = hp3;
        }
        else if (playerHp.nowHP == 2)
        {
            hpBar.sprite = hp2;
        }
        else if (playerHp.nowHP == 1)
        {
            hpBar.sprite = hp1;
        }
        else
            hpBar.sprite = hp0;
        
    }
}
